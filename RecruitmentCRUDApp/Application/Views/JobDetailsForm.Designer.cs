﻿namespace RecruitmentApplication.Views
{
    partial class JobDetailsForm
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
            this.picboxCompanyLogo = new PictureBox();
            this.lblCompanyName = new Label();
            this.tboxSkills = new TextBox();
            this.tboxDescription = new TextBox();
            this.dateDeadline = new DateTimePicker();
            this.cmboxJobType = new ComboBox();
            this.cmboxWorkMode = new ComboBox();
            this.cmboxExpLevel = new ComboBox();
            this.lblJobType = new Label();
            this.cmboxStatus = new ComboBox();
            this.lblSkills = new Label();
            this.lblWorkMode = new Label();
            this.lblDescription = new Label();
            this.lblExpLevel = new Label();
            this.lblDeadline = new Label();
            this.lblStatus = new Label();
            this.tboxTitle = new TextBox();
            this.lblTitle = new Label();
            this.btnApply = new Button();
            this.btnCancel = new Button();
            this.lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize) this.picboxCompanyLogo).BeginInit();
            this.SuspendLayout();
            // 
            // picboxCompanyLogo
            // 
            this.picboxCompanyLogo.Location = new Point(12, 12);
            this.picboxCompanyLogo.Name = "picboxCompanyLogo";
            this.picboxCompanyLogo.Size = new Size(64, 62);
            this.picboxCompanyLogo.TabIndex = 0;
            this.picboxCompanyLogo.TabStop = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new Point(94, 33);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new Size(38, 15);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "label1";
            // 
            // tboxSkills
            // 
            this.tboxSkills.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            this.tboxSkills.Location = new Point(118, 270);
            this.tboxSkills.Multiline = true;
            this.tboxSkills.Name = "tboxSkills";
            this.tboxSkills.ReadOnly = true;
            this.tboxSkills.Size = new Size(209, 58);
            this.tboxSkills.TabIndex = 19;
            // 
            // tboxDescription
            // 
            this.tboxDescription.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            this.tboxDescription.Location = new Point(118, 334);
            this.tboxDescription.Multiline = true;
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.ReadOnly = true;
            this.tboxDescription.Size = new Size(209, 126);
            this.tboxDescription.TabIndex = 20;
            // 
            // dateDeadline
            // 
            this.dateDeadline.Anchor = AnchorStyles.Right;
            this.dateDeadline.Location = new Point(118, 236);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new Size(209, 23);
            this.dateDeadline.TabIndex = 18;
            // 
            // cmboxJobType
            // 
            this.cmboxJobType.Anchor = AnchorStyles.Right;
            this.cmboxJobType.Enabled = false;
            this.cmboxJobType.FormattingEnabled = true;
            this.cmboxJobType.Location = new Point(118, 202);
            this.cmboxJobType.Name = "cmboxJobType";
            this.cmboxJobType.Size = new Size(209, 23);
            this.cmboxJobType.TabIndex = 14;
            // 
            // cmboxWorkMode
            // 
            this.cmboxWorkMode.Anchor = AnchorStyles.Right;
            this.cmboxWorkMode.Enabled = false;
            this.cmboxWorkMode.FormattingEnabled = true;
            this.cmboxWorkMode.Location = new Point(118, 173);
            this.cmboxWorkMode.Name = "cmboxWorkMode";
            this.cmboxWorkMode.Size = new Size(209, 23);
            this.cmboxWorkMode.TabIndex = 15;
            // 
            // cmboxExpLevel
            // 
            this.cmboxExpLevel.Anchor = AnchorStyles.Right;
            this.cmboxExpLevel.Enabled = false;
            this.cmboxExpLevel.FormattingEnabled = true;
            this.cmboxExpLevel.Location = new Point(118, 144);
            this.cmboxExpLevel.Name = "cmboxExpLevel";
            this.cmboxExpLevel.Size = new Size(209, 23);
            this.cmboxExpLevel.TabIndex = 16;
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Location = new Point(46, 202);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new Size(52, 15);
            this.lblJobType.TabIndex = 5;
            this.lblJobType.Text = "Job Type";
            // 
            // cmboxStatus
            // 
            this.cmboxStatus.Anchor = AnchorStyles.Right;
            this.cmboxStatus.Enabled = false;
            this.cmboxStatus.FormattingEnabled = true;
            this.cmboxStatus.Location = new Point(118, 115);
            this.cmboxStatus.Name = "cmboxStatus";
            this.cmboxStatus.Size = new Size(209, 23);
            this.cmboxStatus.TabIndex = 17;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new Point(65, 270);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new Size(33, 15);
            this.lblSkills.TabIndex = 6;
            this.lblSkills.Text = "Skills";
            // 
            // lblWorkMode
            // 
            this.lblWorkMode.AutoSize = true;
            this.lblWorkMode.Location = new Point(29, 173);
            this.lblWorkMode.Name = "lblWorkMode";
            this.lblWorkMode.Size = new Size(69, 15);
            this.lblWorkMode.TabIndex = 7;
            this.lblWorkMode.Text = "Work Mode";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new Point(31, 334);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(67, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // lblExpLevel
            // 
            this.lblExpLevel.AutoSize = true;
            this.lblExpLevel.Location = new Point(4, 144);
            this.lblExpLevel.Name = "lblExpLevel";
            this.lblExpLevel.Size = new Size(94, 15);
            this.lblExpLevel.TabIndex = 9;
            this.lblExpLevel.Text = "Experience Level";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new Point(45, 242);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new Size(53, 15);
            this.lblDeadline.TabIndex = 10;
            this.lblDeadline.Text = "Deadline";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(59, 115);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(39, 15);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // tboxTitle
            // 
            this.tboxTitle.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
            this.tboxTitle.Location = new Point(118, 83);
            this.tboxTitle.Name = "tboxTitle";
            this.tboxTitle.ReadOnly = true;
            this.tboxTitle.Size = new Size(209, 23);
            this.tboxTitle.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(69, 86);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(29, 15);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // btnApply
            // 
            this.btnApply.Location = new Point(252, 466);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new Size(75, 29);
            this.btnApply.TabIndex = 21;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(171, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(75, 29);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.lblHeader.Location = new Point(171, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new Size(140, 32);
            this.lblHeader.TabIndex = 22;
            this.lblHeader.Text = "Job Details";
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(352, 507);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tboxSkills);
            this.Controls.Add(this.tboxDescription);
            this.Controls.Add(this.dateDeadline);
            this.Controls.Add(this.cmboxJobType);
            this.Controls.Add(this.cmboxWorkMode);
            this.Controls.Add(this.cmboxExpLevel);
            this.Controls.Add(this.lblJobType);
            this.Controls.Add(this.cmboxStatus);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblWorkMode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblExpLevel);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tboxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.picboxCompanyLogo);
            this.Name = "JobDetailsForm";
            this.Text = "JobDetailsForm";
            ((System.ComponentModel.ISupportInitialize) this.picboxCompanyLogo).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private PictureBox picboxCompanyLogo;
        private Label lblCompanyName;
        private TextBox tboxSkills;
        private TextBox tboxDescription;
        private DateTimePicker dateDeadline;
        private ComboBox cmboxJobType;
        private ComboBox cmboxWorkMode;
        private ComboBox cmboxExpLevel;
        private Label lblJobType;
        private ComboBox cmboxStatus;
        private Label lblSkills;
        private Label lblWorkMode;
        private Label lblDescription;
        private Label lblExpLevel;
        private Label lblDeadline;
        private Label lblStatus;
        private TextBox tboxTitle;
        private Label lblTitle;
        private Button btnApply;
        private Button btnCancel;
        private Label lblHeader;
    }
}