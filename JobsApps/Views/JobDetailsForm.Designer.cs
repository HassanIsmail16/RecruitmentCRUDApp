namespace RecruitmentApplication.Views
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
            picboxCompanyLogo = new PictureBox();
            lblCompanyName = new Label();
            tboxSkills = new TextBox();
            tboxDescription = new TextBox();
            dateDeadline = new DateTimePicker();
            cmboxJobType = new ComboBox();
            cmboxWorkMode = new ComboBox();
            cmboxExpLevel = new ComboBox();
            lblJobType = new Label();
            cmboxStatus = new ComboBox();
            lblSkills = new Label();
            lblWorkMode = new Label();
            lblDescription = new Label();
            lblExpLevel = new Label();
            lblDeadline = new Label();
            lblStatus = new Label();
            tboxTitle = new TextBox();
            lblTitle = new Label();
            btnApply = new Button();
            btnCancel = new Button();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)picboxCompanyLogo).BeginInit();
            SuspendLayout();
            // 
            // picboxCompanyLogo
            // 
            picboxCompanyLogo.Location = new Point(14, 16);
            picboxCompanyLogo.Margin = new Padding(3, 4, 3, 4);
            picboxCompanyLogo.Name = "picboxCompanyLogo";
            picboxCompanyLogo.Size = new Size(73, 83);
            picboxCompanyLogo.TabIndex = 0;
            picboxCompanyLogo.TabStop = false;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(107, 44);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(50, 20);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "label1";
            // 
            // tboxSkills
            // 
            tboxSkills.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tboxSkills.Location = new Point(135, 360);
            tboxSkills.Margin = new Padding(3, 4, 3, 4);
            tboxSkills.Multiline = true;
            tboxSkills.Name = "tboxSkills";
            tboxSkills.ReadOnly = true;
            tboxSkills.Size = new Size(238, 76);
            tboxSkills.TabIndex = 19;
            // 
            // tboxDescription
            // 
            tboxDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tboxDescription.Location = new Point(135, 445);
            tboxDescription.Margin = new Padding(3, 4, 3, 4);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.ReadOnly = true;
            tboxDescription.Size = new Size(238, 167);
            tboxDescription.TabIndex = 20;
            // 
            // dateDeadline
            // 
            dateDeadline.Anchor = AnchorStyles.Right;
            dateDeadline.Location = new Point(135, 315);
            dateDeadline.Margin = new Padding(3, 4, 3, 4);
            dateDeadline.Name = "dateDeadline";
            dateDeadline.Size = new Size(238, 27);
            dateDeadline.TabIndex = 18;
            // 
            // cmboxJobType
            // 
            cmboxJobType.Anchor = AnchorStyles.Right;
            cmboxJobType.Enabled = false;
            cmboxJobType.FormattingEnabled = true;
            cmboxJobType.Location = new Point(135, 269);
            cmboxJobType.Margin = new Padding(3, 4, 3, 4);
            cmboxJobType.Name = "cmboxJobType";
            cmboxJobType.Size = new Size(238, 28);
            cmboxJobType.TabIndex = 14;
            // 
            // cmboxWorkMode
            // 
            cmboxWorkMode.Anchor = AnchorStyles.Right;
            cmboxWorkMode.Enabled = false;
            cmboxWorkMode.FormattingEnabled = true;
            cmboxWorkMode.Location = new Point(135, 231);
            cmboxWorkMode.Margin = new Padding(3, 4, 3, 4);
            cmboxWorkMode.Name = "cmboxWorkMode";
            cmboxWorkMode.Size = new Size(238, 28);
            cmboxWorkMode.TabIndex = 15;
            // 
            // cmboxExpLevel
            // 
            cmboxExpLevel.Anchor = AnchorStyles.Right;
            cmboxExpLevel.Enabled = false;
            cmboxExpLevel.FormattingEnabled = true;
            cmboxExpLevel.Location = new Point(135, 192);
            cmboxExpLevel.Margin = new Padding(3, 4, 3, 4);
            cmboxExpLevel.Name = "cmboxExpLevel";
            cmboxExpLevel.Size = new Size(238, 28);
            cmboxExpLevel.TabIndex = 16;
            // 
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Location = new Point(53, 269);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(67, 20);
            lblJobType.TabIndex = 5;
            lblJobType.Text = "Job Type";
            // 
            // cmboxStatus
            // 
            cmboxStatus.Anchor = AnchorStyles.Right;
            cmboxStatus.Enabled = false;
            cmboxStatus.FormattingEnabled = true;
            cmboxStatus.Location = new Point(135, 153);
            cmboxStatus.Margin = new Padding(3, 4, 3, 4);
            cmboxStatus.Name = "cmboxStatus";
            cmboxStatus.Size = new Size(238, 28);
            cmboxStatus.TabIndex = 17;
            cmboxStatus.SelectedIndexChanged += cmboxStatus_SelectedIndexChanged;
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Location = new Point(74, 360);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(42, 20);
            lblSkills.TabIndex = 6;
            lblSkills.Text = "Skills";
            // 
            // lblWorkMode
            // 
            lblWorkMode.AutoSize = true;
            lblWorkMode.Location = new Point(33, 231);
            lblWorkMode.Name = "lblWorkMode";
            lblWorkMode.Size = new Size(86, 20);
            lblWorkMode.TabIndex = 7;
            lblWorkMode.Text = "Work Mode";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(35, 445);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // lblExpLevel
            // 
            lblExpLevel.AutoSize = true;
            lblExpLevel.Location = new Point(5, 192);
            lblExpLevel.Name = "lblExpLevel";
            lblExpLevel.Size = new Size(119, 20);
            lblExpLevel.TabIndex = 9;
            lblExpLevel.Text = "Experience Level";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(51, 323);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(69, 20);
            lblDeadline.TabIndex = 10;
            lblDeadline.Text = "Deadline";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(67, 153);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // tboxTitle
            // 
            tboxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tboxTitle.Location = new Point(135, 111);
            tboxTitle.Margin = new Padding(3, 4, 3, 4);
            tboxTitle.Name = "tboxTitle";
            tboxTitle.ReadOnly = true;
            tboxTitle.Size = new Size(238, 27);
            tboxTitle.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(79, 115);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Title";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(288, 621);
            btnApply.Margin = new Padding(3, 4, 3, 4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(86, 39);
            btnApply.TabIndex = 21;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(195, 621);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 39);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(195, 25);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(173, 41);
            lblHeader.TabIndex = 22;
            lblHeader.Text = "Job Details";
            // 
            // JobDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 676);
            Controls.Add(lblHeader);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(tboxSkills);
            Controls.Add(tboxDescription);
            Controls.Add(dateDeadline);
            Controls.Add(cmboxJobType);
            Controls.Add(cmboxWorkMode);
            Controls.Add(cmboxExpLevel);
            Controls.Add(lblJobType);
            Controls.Add(cmboxStatus);
            Controls.Add(lblSkills);
            Controls.Add(lblWorkMode);
            Controls.Add(lblDescription);
            Controls.Add(lblExpLevel);
            Controls.Add(lblDeadline);
            Controls.Add(lblStatus);
            Controls.Add(tboxTitle);
            Controls.Add(lblTitle);
            Controls.Add(lblCompanyName);
            Controls.Add(picboxCompanyLogo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "JobDetailsForm";
            Text = "JobDetailsForm";
            ((System.ComponentModel.ISupportInitialize)picboxCompanyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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