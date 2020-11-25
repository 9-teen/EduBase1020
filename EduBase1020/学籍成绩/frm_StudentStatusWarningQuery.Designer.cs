namespace EduBase1020
{
    partial class frm_StudentStatusWarningQuery
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
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarlyWarningSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessingResults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.EarlyWarningSemester,
            this.ProcessingResults,
            this.Tips});
            this.dataGridView1.Location = new System.Drawing.Point(152, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(441, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "序号";
            this.Number.Name = "Number";
            // 
            // EarlyWarningSemester
            // 
            this.EarlyWarningSemester.HeaderText = "预警学期";
            this.EarlyWarningSemester.Name = "EarlyWarningSemester";
            // 
            // ProcessingResults
            // 
            this.ProcessingResults.HeaderText = "处理结果";
            this.ProcessingResults.Name = "ProcessingResults";
            // 
            // Tips
            // 
            this.Tips.HeaderText = "提示信息";
            this.Tips.Name = "Tips";
            // 
            // frm_StudentStatusWarningQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_StudentStatusWarningQuery";
            this.Text = "学籍预警查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn EarlyWarningSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessingResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tips;
    }
}