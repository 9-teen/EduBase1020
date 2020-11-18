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
    public partial class frm_PersonalHomepage : Form
    {
        public frm_PersonalHomepage()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void llb_Notice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_Desktop.Controls.Clear();
            frm_Notice frm_Notice = new frm_Notice();
            frm_Notice.TopLevel = false;
            this.panel_Desktop.Controls.Add(frm_Notice);
            frm_Notice.Show();
        }

        private void llb_Message_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_Desktop.Controls.Clear();
            frm_Message frm_Message = new frm_Message();
            frm_Message.TopLevel = false;
            this.panel_Desktop.Controls.Add(frm_Message);
            frm_Message.Show();
        }
    }
}
