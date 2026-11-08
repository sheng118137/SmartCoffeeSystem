using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCoffeeSystem
{
    public partial class FrmLogin : Form
    {
        internal static class Program
        {
            /// <summary>
            /// 應用程式的主要進入點。
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //因為SUNNYUI是簡體字看了很難受，返祖義後發現可以override~
                UIStyles.CurrentResources.OK = "確定";
                UIStyles.CurrentResources.Cancel = "取消";
                UIStyles.CurrentResources.Yes = "是";
                UIStyles.CurrentResources.No = "否";               
                UIStyles.CurrentResources.InfoTitle = "提示視窗";
                UIStyles.CurrentResources.SuccessTitle = "成功視窗";
                UIStyles.CurrentResources.WarningTitle = "警告視窗";
                UIStyles.CurrentResources.ErrorTitle = "錯誤視窗";
                UIStyles.CurrentResources.AskTitle = "確認視窗";                
                UIStyles.CurrentResources.GridNoData = "[ 目前沒有資料 ]";
                UIStyles.CurrentResources.GridDataLoading = "資料載入中，請稍候...";
                UIStyles.CurrentResources.SystemProcessing = "系統處理中，請稍候...";
                UIStyles.CurrentResources.Search = "搜尋";
                UIStyles.CurrentResources.Clear = "清除";
                UIStyles.CurrentResources.Save = "儲存";
                UIStyles.CurrentResources.All = "全部";
                UIStyles.GlobalFontName = "微软雅黑";
                Application.Run(new FrmLogin());
            }
        }
    }
}
