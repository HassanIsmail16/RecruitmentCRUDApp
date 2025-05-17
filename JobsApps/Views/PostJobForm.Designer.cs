namespace RecruitmentApplication.Views
{
    partial class PostJobForm
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
            btnPost = new Button();
            lblHeader = new Label();
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
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnPost
            // 
            btnPost.Location = new Point(306, 605);
            btnPost.Margin = new Padding(3, 4, 3, 4);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(86, 39);
            btnPost.TabIndex = 24;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(86, 32);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(281, 41);
            lblHeader.TabIndex = 23;
            lblHeader.Text = "Create Job Posting";
            // 
            // tboxSkills
            // 
            tboxSkills.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tboxSkills.Location = new Point(153, 341);
            tboxSkills.Margin = new Padding(3, 4, 3, 4);
            tboxSkills.Multiline = true;
            tboxSkills.Name = "tboxSkills";
            tboxSkills.Size = new Size(238, 76);
            tboxSkills.TabIndex = 22;
            // 
            // tboxDescription
            // 
            tboxDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tboxDescription.Location = new Point(153, 427);
            tboxDescription.Margin = new Padding(3, 4, 3, 4);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(238, 167);
            tboxDescription.TabIndex = 21;
            // 
            // dateDeadline
            // 
            dateDeadline.Anchor = AnchorStyles.Right;
            dateDeadline.Location = new Point(153, 296);
            dateDeadline.Margin = new Padding(3, 4, 3, 4);
            dateDeadline.Name = "dateDeadline";
            dateDeadline.Size = new Size(238, 27);
            dateDeadline.TabIndex = 20;
            // 
            // cmboxJobType
            // 
            cmboxJobType.Anchor = AnchorStyles.Right;
            cmboxJobType.FormattingEnabled = true;
            cmboxJobType.Location = new Point(153, 251);
            cmboxJobType.Margin = new Padding(3, 4, 3, 4);
            cmboxJobType.Name = "cmboxJobType";
            cmboxJobType.Size = new Size(238, 28);
            cmboxJobType.TabIndex = 18;
            // 
            // cmboxWorkMode
            // 
            cmboxWorkMode.Anchor = AnchorStyles.Right;
            cmboxWorkMode.FormattingEnabled = true;
            cmboxWorkMode.Location = new Point(153, 212);
            cmboxWorkMode.Margin = new Padding(3, 4, 3, 4);
            cmboxWorkMode.Name = "cmboxWorkMode";
            cmboxWorkMode.Size = new Size(238, 28);
            cmboxWorkMode.TabIndex = 17;
            // 
            // cmboxExpLevel
            // 
            cmboxExpLevel.Anchor = AnchorStyles.Right;
            cmboxExpLevel.FormattingEnabled = true;
            cmboxExpLevel.Location = new Point(153, 173);
            cmboxExpLevel.Margin = new Padding(3, 4, 3, 4);
            cmboxExpLevel.Name = "cmboxExpLevel";
            cmboxExpLevel.Size = new Size(238, 28);
            cmboxExpLevel.TabIndex = 19;
            // 
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Location = new Point(71, 251);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(67, 20);
            lblJobType.TabIndex = 7;
            lblJobType.Text = "Job Type";
            // 
            // cmboxStatus
            // 
            cmboxStatus.Anchor = AnchorStyles.Right;
            cmboxStatus.FormattingEnabled = true;
            cmboxStatus.Location = new Point(153, 135);
            cmboxStatus.Margin = new Padding(3, 4, 3, 4);
            cmboxStatus.Name = "cmboxStatus";
            cmboxStatus.Size = new Size(238, 28);
            cmboxStatus.TabIndex = 16;
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Location = new Point(93, 341);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(42, 20);
            lblSkills.TabIndex = 13;
            lblSkills.Text = "Skills";
            // 
            // lblWorkMode
            // 
            lblWorkMode.AutoSize = true;
            lblWorkMode.Location = new Point(51, 212);
            lblWorkMode.Name = "lblWorkMode";
            lblWorkMode.Size = new Size(86, 20);
            lblWorkMode.TabIndex = 12;
            lblWorkMode.Text = "Work Mode";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(54, 427);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Description";
            // 
            // lblExpLevel
            // 
            lblExpLevel.AutoSize = true;
            lblExpLevel.Location = new Point(23, 173);
            lblExpLevel.Name = "lblExpLevel";
            lblExpLevel.Size = new Size(119, 20);
            lblExpLevel.TabIndex = 10;
            lblExpLevel.Text = "Experience Level";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(70, 304);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(69, 20);
            lblDeadline.TabIndex = 9;
            lblDeadline.Text = "Deadline";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(86, 135);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // tboxTitle
            // 
            tboxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tboxTitle.Location = new Point(153, 92);
            tboxTitle.Margin = new Padding(3, 4, 3, 4);
            tboxTitle.Name = "tboxTitle";
            tboxTitle.Size = new Size(238, 27);
            tboxTitle.TabIndex = 15;
            tboxTitle.TextChanged += tboxTitle_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(97, 96);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Title";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(214, 605);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 39);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // PostJobForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 675);
            Controls.Add(btnCancel);
            Controls.Add(btnPost);
            Controls.Add(lblHeader);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "PostJobForm";
            Text = "PostJobForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPost;
        private Label lblHeader;
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
        private Button btnCancel;
    }
}