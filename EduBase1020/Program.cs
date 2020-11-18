using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduBase1020
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frm_SignUp frm_SignUp = new frm_SignUp();
            //frm_SignUp.Show();
            //frm_LogIn frm_LogIn = new frm_LogIn();
            //frm_LogIn.Show();
            frm_PersonalHomepage frm_PersonalHomepage = new frm_PersonalHomepage();
            frm_PersonalHomepage.Show();
            Application.Run();
        }
    }
}
