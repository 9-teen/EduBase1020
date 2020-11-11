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
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"INSERT tb_Student(No, Password)
                   VALUES
                   ('{this.txb_StuNo.Text}', '{this.txb_Password.Text}'); ";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper.QuickSubmit(commandText);
            if (rowAffected == 1)
            {
                MessageBox.Show("注册成功。");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            frm_LogIn frm_LogIn = new frm_LogIn();
            frm_LogIn.Show();
            this.Close();
            
        }
        
    }
}
