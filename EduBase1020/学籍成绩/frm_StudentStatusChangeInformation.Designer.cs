namespace EduBase1020
{
    partial class frm_StudentStatusChangeInformation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OriginalClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalStudentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewCollege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewStudentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalClass,
            this.OriginalStudentStatus,
            this.NewCollege,
            this.NewMajor,
            this.NewClass,
            this.NewStudentStatus,
            this.NewStatus,
            this.ChangeCategory,
            this.FinalStatus});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(905, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // OriginalClass
            // 
            this.OriginalClass.HeaderText = "原班级";
            this.OriginalClass.Name = "OriginalClass";
            // 
            // OriginalStudentStatus
            // 
            this.OriginalStudentStatus.HeaderText = "原学籍";
            this.OriginalStudentStatus.Name = "OriginalStudentStatus";
            // 
            // NewCollege
            // 
            this.NewCollege.HeaderText = "新学院";
            this.NewCollege.Name = "NewCollege";
            // 
            // NewMajor
            // 
            this.NewMajor.HeaderText = "新专业";
            this.NewMajor.Name = "NewMajor";
            // 
            // NewClass
            // 
            this.NewClass.HeaderText = "新班级";
            this.NewClass.Name = "NewClass";
            // 
            // NewStudentStatus
            // 
            this.NewStudentStatus.HeaderText = "新学籍";
            this.NewStudentStatus.Name = "NewStudentStatus";
            // 
            // NewStatus
            // 
            this.NewStatus.HeaderText = "新状态";
            this.NewStatus.Name = "NewStatus";
            // 
            // ChangeCategory
            // 
            this.ChangeCategory.HeaderText = "异动类别";
            this.ChangeCategory.Name = "ChangeCategory";
            // 
            // FinalStatus
            // 
            this.FinalStatus.HeaderText = "终审状态";
            this.FinalStatus.Name = "FinalStatus";
            // 
            // frm_StudentStatusChangeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_StudentStatusChangeInformation";
            this.Text = "修改个人信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalStudentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewStudentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalStatus;
    }
}