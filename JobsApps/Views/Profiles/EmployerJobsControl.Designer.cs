namespace RecruitmentApplication.Views.Profiles
{
    partial class EmployerJobsControl
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
            dataGridPostings = new DataGridView();
            btnSearch = new Button();
            tboxSearchInput = new TextBox();
            lblIndustry = new Label();
            cmboxIndustry = new ComboBox();
            gboxExperienceLevel = new GroupBox();
            cboxExperienceLevelIntern = new CheckBox();
            cboxExperienceLevelFreshGrad = new CheckBox();
            cboxExperienceLevelJunior = new CheckBox();
            cboxExperienceLevelMidLevel = new CheckBox();
            cboxExperienceLevelSenior = new CheckBox();
            gboxWorkMode = new GroupBox();
            cboxWorkModeHybrid = new CheckBox();
            cboxWorkModeRemote = new CheckBox();
            cboxWorkModeOnSite = new CheckBox();
            groupJobType = new GroupBox();
            cbxJobTypeContract = new CheckBox();
            cbxJobTypePartTime = new CheckBox();
            cbxJobTypeFullTime = new CheckBox();
            btnApplyFilters = new Button();
            refreshBtn = new Button();
            addbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPostings).BeginInit();
            gboxExperienceLevel.SuspendLayout();
            gboxWorkMode.SuspendLayout();
            groupJobType.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPostings
            // 
            dataGridPostings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPostings.Location = new Point(16, 45);
            dataGridPostings.Name = "dataGridPostings";
            dataGridPostings.Size = new Size(607, 235);
            dataGridPostings.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(545, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 23);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tboxSearchInput
            // 
            tboxSearchInput.Location = new Point(16, 16);
            tboxSearchInput.Name = "tboxSearchInput";
            tboxSearchInput.PlaceholderText = "Search for available vacancies";
            tboxSearchInput.Size = new Size(523, 23);
            tboxSearchInput.TabIndex = 15;
            // 
            // lblIndustry
            // 
            lblIndustry.AutoSize = true;
            lblIndustry.Location = new Point(471, 308);
            lblIndustry.Name = "lblIndustry";
            lblIndustry.Size = new Size(50, 15);
            lblIndustry.TabIndex = 14;
            lblIndustry.Text = "Industry";
            lblIndustry.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmboxIndustry
            // 
            cmboxIndustry.FormattingEnabled = true;
            cmboxIndustry.Location = new Point(471, 326);
            cmboxIndustry.Name = "cmboxIndustry";
            cmboxIndustry.Size = new Size(121, 23);
            cmboxIndustry.TabIndex = 13;
            // 
            // gboxExperienceLevel
            // 
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelIntern);
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelFreshGrad);
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelJunior);
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelMidLevel);
            gboxExperienceLevel.Controls.Add(cboxExperienceLevelSenior);
            gboxExperienceLevel.Location = new Point(329, 300);
            gboxExperienceLevel.Name = "gboxExperienceLevel";
            gboxExperienceLevel.Size = new Size(124, 152);
            gboxExperienceLevel.TabIndex = 10;
            gboxExperienceLevel.TabStop = false;
            gboxExperienceLevel.Text = "Experience Level";
            // 
            // cboxExperienceLevelIntern
            // 
            cboxExperienceLevelIntern.AutoSize = true;
            cboxExperienceLevelIntern.Location = new Point(12, 119);
            cboxExperienceLevelIntern.Name = "cboxExperienceLevelIntern";
            cboxExperienceLevelIntern.Size = new Size(57, 19);
            cboxExperienceLevelIntern.TabIndex = 0;
            cboxExperienceLevelIntern.Text = "Intern";
            cboxExperienceLevelIntern.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelFreshGrad
            // 
            cboxExperienceLevelFreshGrad.AutoSize = true;
            cboxExperienceLevelFreshGrad.Location = new Point(12, 94);
            cboxExperienceLevelFreshGrad.Name = "cboxExperienceLevelFreshGrad";
            cboxExperienceLevelFreshGrad.Size = new Size(105, 19);
            cboxExperienceLevelFreshGrad.TabIndex = 0;
            cboxExperienceLevelFreshGrad.Text = "Fresh Graduate";
            cboxExperienceLevelFreshGrad.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelJunior
            // 
            cboxExperienceLevelJunior.AutoSize = true;
            cboxExperienceLevelJunior.Location = new Point(12, 69);
            cboxExperienceLevelJunior.Name = "cboxExperienceLevelJunior";
            cboxExperienceLevelJunior.Size = new Size(58, 19);
            cboxExperienceLevelJunior.TabIndex = 0;
            cboxExperienceLevelJunior.Text = "Junior";
            cboxExperienceLevelJunior.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelMidLevel
            // 
            cboxExperienceLevelMidLevel.AutoSize = true;
            cboxExperienceLevelMidLevel.Location = new Point(12, 44);
            cboxExperienceLevelMidLevel.Name = "cboxExperienceLevelMidLevel";
            cboxExperienceLevelMidLevel.Size = new Size(79, 19);
            cboxExperienceLevelMidLevel.TabIndex = 0;
            cboxExperienceLevelMidLevel.Text = "Mid-Level";
            cboxExperienceLevelMidLevel.UseVisualStyleBackColor = true;
            // 
            // cboxExperienceLevelSenior
            // 
            cboxExperienceLevelSenior.AutoSize = true;
            cboxExperienceLevelSenior.Location = new Point(12, 19);
            cboxExperienceLevelSenior.Name = "cboxExperienceLevelSenior";
            cboxExperienceLevelSenior.Size = new Size(59, 19);
            cboxExperienceLevelSenior.TabIndex = 0;
            cboxExperienceLevelSenior.Text = "Senior";
            cboxExperienceLevelSenior.TextAlign = ContentAlignment.MiddleCenter;
            cboxExperienceLevelSenior.UseVisualStyleBackColor = true;
            // 
            // gboxWorkMode
            // 
            gboxWorkMode.Controls.Add(cboxWorkModeHybrid);
            gboxWorkMode.Controls.Add(cboxWorkModeRemote);
            gboxWorkMode.Controls.Add(cboxWorkModeOnSite);
            gboxWorkMode.Location = new Point(229, 300);
            gboxWorkMode.Name = "gboxWorkMode";
            gboxWorkMode.Size = new Size(94, 152);
            gboxWorkMode.TabIndex = 11;
            gboxWorkMode.TabStop = false;
            gboxWorkMode.Text = "Work Mode";
            // 
            // cboxWorkModeHybrid
            // 
            cboxWorkModeHybrid.AutoSize = true;
            cboxWorkModeHybrid.Location = new Point(12, 69);
            cboxWorkModeHybrid.Name = "cboxWorkModeHybrid";
            cboxWorkModeHybrid.Size = new Size(62, 19);
            cboxWorkModeHybrid.TabIndex = 0;
            cboxWorkModeHybrid.Text = "Hybrid";
            cboxWorkModeHybrid.UseVisualStyleBackColor = true;
            // 
            // cboxWorkModeRemote
            // 
            cboxWorkModeRemote.AutoSize = true;
            cboxWorkModeRemote.Location = new Point(12, 44);
            cboxWorkModeRemote.Name = "cboxWorkModeRemote";
            cboxWorkModeRemote.Size = new Size(67, 19);
            cboxWorkModeRemote.TabIndex = 0;
            cboxWorkModeRemote.Text = "Remote";
            cboxWorkModeRemote.UseVisualStyleBackColor = true;
            // 
            // cboxWorkModeOnSite
            // 
            cboxWorkModeOnSite.AutoSize = true;
            cboxWorkModeOnSite.Location = new Point(12, 19);
            cboxWorkModeOnSite.Name = "cboxWorkModeOnSite";
            cboxWorkModeOnSite.Size = new Size(66, 19);
            cboxWorkModeOnSite.TabIndex = 0;
            cboxWorkModeOnSite.Text = "On-Site";
            cboxWorkModeOnSite.UseVisualStyleBackColor = true;
            // 
            // groupJobType
            // 
            groupJobType.Controls.Add(cbxJobTypeContract);
            groupJobType.Controls.Add(cbxJobTypePartTime);
            groupJobType.Controls.Add(cbxJobTypeFullTime);
            groupJobType.Location = new Point(120, 300);
            groupJobType.Name = "groupJobType";
            groupJobType.Size = new Size(103, 152);
            groupJobType.TabIndex = 12;
            groupJobType.TabStop = false;
            groupJobType.Text = "Job Type";
            // 
            // cbxJobTypeContract
            // 
            cbxJobTypeContract.AutoSize = true;
            cbxJobTypeContract.Location = new Point(12, 69);
            cbxJobTypeContract.Name = "cbxJobTypeContract";
            cbxJobTypeContract.Size = new Size(72, 19);
            cbxJobTypeContract.TabIndex = 0;
            cbxJobTypeContract.Text = "Contract";
            cbxJobTypeContract.UseVisualStyleBackColor = true;
            // 
            // cbxJobTypePartTime
            // 
            cbxJobTypePartTime.AutoSize = true;
            cbxJobTypePartTime.Location = new Point(12, 44);
            cbxJobTypePartTime.Name = "cbxJobTypePartTime";
            cbxJobTypePartTime.Size = new Size(78, 19);
            cbxJobTypePartTime.TabIndex = 0;
            cbxJobTypePartTime.Text = "Part-Time";
            cbxJobTypePartTime.UseVisualStyleBackColor = true;
            // 
            // cbxJobTypeFullTime
            // 
            cbxJobTypeFullTime.AutoSize = true;
            cbxJobTypeFullTime.Location = new Point(12, 19);
            cbxJobTypeFullTime.Name = "cbxJobTypeFullTime";
            cbxJobTypeFullTime.Size = new Size(76, 19);
            cbxJobTypeFullTime.TabIndex = 0;
            cbxJobTypeFullTime.Text = "Full-Time";
            cbxJobTypeFullTime.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Anchor = AnchorStyles.Left;
            btnApplyFilters.Location = new Point(16, 325);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(98, 23);
            btnApplyFilters.TabIndex = 8;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Left;
            refreshBtn.Location = new Point(16, 296);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(98, 23);
            refreshBtn.TabIndex = 9;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(471, 365);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(98, 23);
            addbtn.TabIndex = 18;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addbtn);
            Controls.Add(dataGridPostings);
            Controls.Add(btnSearch);
            Controls.Add(tboxSearchInput);
            Controls.Add(lblIndustry);
            Controls.Add(cmboxIndustry);
            Controls.Add(gboxExperienceLevel);
            Controls.Add(gboxWorkMode);
            Controls.Add(groupJobType);
            Controls.Add(btnApplyFilters);
            Controls.Add(refreshBtn);
            Name = "UserControl1";
            Size = new Size(642, 477);
            ((System.ComponentModel.ISupportInitialize)dataGridPostings).EndInit();
            gboxExperienceLevel.ResumeLayout(false);
            gboxExperienceLevel.PerformLayout();
            gboxWorkMode.ResumeLayout(false);
            gboxWorkMode.PerformLayout();
            groupJobType.ResumeLayout(false);
            groupJobType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPostings;
        private Button btnSearch;
        private TextBox tboxSearchInput;
        private Label lblIndustry;
        private ComboBox cmboxIndustry;
        private GroupBox gboxExperienceLevel;
        private CheckBox cboxExperienceLevelIntern;
        private CheckBox cboxExperienceLevelFreshGrad;
        private CheckBox cboxExperienceLevelJunior;
        private CheckBox cboxExperienceLevelMidLevel;
        private CheckBox cboxExperienceLevelSenior;
        private GroupBox gboxWorkMode;
        private CheckBox cboxWorkModeHybrid;
        private CheckBox cboxWorkModeRemote;
        private CheckBox cboxWorkModeOnSite;
        private GroupBox groupJobType;
        private CheckBox cbxJobTypeContract;
        private CheckBox cbxJobTypePartTime;
        private CheckBox cbxJobTypeFullTime;
        private Button btnApplyFilters;
        private Button refreshBtn;
        private Button addbtn;
    }
}
