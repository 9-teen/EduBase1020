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
        private string _StudentNo;
        public frm_PersonalHomepage()
        {
            InitializeComponent();
            this.FormClosed += Frm_PersonalHomepage_FormClosed;
        }

        private void Frm_PersonalHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count==0)
            {
                Application.Exit();
            }
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
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void lkl_StudentStatusInformationManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_StudentStatus.Controls.Clear();
            frm_StudentStatusInformationManagement frm_StudentStatusInformationManagement = new frm_StudentStatusInformationManagement();
            frm_StudentStatusInformationManagement.TopLevel = false;
            this.panel_StudentStatus.Controls.Add(frm_StudentStatusInformationManagement);
            frm_StudentStatusInformationManagement.Show();
        }

        private void lkl_StudentStatusWarningQuery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_StudentStatus.Controls.Clear();
            frm_StudentStatusWarningQuery frm_StudentStatusWarningQuery = new frm_StudentStatusWarningQuery();
            frm_StudentStatusWarningQuery.TopLevel = false;
            this.panel_StudentStatus.Controls.Add(frm_StudentStatusWarningQuery);
            frm_StudentStatusWarningQuery.Show();
        }

        private void lkl_StudentStatusChangeInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_StudentStatus.Controls.Clear();
            frm_StudentStatusChangeInformation frm_StudentStatusChangeInformation = new frm_StudentStatusChangeInformation();
            frm_StudentStatusChangeInformation.TopLevel = false;
            this.panel_StudentStatus.Controls.Add(frm_StudentStatusChangeInformation);
            frm_StudentStatusChangeInformation.Show();
        }

        private void lkl_CourseScorQuery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_StudentStatus.Controls.Clear();
            frm_CourseScoreQuery frm_CourseScoreQuery = new frm_CourseScoreQuery();
            frm_CourseScoreQuery.TopLevel = false;
            frm_CourseScoreQuery.Controls.Add(frm_CourseScoreQuery);
            frm_CourseScoreQuery.Show();
        }

        private void lkl_ApplyForExchangeStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_StudentStatus.Controls.Clear();
            frm_Applyforexchangestudent frm_Applyforexchangestudent = new frm_Applyforexchangestudent();
            frm_Applyforexchangestudent.TopLevel = false;
            frm_Applyforexchangestudent.Controls.Add(frm_Applyforexchangestudent);
            frm_Applyforexchangestudent.Show();
        }

        private void lkl_ResultsOfExchangeStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_StudentStatus.Controls.Clear();
            frm_Resultsofexchangestudents frm_Resultsofexchangestudents = new frm_Resultsofexchangestudents();
            frm_Resultsofexchangestudents.TopLevel = false;
            frm_Resultsofexchangestudents.Controls.Add(frm_Resultsofexchangestudents);
            frm_Resultsofexchangestudents.Show();
        }

        private void lkl_CourseSelectionForExchangeStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_StudentStatus.Controls.Clear();
            frm_Courseselectionforexchangestudents frm_Courseselectionforexchangestudents = new frm_Courseselectionforexchangestudents();
            frm_Courseselectionforexchangestudents.TopLevel = false;
            frm_Courseselectionforexchangestudents.Controls.Add(frm_Courseselectionforexchangestudents);
            frm_Courseselectionforexchangestudents.Show();
        }

        private void lkl_AchievementRecognition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_StudentStatus.Controls.Clear();
            frm_Achievementrecognition frm_Achievementrecognition = new frm_Achievementrecognition();
            frm_Achievementrecognition.TopLevel = false;
            frm_Achievementrecognition.Controls.Add(frm_Achievementrecognition);
            frm_Achievementrecognition.Show();
        }

        private void lkl_OSCEscore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel_StudentStatus.Controls.Clear();
            frm_OSCEscore frm_OSCEscore = new frm_OSCEscore();
            frm_OSCEscore.TopLevel = false;
            frm_OSCEscore.Controls.Add(frm_OSCEscore);
            frm_OSCEscore.Show();
        }
    }
}
