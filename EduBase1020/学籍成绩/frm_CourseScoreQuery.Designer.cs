namespace EduBase1020
{
    partial class frm_CourseScoreQuery
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
            this.lbl_Openingtime = new System.Windows.Forms.Label();
            this.lbl_Coursenature = new System.Windows.Forms.Label();
            this.lbl_Coursename = new System.Windows.Forms.Label();
            this.lbl_Displaymode = new System.Windows.Forms.Label();
            this.cmb_Openingtime = new System.Windows.Forms.ComboBox();
            this.cmb_Coursenature = new System.Windows.Forms.ComboBox();
            this.cmb_Coursename = new System.Windows.Forms.ComboBox();
            this.cmb_Displaymode = new System.Windows.Forms.ComboBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Openingtime
            // 
            this.lbl_Openingtime.AutoSize = true;
            this.lbl_Openingtime.Location = new System.Drawing.Point(199, 88);
            this.lbl_Openingtime.Name = "lbl_Openingtime";
            this.lbl_Openingtime.Size = new System.Drawing.Size(65, 12);
            this.lbl_Openingtime.TabIndex = 0;
            this.lbl_Openingtime.Text = "开课时间：";
            // 
            // lbl_Coursenature
            // 
            this.lbl_Coursenature.AutoSize = true;
            this.lbl_Coursenature.Location = new System.Drawing.Point(199, 131);
            this.lbl_Coursenature.Name = "lbl_Coursenature";
            this.lbl_Coursenature.Size = new System.Drawing.Size(65, 12);
            this.lbl_Coursenature.TabIndex = 1;
            this.lbl_Coursenature.Text = "课程性质：";
            // 
            // lbl_Coursename
            // 
            this.lbl_Coursename.AutoSize = true;
            this.lbl_Coursename.Location = new System.Drawing.Point(199, 176);
            this.lbl_Coursename.Name = "lbl_Coursename";
            this.lbl_Coursename.Size = new System.Drawing.Size(65, 12);
            this.lbl_Coursename.TabIndex = 2;
            this.lbl_Coursename.Text = "课程名称：";
            // 
            // lbl_Displaymode
            // 
            this.lbl_Displaymode.AutoSize = true;
            this.lbl_Displaymode.Location = new System.Drawing.Point(199, 222);
            this.lbl_Displaymode.Name = "lbl_Displaymode";
            this.lbl_Displaymode.Size = new System.Drawing.Size(65, 12);
            this.lbl_Displaymode.TabIndex = 3;
            this.lbl_Displaymode.Text = "显示方式：";
            // 
            // cmb_Openingtime
            // 
            this.cmb_Openingtime.FormattingEnabled = true;
            this.cmb_Openingtime.Location = new System.Drawing.Point(286, 85);
            this.cmb_Openingtime.Name = "cmb_Openingtime";
            this.cmb_Openingtime.Size = new System.Drawing.Size(143, 20);
            this.cmb_Openingtime.TabIndex = 4;
            // 
            // cmb_Coursenature
            // 
            this.cmb_Coursenature.FormattingEnabled = true;
            this.cmb_Coursenature.Location = new System.Drawing.Point(286, 128);
            this.cmb_Coursenature.Name = "cmb_Coursenature";
            this.cmb_Coursenature.Size = new System.Drawing.Size(143, 20);
            this.cmb_Coursenature.TabIndex = 5;
            // 
            // cmb_Coursename
            // 
            this.cmb_Coursename.FormattingEnabled = true;
            this.cmb_Coursename.Location = new System.Drawing.Point(286, 173);
            this.cmb_Coursename.Name = "cmb_Coursename";
            this.cmb_Coursename.Size = new System.Drawing.Size(143, 20);
            this.cmb_Coursename.TabIndex = 6;
            // 
            // cmb_Displaymode
            // 
            this.cmb_Displaymode.FormattingEnabled = true;
            this.cmb_Displaymode.Location = new System.Drawing.Point(286, 219);
            this.cmb_Displaymode.Name = "cmb_Displaymode";
            this.cmb_Displaymode.Size = new System.Drawing.Size(143, 20);
            this.cmb_Displaymode.TabIndex = 7;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(316, 283);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(63, 23);
            this.btn_Query.TabIndex = 8;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            // 
            // frm_CourseScoreQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.cmb_Displaymode);
            this.Controls.Add(this.cmb_Coursename);
            this.Controls.Add(this.cmb_Coursenature);
            this.Controls.Add(this.cmb_Openingtime);
            this.Controls.Add(this.lbl_Displaymode);
            this.Controls.Add(this.lbl_Coursename);
            this.Controls.Add(this.lbl_Coursenature);
            this.Controls.Add(this.lbl_Openingtime);
            this.Name = "frm_CourseScoreQuery";
            this.Text = "课程成绩查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Openingtime;
        private System.Windows.Forms.Label lbl_Coursenature;
        private System.Windows.Forms.Label lbl_Coursename;
        private System.Windows.Forms.Label lbl_Displaymode;
        private System.Windows.Forms.ComboBox cmb_Openingtime;
        private System.Windows.Forms.ComboBox cmb_Coursenature;
        private System.Windows.Forms.ComboBox cmb_Coursename;
        private System.Windows.Forms.ComboBox cmb_Displaymode;
        private System.Windows.Forms.Button btn_Query;
    }
}