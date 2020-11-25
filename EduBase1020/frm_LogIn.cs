using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace EduBase1020
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT 1
                    FROM tb_Student AS S
                    WHERE S.No = '{this.txb_StuNo.Text}' 
                    AND S.Password = '{this.txb_Password.Text}';";
            SqlHelper sqlHelper = new SqlHelper();
            int result= sqlHelper.QuickReturn<int>(commandText);
            if (result == 1)
            {
                MessageBox.Show("登录成功。");
                frm_PersonalHomepage frm_PersonalHomepage = new frm_PersonalHomepage();
                frm_PersonalHomepage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }
    }
}
