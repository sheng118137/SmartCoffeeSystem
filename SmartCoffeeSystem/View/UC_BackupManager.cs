using Sunny.UI;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_BackupManager : UserControl
    {
        public UC_BackupManager()
        {
            InitializeComponent();
        }

        //備份資料庫 (Backup)
        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "SQL Server 備份檔 (*.bak)|*.bak";
                sfd.Title = "選擇備份檔案儲存位置";
                sfd.FileName = $"POS_Backup_{DateTime.Now:yyyyMMdd_HHmm}.bak";

                //建議預設在 D 槽或 C 槽的公開資料夾，避免 SQL Server 服務權限不足
                sfd.InitialDirectory = @"C:\";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 載入
                        Cursor.Current = Cursors.WaitCursor;

                        using (var db = new POSContext())
                        {
                            string dbName = db.Database.Connection.Database;
                            string backupPath = sfd.FileName;

                            //備份 SQL 語法
                            string sqlCommand = $"BACKUP DATABASE [{dbName}] TO DISK = '{backupPath}' WITH FORMAT, INIT, STATS = 10";

                            //執行備份
                            db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, sqlCommand);
                        }

                        UIMessageBox.ShowSuccess($"資料庫備份成功！\n檔案位置：{sfd.FileName}");
                    }
                    catch (Exception ex)
                    {
                        UIMessageBox.ShowError($"備份失敗！請確認 SQL Server 對該資料夾是否有寫入權限。\n錯誤訊息：{ex.Message}");
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }

        //還原資料庫
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!UIMessageBox.ShowAsk("警告：還原資料庫將會覆蓋目前系統中所有的商品與訂單資料！\n\n您確定要繼續嗎？"))
            {
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SQL Server 備份檔 (*.bak)|*.bak";
                ofd.Title = "選擇要還原的備份檔案";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        string backupPath = ofd.FileName;
                        string dbName = "";
                        string masterConnectionString = "";

                        //取得連線字串並修改為連線至master資料庫
                        using (var db = new POSContext())
                        {
                            dbName = db.Database.Connection.Database;
                            string originalConnectionString = db.Database.Connection.ConnectionString;

                            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(originalConnectionString);
                            builder.InitialCatalog = "master";//切換到 master
                            masterConnectionString = builder.ConnectionString;
                        }

                        //執行還原
                        using (SqlConnection con = new SqlConnection(masterConnectionString))
                        {
                            con.Open();

                            //將資料庫設為單人模式，並踢掉所有現有連線
                            string sqlSingleUser = $"ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                            using (SqlCommand cmd = new SqlCommand(sqlSingleUser, con))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            //執行還原
                            string sqlRestore = $"RESTORE DATABASE [{dbName}] FROM DISK = '{backupPath}' WITH REPLACE";
                            using (SqlCommand cmd = new SqlCommand(sqlRestore, con))
                            {
                                //還原可能會花一點時間，所以...把Timeout調長到120~
                                cmd.CommandTimeout = 120;
                                cmd.ExecuteNonQuery();
                            }

                            //將資料庫設回多人模式
                            string sqlMultiUser = $"ALTER DATABASE [{dbName}] SET MULTI_USER";
                            using (SqlCommand cmd = new SqlCommand(sqlMultiUser, con))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            con.Close();
                        }

                        //還原重啟系統
                        UIMessageBox.ShowSuccess("資料庫還原成功！\n系統即將重新啟動以套用最新資料。");
                        Application.Restart();
                    }
                    catch (Exception ex)
                    {
                        UIMessageBox.ShowError($"還原失敗！\n錯誤訊息：{ex.Message}");
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }
    }
}