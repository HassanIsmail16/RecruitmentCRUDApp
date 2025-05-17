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
            panelHeader = new Panel();
            labelLOA = new Label();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            btnRefresh = new Button();
            colPostDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            colAppDate = new DataGridViewTextBoxColumn();
            colApplicantName = new DataGridViewTextBoxColumn();
            dataGridJobApplicants = new DataGridView();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridJobApplicants).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.WhiteSmoke;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(labelLOA);
            panelHeader.Controls.Add(btnSaveChanges);
            panelHeader.Controls.Add(btnCancel);
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Location = new Point(12, 12);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(643, 75);
            panelHeader.TabIndex = 3;
            // 
            // labelLOA
            // 
            labelLOA.AutoSize = true;
            labelLOA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLOA.Location = new Point(3, 15);
            labelLOA.Name = "labelLOA";
            labelLOA.Size = new Size(212, 32);
            labelLOA.TabIndex = 9;
            labelLOA.Text = "List of Applicants";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(456, 15);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(94, 32);
            btnSaveChanges.TabIndex = 8;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(556, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 32);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(347, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 32);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // colPostDate
            // 
            colPostDate.HeaderText = "Post Date";
            colPostDate.Name = "colPostDate";
            colPostDate.ReadOnly = true;
            colPostDate.Width = 150;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Items.AddRange(new object[] { "Pending", "Under Review", "Interviewed", "Accepted", "Rejected" });
            colStatus.Name = "colStatus";
            // 
            // colAppDate
            // 
            colAppDate.HeaderText = "Application Date";
            colAppDate.Name = "colAppDate";
            colAppDate.ReadOnly = true;
            colAppDate.Width = 150;
            // 
            // colApplicantName
            // 
            colApplicantName.HeaderText = "Applicant Name";
            colApplicantName.MaxInputLength = 100;
            colApplicantName.Name = "colApplicantName";
            colApplicantName.ReadOnly = true;
            colApplicantName.Width = 200;
            // 
            // dataGridJobApplicants
            // 
            dataGridJobApplicants.AllowUserToAddRows = false;
            dataGridJobApplicants.AllowUserToDeleteRows = false;
            dataGridJobApplicants.AllowUserToResizeRows = false;
            dataGridJobApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJobApplicants.Columns.AddRange(new DataGridViewColumn[] { colApplicantName, colAppDate, colStatus, colPostDate });
            dataGridJobApplicants.Location = new Point(12, 93);
            dataGridJobApplicants.Name = "dataGridJobApplicants";
            dataGridJobApplicants.Size = new Size(643, 419);
            dataGridJobApplicants.TabIndex = 2;
            // 
            // ListOfApplicantsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 524);
            Controls.Add(panelHeader);
            Controls.Add(dataGridJobApplicants);
            Name = "ListOfApplicantsForm";
            Text = "List of Applicants";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridJobApplicants).EndInit();
            ResumeLayout(false);
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