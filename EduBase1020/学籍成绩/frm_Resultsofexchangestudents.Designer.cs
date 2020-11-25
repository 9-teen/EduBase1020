namespace EduBase1020
{
    partial class frm_Resultsofexchangestudents
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
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Academicyearandsemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalclasshours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Academicyearandsemester,
            this.CourseNo,
            this.CourseName,
            this.Totalscore,
            this.Totalclasshours,
            this.Credit,
            this.FinalStatus,
            this.Operation});
            this.dataGridView1.Location = new System.Drawing.Point(1, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(937, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Student
            // 
            this.Student.HeaderText = "学生";
            this.Student.Name = "Student";
            // 
            // Academicyearandsemester
            // 
            this.Academicyearandsemester.HeaderText = "学年学期";
            this.Academicyearandsemester.Name = "Academicyearandsemester";
            // 
            // CourseNo
            // 
            this.CourseNo.HeaderText = "课程号";
            this.CourseNo.Name = "CourseNo";
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            // 
            // Totalscore
            // 
            this.Totalscore.HeaderText = "总成绩";
            this.Totalscore.Name = "Totalscore";
            // 
            // Totalclasshours
            // 
            this.Totalclasshours.HeaderText = "总学时";
            this.Totalclasshours.Name = "Totalclasshours";
            // 
            // Credit
            // 
            this.Credit.HeaderText = "学分";
            this.Credit.Name = "Credit";
            // 
            // FinalStatus
            // 
            this.FinalStatus.HeaderText = "终审状态";
            this.FinalStatus.Name = "FinalStatus";
            // 
            // Operation
            // 
            this.Operation.HeaderText = "操作";
            this.Operation.Name = "Operation";
            // 
            // frm_Resultsofexchangestudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Resultsofexchangestudents";
            this.Text = "交换生成绩";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Academicyearandsemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalclasshours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    }
}