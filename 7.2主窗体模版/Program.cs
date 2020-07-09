using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2主窗体模版
{
   
    static class Program
    {
        public static string loginadmin;
        public static string logincontrol;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _7._2主窗体模版.UI frm1 = new _7._2主窗体模版.UI();
            if (frm1.ShowDialog() == DialogResult.OK)
            {
                //Application.Run(new Form3());
                _7._2主窗体模版.Login login = new _7._2主窗体模版.Login();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new _7._2主窗体模版.Form1(loginadmin,logincontrol));
                }
               
            }
            //Application.Run(new Form1());
        }
    }
}
