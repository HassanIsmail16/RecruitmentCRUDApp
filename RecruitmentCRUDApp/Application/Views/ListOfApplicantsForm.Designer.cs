namespace RecruitmentApplication.Views
{
    partial class ListOfApplicantsForm
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
            this.panelHeader = new Panel();
            this.labelLOA = new Label();
            this.btnSaveChanges = new Button();
            this.btnCancel = new Button();
            this.btnRefresh = new Button();
            this.colPostDate = new DataGridViewTextBoxColumn();
            this.colStatus = new DataGridViewComboBoxColumn();
            this.colAppDate = new DataGridViewTextBoxColumn();
            this.colApplicantName = new DataGridViewTextBoxColumn();
            this.dataGridJobApplicants = new DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) this.dataGridJobApplicants).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.WhiteSmoke;
            this.panelHeader.BorderStyle = BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.labelLOA);
            this.panelHeader.Controls.Add(this.btnSaveChanges);
            this.panelHeader.Controls.Add(this.btnCancel);
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Location = new Point(12, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(643, 64);
            this.panelHeader.TabIndex = 3;
            // 
            // labelLOA
            // 
            this.labelLOA.AutoSize = true;
            this.labelLOA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelLOA.Location = new Point(3, 15);
            this.labelLOA.Name = "labelLOA";
            this.labelLOA.Size = new Size(212, 32);
            this.labelLOA.TabIndex = 9;
            this.labelLOA.Text = "List of Applicants";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new Point(456, 15);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new Size(94, 32);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(556, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(75, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new Point(347, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(75, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // colPostDate
            // 
            this.colPostDate.HeaderText = "Post Date";
            this.colPostDate.Name = "colPostDate";
            this.colPostDate.ReadOnly = true;
            this.colPostDate.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Items.AddRange(new object[] { "Pending", "Under Review", "Interviewed", "Accepted", "Rejected" });
            this.colStatus.Name = "colStatus";
            // 
            // colAppDate
            // 
            this.colAppDate.HeaderText = "Application Date";
            this.colAppDate.Name = "colAppDate";
            this.colAppDate.ReadOnly = true;
            this.colAppDate.Width = 150;
            // 
            // colApplicantName
            // 
            this.colApplicantName.HeaderText = "Applicant Name";
            this.colApplicantName.MaxInputLength = 100;
            this.colApplicantName.Name = "colApplicantName";
            this.colApplicantName.ReadOnly = true;
            this.colApplicantName.Width = 200;
            // 
            // dataGridJobApplicants
            // 
            this.dataGridJobApplicants.AllowUserToAddRows = false;
            this.dataGridJobApplicants.AllowUserToDeleteRows = false;
            this.dataGridJobApplicants.AllowUserToResizeRows = false;
            this.dataGridJobApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJobApplicants.Columns.AddRange(new DataGridViewColumn[] { this.colApplicantName, this.colAppDate, this.colStatus, this.colPostDate });
            this.dataGridJobApplicants.Location = new Point(12, 93);
            this.dataGridJobApplicants.Name = "dataGridJobApplicants";
            this.dataGridJobApplicants.Size = new Size(643, 419);
            this.dataGridJobApplicants.TabIndex = 2;
            // 
            // ListOfApplicantsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(667, 524);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dataGridJobApplicants);
            this.Name = "ListOfApplicantsForm";
            this.Text = "List of Applicants";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) this.dataGridJobApplicants).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label labelLOA;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn colPostDate;
        private DataGridViewComboBoxColumn colStatus;
        private DataGridViewTextBoxColumn colAppDate;
        private DataGridViewTextBoxColumn colApplicantName;
        private DataGridView dataGridJobApplicants;
    }
}