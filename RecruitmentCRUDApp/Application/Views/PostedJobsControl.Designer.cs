namespace RecruitmentApplication.Views
{
    partial class PostedJobsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.btnRefresh = new Button();
            this.labelPostedJobs = new Label();
            this.dataGridPostedJobs = new DataGridView();
            this.colCompanyName = new DataGridViewTextBoxColumn();
            this.colJobTitle = new DataGridViewTextBoxColumn();
            this.colStatus = new DataGridViewComboBoxColumn();
            this.colWorkMode = new DataGridViewComboBoxColumn();
            this.colJobType = new DataGridViewComboBoxColumn();
            this.colPostDate = new DataGridViewTextBoxColumn();
            this.colDeadline = new DataGridViewTextBoxColumn();
            this.colApplicants = new DataGridViewButtonColumn();
            this.colControl = new DataGridViewButtonColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) this.dataGridPostedJobs).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.WhiteSmoke;
            this.panelHeader.BorderStyle = BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Controls.Add(this.labelPostedJobs);
            this.panelHeader.Location = new Point(15, 18);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new Size(1043, 56);
            this.panelHeader.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new Point(927, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(103, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += this.btnRefresh_Click;
            // 
            // labelPostedJobs
            // 
            this.labelPostedJobs.AutoSize = true;
            this.labelPostedJobs.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.labelPostedJobs.Location = new Point(3, 10);
            this.labelPostedJobs.Name = "labelPostedJobs";
            this.labelPostedJobs.Size = new Size(150, 32);
            this.labelPostedJobs.TabIndex = 3;
            this.labelPostedJobs.Text = "Posted Jobs";
            // 
            // dataGridPostedJobs
            // 
            this.dataGridPostedJobs.AllowUserToAddRows = false;
            this.dataGridPostedJobs.AllowUserToDeleteRows = false;
            this.dataGridPostedJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPostedJobs.Columns.AddRange(new DataGridViewColumn[] { this.colCompanyName, this.colJobTitle, this.colStatus, this.colWorkMode, this.colJobType, this.colPostDate, this.colDeadline, this.colApplicants, this.colControl });
            this.dataGridPostedJobs.Location = new Point(15, 93);
            this.dataGridPostedJobs.Name = "dataGridPostedJobs";
            this.dataGridPostedJobs.Size = new Size(1043, 353);
            this.dataGridPostedJobs.TabIndex = 3;
            // 
            // colCompanyName
            // 
            this.colCompanyName.HeaderText = "Company Name";
            this.colCompanyName.MaxInputLength = 100;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            this.colCompanyName.Width = 150;
            // 
            // colJobTitle
            // 
            this.colJobTitle.HeaderText = "Job Title";
            this.colJobTitle.MaxInputLength = 100;
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.ReadOnly = true;
            this.colJobTitle.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Items.AddRange(new object[] { "Open", "Closed", "Hidden" });
            this.colStatus.MaxDropDownItems = 3;
            this.colStatus.Name = "colStatus";
            // 
            // colWorkMode
            // 
            this.colWorkMode.HeaderText = "Work Mode";
            this.colWorkMode.Items.AddRange(new object[] { "On-Site", "Remote", "Hybrid" });
            this.colWorkMode.MaxDropDownItems = 3;
            this.colWorkMode.Name = "colWorkMode";
            // 
            // colJobType
            // 
            this.colJobType.HeaderText = "Job Type";
            this.colJobType.Items.AddRange(new object[] { "Full-Time", "Part-Time", "Internship" });
            this.colJobType.MaxDropDownItems = 3;
            this.colJobType.Name = "colJobType";
            // 
            // colPostDate
            // 
            this.colPostDate.HeaderText = "Post Date";
            this.colPostDate.Name = "colPostDate";
            this.colPostDate.ReadOnly = true;
            // 
            // colDeadline
            // 
            this.colDeadline.HeaderText = "Deadline";
            this.colDeadline.Name = "colDeadline";
            // 
            // colApplicants
            // 
            this.colApplicants.HeaderText = "Applicants";
            this.colApplicants.Name = "colApplicants";
            // 
            // colControl
            // 
            this.colControl.HeaderText = "Control";
            this.colControl.Name = "colControl";
            // 
            // PostedJobControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dataGridPostedJobs);
            this.Name = "PostedJobControl";
            this.Size = new Size(1071, 456);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) this.dataGridPostedJobs).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnRefresh;
        private Label labelPostedJobs;
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
    }
}
