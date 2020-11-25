namespace EduBase1020
{
    partial class frm_StudentInfo
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
            this.txb_No = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Gender = new System.Windows.Forms.TextBox();
            this.txb_BirthDate = new System.Windows.Forms.TextBox();
            this.txb_Major = new System.Windows.Forms.TextBox();
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.lbl_Major = new System.Windows.Forms.Label();
            this.btn_Homepage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_No
            // 
            this.txb_No.Location = new System.Drawing.Point(123, 28);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(100, 21);
            this.txb_No.TabIndex = 0;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(123, 98);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 21);
            this.txb_Name.TabIndex = 1;
            // 
            // txb_Gender
            // 
            this.txb_Gender.Location = new System.Drawing.Point(123, 163);
            this.txb_Gender.Name = "txb_Gender";
            this.txb_Gender.Size = new System.Drawing.Size(100, 21);
            this.txb_Gender.TabIndex = 2;
            // 
            // txb_BirthDate
            // 
            this.txb_BirthDate.Location = new System.Drawing.Point(409, 28);
            this.txb_BirthDate.Name = "txb_BirthDate";
            this.txb_BirthDate.Size = new System.Drawing.Size(100, 21);
            this.txb_BirthDate.TabIndex = 3;
            // 
            // txb_Major
            // 
            this.txb_Major.Location = new System.Drawing.Point(409, 98);
            this.txb_Major.Name = "txb_Major";
            this.txb_Major.Size = new System.Drawing.Size(100, 21);
            this.txb_Major.TabIndex = 4;
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Location = new System.Drawing.Point(41, 31);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(41, 12);
            this.lbl_No.TabIndex = 5;
            this.lbl_No.Text = "学号：";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(41, 101);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 12);
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "姓名：";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(41, 166);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(41, 12);
            this.lbl_Gender.TabIndex = 7;
            this.lbl_Gender.Text = "性别：";
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Location = new System.Drawing.Point(344, 31);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(65, 12);
            this.lbl_BirthDate.TabIndex = 8;
            this.lbl_BirthDate.Text = "出生日期：";
            // 
            // lbl_Major
            // 
            this.lbl_Major.AutoSize = true;
            this.lbl_Major.Location = new System.Drawing.Point(344, 98);
            this.lbl_Major.Name = "lbl_Major";
            this.lbl_Major.Size = new System.Drawing.Size(41, 12);
            this.lbl_Major.TabIndex = 9;
            this.lbl_Major.Text = "专业：";
            // 
            // btn_Homepage
            // 
            this.btn_Homepage.Location = new System.Drawing.Point(303, 257);
            this.btn_Homepage.Name = "btn_Homepage";
            this.btn_Homepage.Size = new System.Drawing.Size(75, 23);
            this.btn_Homepage.TabIndex = 10;
            this.btn_Homepage.Text = "主页";
            this.btn_Homepage.UseVisualStyleBackColor = true;
            this.btn_Homepage.Click += new System.EventHandler(this.btn_Homepage_Click);
            // 
            // frm_StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 381);
            this.Controls.Add(this.btn_Homepage);
            this.Controls.Add(this.lbl_Major);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.txb_Major);
            this.Controls.Add(this.txb_BirthDate);
            this.Controls.Add(this.txb_Gender);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.txb_No);
            this.Name = "frm_StudentInfo";
            this.Text = "学生信息";
            this.Load += new System.EventHandler(this.frm_StudentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Gender;
        private System.Windows.Forms.TextBox txb_BirthDate;
        private System.Windows.Forms.TextBox txb_Major;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_BirthDate;
        private System.Windows.Forms.Label lbl_Major;
        private System.Windows.Forms.Button btn_Homepage;
    }
}