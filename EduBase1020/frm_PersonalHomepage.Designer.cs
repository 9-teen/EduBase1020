namespace EduBase1020
{
    partial class frm_PersonalHomepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PersonalHomepage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.llb_ModifyPassword = new System.Windows.Forms.LinkLabel();
            this.llb_ModifyInformation = new System.Windows.Forms.LinkLabel();
            this.lbl_personalInformation = new System.Windows.Forms.Label();
            this.llb_Message = new System.Windows.Forms.LinkLabel();
            this.llb_Notice = new System.Windows.Forms.LinkLabel();
            this.lbl_AnnouncementMessage = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "*";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_Desktop);
            this.tabPage2.Controls.Add(this.llb_ModifyPassword);
            this.tabPage2.Controls.Add(this.llb_ModifyInformation);
            this.tabPage2.Controls.Add(this.lbl_personalInformation);
            this.tabPage2.Controls.Add(this.llb_Message);
            this.tabPage2.Controls.Add(this.llb_Notice);
            this.tabPage2.Controls.Add(this.lbl_AnnouncementMessage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.Location = new System.Drawing.Point(117, 6);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(657, 379);
            this.panel_Desktop.TabIndex = 6;
            // 
            // llb_ModifyPassword
            // 
            this.llb_ModifyPassword.AutoSize = true;
            this.llb_ModifyPassword.Location = new System.Drawing.Point(18, 204);
            this.llb_ModifyPassword.Name = "llb_ModifyPassword";
            this.llb_ModifyPassword.Size = new System.Drawing.Size(53, 12);
            this.llb_ModifyPassword.TabIndex = 5;
            this.llb_ModifyPassword.TabStop = true;
            this.llb_ModifyPassword.Text = "修改密码";
            // 
            // llb_ModifyInformation
            // 
            this.llb_ModifyInformation.AutoSize = true;
            this.llb_ModifyInformation.Location = new System.Drawing.Point(18, 170);
            this.llb_ModifyInformation.Name = "llb_ModifyInformation";
            this.llb_ModifyInformation.Size = new System.Drawing.Size(77, 12);
            this.llb_ModifyInformation.TabIndex = 4;
            this.llb_ModifyInformation.TabStop = true;
            this.llb_ModifyInformation.Text = "修改个人信息";
            // 
            // lbl_personalInformation
            // 
            this.lbl_personalInformation.AutoSize = true;
            this.lbl_personalInformation.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_personalInformation.Location = new System.Drawing.Point(17, 143);
            this.lbl_personalInformation.Name = "lbl_personalInformation";
            this.lbl_personalInformation.Size = new System.Drawing.Size(63, 14);
            this.lbl_personalInformation.TabIndex = 3;
            this.lbl_personalInformation.Text = "个人信息";
            // 
            // llb_Message
            // 
            this.llb_Message.AutoSize = true;
            this.llb_Message.Location = new System.Drawing.Point(18, 105);
            this.llb_Message.Name = "llb_Message";
            this.llb_Message.Size = new System.Drawing.Size(53, 12);
            this.llb_Message.TabIndex = 2;
            this.llb_Message.TabStop = true;
            this.llb_Message.Text = "已收留言";
            this.llb_Message.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Message_LinkClicked);
            // 
            // llb_Notice
            // 
            this.llb_Notice.AutoSize = true;
            this.llb_Notice.Location = new System.Drawing.Point(18, 70);
            this.llb_Notice.Name = "llb_Notice";
            this.llb_Notice.Size = new System.Drawing.Size(53, 12);
            this.llb_Notice.TabIndex = 1;
            this.llb_Notice.TabStop = true;
            this.llb_Notice.Text = "已收公告";
            this.llb_Notice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Notice_LinkClicked);
            // 
            // lbl_AnnouncementMessage
            // 
            this.lbl_AnnouncementMessage.AutoSize = true;
            this.lbl_AnnouncementMessage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_AnnouncementMessage.Location = new System.Drawing.Point(17, 27);
            this.lbl_AnnouncementMessage.Name = "lbl_AnnouncementMessage";
            this.lbl_AnnouncementMessage.Size = new System.Drawing.Size(63, 14);
            this.lbl_AnnouncementMessage.TabIndex = 0;
            this.lbl_AnnouncementMessage.Text = "公告留言";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(780, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 388);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(780, 388);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(780, 388);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(780, 388);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // frm_PersonalHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_PersonalHomepage";
            this.Text = "个人主页";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel llb_ModifyPassword;
        private System.Windows.Forms.LinkLabel llb_ModifyInformation;
        private System.Windows.Forms.Label lbl_personalInformation;
        private System.Windows.Forms.LinkLabel llb_Message;
        private System.Windows.Forms.LinkLabel llb_Notice;
        private System.Windows.Forms.Label lbl_AnnouncementMessage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel_Desktop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}