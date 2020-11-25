namespace EduBase1020
{
    partial class frm_Achievementrecognition
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
            this.Semesterafterchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Changeresult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Applicationdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coursestaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Replacecourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semesterafterchange,
            this.StudentName,
            this.Changeresult,
            this.Applicationdate,
            this.Coursestaken,
            this.Replacecourse,
            this.Auditstatus,
            this.Operation});
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(739, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Semesterafterchange
            // 
            this.Semesterafterchange.HeaderText = "异动后学期";
            this.Semesterafterchange.Name = "Semesterafterchange";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            // 
            // Changeresult
            // 
            this.Changeresult.HeaderText = "异动结果";
            this.Changeresult.Name = "Changeresult";
            // 
            // Applicationdate
            // 
            this.Applicationdate.HeaderText = "申请日期";
            this.Applicationdate.Name = "Applicationdate";
            // 
            // Coursestaken
            // 
            this.Coursestaken.HeaderText = "已修课程";
            this.Coursestaken.Name = "Coursestaken";
            // 
            // Replacecourse
            // 
            this.Replacecourse.HeaderText = "替换课程";
            this.Replacecourse.Name = "Replacecourse";
            // 
            // Auditstatus
            // 
            this.Auditstatus.HeaderText = "审核状态";
            this.Auditstatus.Name = "Auditstatus";
            // 
            // Operation
            // 
            this.Operation.HeaderText = "操作";
            this.Operation.Name = "Operation";
            // 
            // frm_Achievementrecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Achievementrecognition";
            this.Text = "frm_Achievementrecognition";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semesterafterchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Changeresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Applicationdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coursestaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Replacecourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    }
}