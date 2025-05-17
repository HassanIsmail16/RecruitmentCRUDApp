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
            dataGridJobApplicants = new DataGridView();
            colApplicantName = new DataGridViewTextBoxColumn();
            colAppDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            colPostDate = new DataGridViewTextBoxColumn();
            btnRefresh = new Button();
            btnCancel = new Button();
            btnSaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridJobApplicants).BeginInit();
            SuspendLayout();
            // 
            // dataGridJobApplicants
            // 
            dataGridJobApplicants.AllowUserToAddRows = false;
            dataGridJobApplicants.AllowUserToDeleteRows = false;
            dataGridJobApplicants.AllowUserToResizeRows = false;
            dataGridJobApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJobApplicants.Columns.AddRange(new DataGridViewColumn[] { colApplicantName, colAppDate, colStatus, colPostDate });
            dataGridJobApplicants.Location = new Point(12, 80);
            dataGridJobApplicants.Name = "dataGridJobApplicants";
            dataGridJobApplicants.Size = new Size(643, 406);
            dataGridJobApplicants.TabIndex = 2;
            // 
            // colApplicantName
            // 
            colApplicantName.HeaderText = "Applicant Name";
            colApplicantName.MaxInputLength = 100;
            colApplicantName.Name = "colApplicantName";
            colApplicantName.ReadOnly = true;
            colApplicantName.Width = 200;
            // 
            // colAppDate
            // 
            colAppDate.HeaderText = "Application Date";
            colAppDate.Name = "colAppDate";
            colAppDate.ReadOnly = true;
            colAppDate.Width = 150;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Items.AddRange(new object[] { "Pending", "Under Review", "Interviewed", "Accepted", "Rejected" });
            colStatus.Name = "colStatus";
            // 
            // colPostDate
            // 
            colPostDate.HeaderText = "Post Date";
            colPostDate.Name = "colPostDate";
            colPostDate.ReadOnly = true;
            colPostDate.Width = 150;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 44);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(221, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 44);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(121, 12);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(94, 44);
            btnSaveChanges.TabIndex = 5;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // ListOfApplicantsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 498);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnCancel);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridJobApplicants);
            Name = "ListOfApplicantsForm";
            Text = "ListOfApplicantsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridJobApplicants).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridJobApplicants;
        private Button btnRefresh;
        private Button btnCancel;
        private Button btnSaveChanges;
        private DataGridViewTextBoxColumn colApplicantName;
        private DataGridViewTextBoxColumn colAppDate;
        private DataGridViewComboBoxColumn colStatus;
        private DataGridViewTextBoxColumn colPostDate;
    }
}