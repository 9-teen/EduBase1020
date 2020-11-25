namespace EduBase1020
{
    partial class frm_OSCEscore
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
            this.lbl_Examinationtime = new System.Windows.Forms.Label();
            this.cmb_Examinationtime = new System.Windows.Forms.ComboBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Examinationtime
            // 
            this.lbl_Examinationtime.AutoSize = true;
            this.lbl_Examinationtime.Location = new System.Drawing.Point(201, 118);
            this.lbl_Examinationtime.Name = "lbl_Examinationtime";
            this.lbl_Examinationtime.Size = new System.Drawing.Size(65, 12);
            this.lbl_Examinationtime.TabIndex = 0;
            this.lbl_Examinationtime.Text = "考试时间：";
            // 
            // cmb_Examinationtime
            // 
            this.cmb_Examinationtime.FormattingEnabled = true;
            this.cmb_Examinationtime.Location = new System.Drawing.Point(268, 115);
            this.cmb_Examinationtime.Name = "cmb_Examinationtime";
            this.cmb_Examinationtime.Size = new System.Drawing.Size(121, 20);
            this.cmb_Examinationtime.TabIndex = 1;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(294, 196);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            // 
            // frm_OSCEscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.cmb_Examinationtime);
            this.Controls.Add(this.lbl_Examinationtime);
            this.Name = "frm_OSCEscore";
            this.Text = "OSCE成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Examinationtime;
        private System.Windows.Forms.ComboBox cmb_Examinationtime;
        private System.Windows.Forms.Button btn_Query;
    }
}