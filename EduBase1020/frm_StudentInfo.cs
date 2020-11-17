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
    public partial class frm_StudentInfo : Form
    {
        private string _StudentNo;
        public frm_StudentInfo()
        {
            InitializeComponent();
            this.FormClosed += Frm_StudentInfo_FormClosed;
        }
        public frm_StudentInfo(string StudentNo) : this()
        {
            this._StudentNo = StudentNo;
        }
        private void Frm_StudentInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void frm_StudentInfo_Load(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT * 
                FROM tb_Student AS S 
                WHERE S.No = '{this._StudentNo}'";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if(sqlHelper.HasRecord)
            {
                this.txb_No.Text = sqlHelper["No"].ToString();
                this.txb_Name.Text = sqlHelper["Name"].ToString();
                this.txb_Major.Text = sqlHelper["Major"].ToString();
                this.txb_Gender.Text = sqlHelper["Gender"].ToString();
                this.txb_BirthDate.Text = ((DateTime)sqlHelper["BirthDate"]).ToShortDateString();
            }
        }
    }
}
