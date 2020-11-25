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
    public partial class frm_Notice : Form
    {
        public frm_Notice()
        {
            InitializeComponent();
        }

        private void gv_Notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Notice_Load(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT * FROM tb_Notice";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                int index = this.gv_Notice.Rows.Add();
                this.gv_Notice.Rows[index].Cells[0].Value = sqlHelper["No"];
                this.gv_Notice.Rows[index].Cells[1].Value = sqlHelper["Title"];
                this.gv_Notice.Rows[index].Cells[2].Value = sqlHelper["Category"];
                this.gv_Notice.Rows[index].Cells[3].Value = sqlHelper["Sender"];
                this.gv_Notice.Rows[index].Cells[4].Value = sqlHelper["SendingTime"];
                this.gv_Notice.Rows[index].Cells[5].Value = sqlHelper["Operation"];
            }
        }
    }
}
