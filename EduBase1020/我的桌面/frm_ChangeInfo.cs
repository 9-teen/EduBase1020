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
    public partial class frm_ChangeInfo : Form
    {
        private string _StudentNo;
        public frm_ChangeInfo()
        {
            InitializeComponent();
            this.FormClosed += Frm_StudentInfo_FormClosed;
        }
        public frm_ChangeInfo(string StudentNo) : this()
        {
            this._StudentNo = StudentNo;
        }
        private void Frm_StudentInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void frm_ChangeInfo_Load(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT * FROM tb_ChangeInfo";
            SqlHelper sqlHelper = new SqlHelper();
            int result= sqlHelper.QuickReturn<int>(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txb_No.Text = sqlHelper["No"].ToString();
                this.txb_Name.Text = sqlHelper["Name"].ToString();
                this.txb_Question1.Text = sqlHelper["Question1"].ToString();
                this.txb_Answer1.Text = sqlHelper["Answer1"].ToString();
                this.txb_Question2.Text = sqlHelper["Question2"].ToString();
                this.txb_Answer2.Text = sqlHelper["Answer2"].ToString();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"UPDATE tb_ChangeInfo
                SET No = '{this.txb_No.Text}',Name = '{this.txb_Name.Text}',Question1 = '{this.txb_Question1.Text}'
                ,Answer1 = '{this.txb_Answer1.Text}',Question2 = '{this.txb_Question2.Text}',Answer2 = '{this.txb_Answer2.Text}'
                WHERE No='{_StudentNo}';";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper.QuickSubmit(commandText);
            if (rowAffected == 1)
            {
                MessageBox.Show("修改个人信息成功。");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
