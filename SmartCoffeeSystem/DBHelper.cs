using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace SmartCoffeeSystem
{
    public static class DBHelper
    {
        public static (bool success, string message) TestSqlConnection()
        {
            try
            {
                var cs = ConfigurationManager.ConnectionStrings["POS_Sql"]?.ConnectionString;
                if (string.IsNullOrWhiteSpace(cs))
                {
                    return (false, "找不到名為 'POS_Sql' 的連線字串於 App.config。");
                }

                using (var cn = new SqlConnection(cs))
                {
                    cn.Open();
                    // 讀一些簡單資訊
                    using (var cmd = new SqlCommand("SELECT DB_NAME() AS DbName, SERVERPROPERTY('MachineName') AS ServerName", cn))
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            var db = rdr["DbName"]?.ToString();
                            var server = rdr["ServerName"]?.ToString();
                            return (true, $"連線成功：伺服器={server}，資料庫={db}");
                        }
                    }
                    return (true, "連線成功 (但取得資訊失敗)");
                }
            }
            catch (Exception ex)
            {
                var sb = new StringBuilder();
                sb.AppendLine("連線測試失敗：");
                sb.AppendLine(ex.Message);
                if (ex.InnerException != null) sb.AppendLine(ex.InnerException.Message);
                return (false, sb.ToString());
            }
        }
    }
}
