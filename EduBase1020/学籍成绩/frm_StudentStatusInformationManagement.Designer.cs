namespace EduBase1020
{
    partial class frm_StudentStatusInformationManagement
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
            this.gv_StudentStatusInformationManagement = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModificationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_StudentStatusInformationManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_StudentStatusInformationManagement
            // 
            this.gv_StudentStatusInformationManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_StudentStatusInformationManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.No,
            this.StuName,
            this.ModifyField,
            this.ModifyInformation,
            this.AuditStatus,
            this.ModificationTime,
            this.Operation});
            this.gv_StudentStatusInformationManagement.Location = new System.Drawing.Point(12, 35);
            this.gv_StudentStatusInformationManagement.Name = "gv_StudentStatusInformationManagement";
            this.gv_StudentStatusInformationManagement.RowTemplate.Height = 23;
            this.gv_StudentStatusInformationManagement.Size = new System.Drawing.Size(786, 150);
            this.gv_StudentStatusInformationManagement.TabIndex = 0;
            this.gv_StudentStatusInformationManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_StudentStatusInformationManagement_CellContentClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "序号";
            this.Number.Name = "Number";
            // 
            // No
            // 
            this.No.HeaderText = "学号";
            this.No.Name = "No";
            // 
            // StuName
            // 
            this.StuName.HeaderText = "姓名";
            this.StuName.Name = "StuName";
            // 
            // ModifyField
            // 
            this.ModifyField.HeaderText = "修改字段";
            this.ModifyField.Name = "ModifyField";
            // 
            // ModifyInformation
            // 
            this.ModifyInformation.HeaderText = "修改信息";
            this.ModifyInformation.Name = "ModifyInformation";
            // 
            // AuditStatus
            // 
            this.AuditStatus.HeaderText = "审核状态";
            this.AuditStatus.Name = "AuditStatus";
            // 
            // ModificationTime
            // 
            this.ModificationTime.HeaderText = "修改时间";
            this.ModificationTime.Name = "ModificationTime";
            // 
            // Operation
            // 
            this.Operation.HeaderText = "操作";
            this.Operation.Name = "Operation";
            // 
            // frm_StudentStatusInformationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gv_StudentStatusInformationManagement);
            this.Name = "frm_StudentStatusInformationManagement";
            this.Text = "学籍信息管理";
            this.Load += new System.EventHandler(this.frm_StudentStatusInformationManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_StudentStatusInformationManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_StudentStatusInformationManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyField;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuditStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModificationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    }
}