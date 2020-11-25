namespace EduBase1020
{
    partial class frm_Applyforexchangestudent
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
            this.Exchangesemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.School = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allowdeployment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statusofstudentstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currentstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Exchangesemester,
            this.School,
            this.Major,
            this.Allowdeployment,
            this.Statusofstudentstatus,
            this.Currentstate,
            this.Finalstatus,
            this.Operation});
            this.dataGridView1.Location = new System.Drawing.Point(13, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(845, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Student
            // 
            this.Student.HeaderText = "学生";
            this.Student.Name = "Student";
            // 
            // Exchangesemester
            // 
            this.Exchangesemester.HeaderText = "交换学期";
            this.Exchangesemester.Name = "Exchangesemester";
            // 
            // School
            // 
            this.School.HeaderText = "学校";
            this.School.Name = "School";
            // 
            // Major
            // 
            this.Major.HeaderText = "专业";
            this.Major.Name = "Major";
            // 
            // Allowdeployment
            // 
            this.Allowdeployment.HeaderText = "允许调配";
            this.Allowdeployment.Name = "Allowdeployment";
            // 
            // Statusofstudentstatus
            // 
            this.Statusofstudentstatus.HeaderText = "学籍状态";
            this.Statusofstudentstatus.Name = "Statusofstudentstatus";
            // 
            // Currentstate
            // 
            this.Currentstate.HeaderText = "当前状态";
            this.Currentstate.Name = "Currentstate";
            // 
            // Finalstatus
            // 
            this.Finalstatus.HeaderText = "终审状态";
            this.Finalstatus.Name = "Finalstatus";
            // 
            // Operation
            // 
            this.Operation.HeaderText = "操作";
            this.Operation.Name = "Operation";
            // 
            // frm_Applyforexchangestudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Applyforexchangestudent";
            this.Text = "申请交换生";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exchangesemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn School;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allowdeployment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statusofstudentstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currentstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finalstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    }
}