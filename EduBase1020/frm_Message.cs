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
    public partial class frm_Message : Form
    {
        public frm_Message()
        {
            InitializeComponent();
        }

        private void gv_Message_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string CommandText = $@"Select * From tb_Message;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(CommandText);
            if (sqlHelper.HasRecord)
            {
                int index = this.gv_Message.Rows.Add();
                this.gv_Message.Rows[index].Cells[0].Value = sqlHelper["No"].ToString();
                this.gv_Message.Rows[index].Cells[1].Value = sqlHelper["Title"].ToString();
                this.gv_Message.Rows[index].Cells[2].Value = sqlHelper["Category"].ToString();
                this.gv_Message.Rows[index].Cells[3].Value = sqlHelper["Sender"].ToString();
                this.gv_Message.Rows[index].Cells[4].Value = sqlHelper["SendingTime"].ToString();
                this.gv_Message.Rows[index].Cells[5].Value = sqlHelper["Operation"].ToString();
            }

        }
    }
}
