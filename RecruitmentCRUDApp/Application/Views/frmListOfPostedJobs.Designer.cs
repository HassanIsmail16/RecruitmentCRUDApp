namespace RecruitmentApplication.Views
{
    partial class frmListOfPostedJobs
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
            dataGridPostedJobs = new DataGridView();
            colCompanyName = new DataGridViewTextBoxColumn();
            colJobTitle = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            colWorkMode = new DataGridViewComboBoxColumn();
            colJobType = new DataGridViewComboBoxColumn();
            colPostDate = new DataGridViewTextBoxColumn();
            colDeadline = new DataGridViewTextBoxColumn();
            colApplicants = new DataGridViewButtonColumn();
            colControl = new DataGridViewButtonColumn();
            panelHeader = new Panel();
            btnRefresh = new Button();
            labelPostedJobs = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPostedJobs).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPostedJobs
            // 
            dataGridPostedJobs.AllowUserToAddRows = false;
            dataGridPostedJobs.AllowUserToDeleteRows = false;
            dataGridPostedJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPostedJobs.Columns.AddRange(new DataGridViewColumn[] { colCompanyName, colJobTitle, colStatus, colWorkMode, colJobType, colPostDate, colDeadline, colApplicants, colControl });
            dataGridPostedJobs.Location = new Point(12, 82);
            dataGridPostedJobs.Name = "dataGridPostedJobs";
            dataGridPostedJobs.Size = new Size(1043, 353);
            dataGridPostedJobs.TabIndex = 1;
            // 
            // colCompanyName
            // 
            colCompanyName.HeaderText = "Company Name";
            colCompanyName.MaxInputLength = 100;
            colCompanyName.Name = "colCompanyName";
            colCompanyName.ReadOnly = true;
            colCompanyName.Width = 150;
            // 
            // colJobTitle
            // 
            colJobTitle.HeaderText = "Job Title";
            colJobTitle.MaxInputLength = 100;
            colJobTitle.Name = "colJobTitle";
            colJobTitle.ReadOnly = true;
            colJobTitle.Width = 150;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Items.AddRange(new object[] { "Open", "Closed", "Hidden" });
            colStatus.MaxDropDownItems = 3;
            colStatus.Name = "colStatus";
            // 
            // colWorkMode
            // 
            colWorkMode.HeaderText = "Work Mode";
            colWorkMode.Items.AddRange(new object[] { "On-Site", "Remote", "Hybrid" });
            colWorkMode.MaxDropDownItems = 3;
            colWorkMode.Name = "colWorkMode";
            // 
            // colJobType
            // 
            colJobType.HeaderText = "Job Type";
            colJobType.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Internship" });
            colJobType.MaxDropDownItems = 3;
            colJobType.Name = "colJobType";
            // 
            // colPostDate
            // 
            colPostDate.HeaderText = "Post Date";
            colPostDate.Name = "colPostDate";
            colPostDate.ReadOnly = true;
            // 
            // colDeadline
            // 
            colDeadline.HeaderText = "Deadline";
            colDeadline.Name = "colDeadline";
            // 
            // colApplicants
            // 
            colApplicants.HeaderText = "Applicants";
            colApplicants.Name = "colApplicants";
            // 
            // colControl
            // 
            colControl.HeaderText = "Control";
            colControl.Name = "colControl";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.WhiteSmoke;
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(labelPostedJobs);
            panelHeader.Location = new Point(12, 7);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1043, 56);
            panelHeader.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(927, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 32);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // labelPostedJobs
            // 
            labelPostedJobs.AutoSize = true;
            labelPostedJobs.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPostedJobs.Location = new Point(3, 10);
            labelPostedJobs.Name = "labelPostedJobs";
            labelPostedJobs.Size = new Size(150, 32);
            labelPostedJobs.TabIndex = 3;
            labelPostedJobs.Text = "Posted Jobs";
            // 
            // frmListOfPostedJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 450);
            Controls.Add(panelHeader);
            Controls.Add(dataGridPostedJobs);
            Name = "frmListOfPostedJobs";
            Text = "Posted Jobs";
            ((System.ComponentModel.ISupportInitialize)dataGridPostedJobs).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridPostedJobs;
        private DataGridViewTextBoxColumn colCompanyName;
        private DataGridViewTextBoxColumn colJobTitle;
        private DataGridViewComboBoxColumn colStatus;
        private DataGridViewComboBoxColumn colWorkMode;
        private DataGridViewComboBoxColumn colJobType;
        private DataGridViewTextBoxColumn colPostDate;
        private DataGridViewTextBoxColumn colDeadline;
        private DataGridViewButtonColumn colApplicants;
        private DataGridViewButtonColumn colControl;
        private Panel panelHeader;
        private Button btnRefresh;
        private Label labelPostedJobs;
    }
}