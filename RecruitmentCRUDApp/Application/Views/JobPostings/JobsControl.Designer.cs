namespace RecruitmentApplication.Views
{
    partial class JobsControl
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
            this.refreshBtn = new Button();
            this.groupJobType = new GroupBox();
            this.cbxJobTypeContract = new CheckBox();
            this.cbxJobTypePartTime = new CheckBox();
            this.cbxJobTypeFullTime = new CheckBox();
            this.gboxWorkMode = new GroupBox();
            this.cboxWorkModeHybrid = new CheckBox();
            this.cboxWorkModeRemote = new CheckBox();
            this.cboxWorkModeOnSite = new CheckBox();
            this.gboxExperienceLevel = new GroupBox();
            this.cboxExperienceLevelStudent = new CheckBox();
            this.cboxExperienceLevelFreshGrad = new CheckBox();
            this.cboxExperienceLevelJunior = new CheckBox();
            this.cboxExperienceLevelMidLevel = new CheckBox();
            this.cboxExperienceLevelSenior = new CheckBox();
            this.btnApplyFilters = new Button();
            this.tboxSearchInput = new TextBox();
            this.btnSearch = new Button();
            this.dataGridPostings = new DataGridView();
            this.groupJobType.SuspendLayout();
            this.gboxWorkMode.SuspendLayout();
            this.gboxExperienceLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) this.dataGridPostings).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = AnchorStyles.Left;
            this.refreshBtn.Location = new Point(22, 300);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new Size(98, 23);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += this.refreshBtn_Click;
            // 
            // groupJobType
            // 
            this.groupJobType.Controls.Add(this.cbxJobTypeContract);
            this.groupJobType.Controls.Add(this.cbxJobTypePartTime);
            this.groupJobType.Controls.Add(this.cbxJobTypeFullTime);
            this.groupJobType.Location = new Point(126, 300);
            this.groupJobType.Name = "groupJobType";
            this.groupJobType.Size = new Size(103, 152);
            this.groupJobType.TabIndex = 2;
            this.groupJobType.TabStop = false;
            this.groupJobType.Text = "Job Type";
            // 
            // cbxJobTypeContract
            // 
            this.cbxJobTypeContract.AutoSize = true;
            this.cbxJobTypeContract.Location = new Point(12, 69);
            this.cbxJobTypeContract.Name = "cbxJobTypeContract";
            this.cbxJobTypeContract.Size = new Size(72, 19);
            this.cbxJobTypeContract.TabIndex = 0;
            this.cbxJobTypeContract.Text = "Contract";
            this.cbxJobTypeContract.UseVisualStyleBackColor = true;
            // 
            // cbxJobTypePartTime
            // 
            this.cbxJobTypePartTime.AutoSize = true;
            this.cbxJobTypePartTime.Location = new Point(12, 44);
            this.cbxJobTypePartTime.Name = "cbxJobTypePartTime";
            this.cbxJobTypePartTime.Size = new Size(78, 19);
            this.cbxJobTypePartTime.TabIndex = 0;
            this.cbxJobTypePartTime.Text = "Part-Time";
            this.cbxJobTypePartTime.UseVisualStyleBackColor = true;
            // 
            // cbxJobTypeFullTime
            // 
            this.cbxJobTypeFullTime.AutoSize = true;
            this.cbxJobTypeFullTime.Location = new Point(12, 19);
            this.cbxJobTypeFullTime.Name = "cbxJobTypeFullTime";
            this.cbxJobTypeFullTime.Size = new Size(76, 19);
            this.cbxJobTypeFullTime.TabIndex = 0;
            this.cbxJobTypeFullTime.Text = "Full-Time";
            this.cbxJobTypeFullTime.UseVisualStyleBackColor = true;
            // 
            // gboxWorkMode
            // 
            this.gboxWorkMode.Controls.Add(this.cboxWorkModeHybrid);
            this.gboxWorkMode.Controls.Add(this.cboxWorkModeRemote);
            this.gboxWorkMode.Controls.Add(this.cboxWorkModeOnSite);
            this.gboxWorkMode.Location = new Point(235, 300);
            this.gboxWorkMode.Name = "gboxWorkMode";
            this.gboxWorkMode.Size = new Size(94, 152);
            this.gboxWorkMode.TabIndex = 2;
            this.gboxWorkMode.TabStop = false;
            this.gboxWorkMode.Text = "Work Mode";
            // 
            // cboxWorkModeHybrid
            // 
            this.cboxWorkModeHybrid.AutoSize = true;
            this.cboxWorkModeHybrid.Location = new Point(12, 69);
            this.cboxWorkModeHybrid.Name = "cboxWorkModeHybrid";
            this.cboxWorkModeHybrid.Size = new Size(62, 19);
            this.cboxWorkModeHybrid.TabIndex = 0;
            this.cboxWorkModeHybrid.Text = "Hybrid";
            this.cboxWorkModeHybrid.UseVisualStyleBackColor = true;
            // 
            // cboxWorkModeRemote
            // 
            this.cboxWorkModeRemote.AutoSize = true;
            this.cboxWorkModeRemote.Location = new Point(12, 44);
            this.cboxWorkModeRemote.Name = "cboxWorkModeRemote";
            this.cboxWorkModeRemote.Size = new Size(67, 19);
            this.cboxWorkModeRemote.TabIndex = 0;
            this.cboxWorkModeRemote.Text = "Remote";
            this.cboxWorkModeRemote.UseVisualStyleBackColor = true;
            // 
            // cboxWorkModeOnSite
            // 
            this.cboxWorkModeOnSite.AutoSize = true;
            this.cboxWorkModeOnSite.Location = new Point(12, 19);
            this.cboxWorkModeOnSite.Name = "cboxWorkModeOnSite";
            this.cboxWorkModeOnSite.Size = new Size(66, 19);
            this.cboxWorkModeOnSite.TabIndex = 0;
            this.cboxWorkModeOnSite.Text = "On-Site";
            this.cboxWorkModeOnSite.UseVisualStyleBackColor = true;
            // 
            // gboxExperienceLevel
            // 
            this.gboxExperienceLevel.Controls.Add(this.cboxExperienceLevelStudent);
            this.gboxExperienceLevel.Controls.Add(this.cboxExperienceLevelFreshGrad);
            this.gboxExperienceLevel.Controls.Add(this.cboxExperienceLevelJunior);
            this.gboxExperienceLevel.Controls.Add(this.cboxExperienceLevelMidLevel);
            this.gboxExperienceLevel.Controls.Add(this.cboxExperienceLevelSenior);
            this.gboxExperienceLevel.Location = new Point(335, 300);
            this.gboxExperienceLevel.Name = "gboxExperienceLevel";
            this.gboxExperienceLevel.Size = new Size(124, 152);
            this.gboxExperienceLevel.TabIndex = 2;
            this.gboxExperienceLevel.TabStop = false;
            this.gboxExperienceLevel.Text = "Experience Level";
            // 
            // cboxExperienceLevelStudent
            // 
            this.cboxExperienceLevelStudent.AutoSize = true;
            this.cboxExperienceLevelStudent.Location = new Point(12, 119);
            this.cboxExperienceLevelStudent.Name = "cboxExperienceLevelStudent";
            this.cboxExperienceLevelStudent.Size = new Size(67, 19);
            this.cboxExperienceLevelStudent.TabIndex = 0;
            this.cboxExperienceLevelStudent.Text = "Student";
            this.cboxExperienceLevelStudent.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelFreshGrad
            // 
            this.cboxExperienceLevelFreshGrad.AutoSize = true;
            this.cboxExperienceLevelFreshGrad.Location = new Point(12, 94);
            this.cboxExperienceLevelFreshGrad.Name = "cboxExperienceLevelFreshGrad";
            this.cboxExperienceLevelFreshGrad.Size = new Size(105, 19);
            this.cboxExperienceLevelFreshGrad.TabIndex = 0;
            this.cboxExperienceLevelFreshGrad.Text = "Fresh Graduate";
            this.cboxExperienceLevelFreshGrad.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelJunior
            // 
            this.cboxExperienceLevelJunior.AutoSize = true;
            this.cboxExperienceLevelJunior.Location = new Point(12, 69);
            this.cboxExperienceLevelJunior.Name = "cboxExperienceLevelJunior";
            this.cboxExperienceLevelJunior.Size = new Size(58, 19);
            this.cboxExperienceLevelJunior.TabIndex = 0;
            this.cboxExperienceLevelJunior.Text = "Junior";
            this.cboxExperienceLevelJunior.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelMidLevel
            // 
            this.cboxExperienceLevelMidLevel.AutoSize = true;
            this.cboxExperienceLevelMidLevel.Location = new Point(12, 44);
            this.cboxExperienceLevelMidLevel.Name = "cboxExperienceLevelMidLevel";
            this.cboxExperienceLevelMidLevel.Size = new Size(79, 19);
            this.cboxExperienceLevelMidLevel.TabIndex = 0;
            this.cboxExperienceLevelMidLevel.Text = "Mid-Level";
            this.cboxExperienceLevelMidLevel.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelSenior
            // 
            this.cboxExperienceLevelSenior.AutoSize = true;
            this.cboxExperienceLevelSenior.Location = new Point(12, 19);
            this.cboxExperienceLevelSenior.Name = "cboxExperienceLevelSenior";
            this.cboxExperienceLevelSenior.Size = new Size(59, 19);
            this.cboxExperienceLevelSenior.TabIndex = 0;
            this.cboxExperienceLevelSenior.Text = "Senior";
            this.cboxExperienceLevelSenior.TextAlign = ContentAlignment.MiddleCenter;
            this.cboxExperienceLevelSenior.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Anchor = AnchorStyles.Left;
            this.btnApplyFilters.Location = new Point(22, 329);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new Size(98, 23);
            this.btnApplyFilters.TabIndex = 1;
            this.btnApplyFilters.Text = "Apply Filters";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += this.btnApplyFilters_Click;
            // 
            // tboxSearchInput
            // 
            this.tboxSearchInput.Location = new Point(22, 16);
            this.tboxSearchInput.Name = "tboxSearchInput";
            this.tboxSearchInput.PlaceholderText = "Search for available vacancies";
            this.tboxSearchInput.Size = new Size(523, 23);
            this.tboxSearchInput.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new Point(551, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(78, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridPostings
            // 
            this.dataGridPostings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPostings.Location = new Point(22, 45);
            this.dataGridPostings.Name = "dataGridPostings";
            this.dataGridPostings.Size = new Size(607, 235);
            this.dataGridPostings.TabIndex = 7;
            this.dataGridPostings.CellContentClick += this.dataGridPostings_CellContentClick;
            // 
            // JobsControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.dataGridPostings);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tboxSearchInput);
            this.Controls.Add(this.gboxExperienceLevel);
            this.Controls.Add(this.gboxWorkMode);
            this.Controls.Add(this.groupJobType);
            this.Controls.Add(this.btnApplyFilters);
            this.Controls.Add(this.refreshBtn);
            this.Name = "JobsControl";
            this.Size = new Size(649, 501);
            this.Load += this.JobsControl_Load;
            this.groupJobType.ResumeLayout(false);
            this.groupJobType.PerformLayout();
            this.gboxWorkMode.ResumeLayout(false);
            this.gboxWorkMode.PerformLayout();
            this.gboxExperienceLevel.ResumeLayout(false);
            this.gboxExperienceLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) this.dataGridPostings).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Button refreshBtn;
        private GroupBox groupJobType;
        private CheckBox cbxJobTypePartTime;
        private CheckBox cbxJobTypeFullTime;
        private CheckBox cbxJobTypeContract;
        private GroupBox gboxWorkMode;
        private CheckBox cboxWorkModeHybrid;
        private CheckBox cboxWorkModeRemote;
        private CheckBox cboxWorkModeOnSite;
        private GroupBox gboxExperienceLevel;
        private CheckBox cboxExperienceLevelJunior;
        private CheckBox cboxExperienceLevelMidLevel;
        private CheckBox cboxExperienceLevelSenior;
        private Button btnApplyFilters;
        private CheckBox cboxExperienceLevelFreshGrad;
        private CheckBox cboxExperienceLevelStudent;
        private TextBox tboxSearchInput;
        private Button btnSearch;
        private DataGridView dataGridPostings;
    }
}
