namespace RecruitmentApplication.Views
{
    partial class PostJobControl
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
            this.lblTitle = new Label();
            this.tboxTitle = new TextBox();
            this.lblStatus = new Label();
            this.cmboxStatus = new ComboBox();
            this.dateDeadline = new DateTimePicker();
            this.lblDeadline = new Label();
            this.lblDescription = new Label();
            this.tboxDescription = new TextBox();
            this.lblHeader = new Label();
            this.btnPost = new Button();
            this.lblExpLevel = new Label();
            this.cmboxExpLevel = new ComboBox();
            this.lblWorkMode = new Label();
            this.cmboxWorkMode = new ComboBox();
            this.lblJobType = new Label();
            this.cmboxJobType = new ComboBox();
            this.lblSkills = new Label();
            this.tboxSkills = new TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(74, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(29, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // tboxTitle
            // 
            this.tboxTitle.Anchor =  AnchorStyles.Top | AnchorStyles.Right;
            this.tboxTitle.Location = new Point(123, 64);
            this.tboxTitle.Name = "tboxTitle";
            this.tboxTitle.Size = new Size(209, 23);
            this.tboxTitle.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(64, 96);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(39, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // cmboxStatus
            // 
            this.cmboxStatus.Anchor = AnchorStyles.Right;
            this.cmboxStatus.FormattingEnabled = true;
            this.cmboxStatus.Location = new Point(123, 96);
            this.cmboxStatus.Name = "cmboxStatus";
            this.cmboxStatus.Size = new Size(209, 23);
            this.cmboxStatus.TabIndex = 2;
            // 
            // dateDeadline
            // 
            this.dateDeadline.Anchor = AnchorStyles.Right;
            this.dateDeadline.Location = new Point(123, 217);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new Size(209, 23);
            this.dateDeadline.TabIndex = 3;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new Point(50, 223);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new Size(53, 15);
            this.lblDeadline.TabIndex = 0;
            this.lblDeadline.Text = "Deadline";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new Point(36, 315);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(67, 15);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // tboxDescription
            // 
            this.tboxDescription.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            this.tboxDescription.Location = new Point(123, 315);
            this.tboxDescription.Multiline = true;
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new Size(209, 126);
            this.tboxDescription.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            this.lblHeader.Location = new Point(70, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new Size(228, 32);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Create Job Posting";
            // 
            // btnPost
            // 
            this.btnPost.Location = new Point(257, 449);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new Size(75, 29);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // lblExpLevel
            // 
            this.lblExpLevel.AutoSize = true;
            this.lblExpLevel.Location = new Point(9, 125);
            this.lblExpLevel.Name = "lblExpLevel";
            this.lblExpLevel.Size = new Size(94, 15);
            this.lblExpLevel.TabIndex = 0;
            this.lblExpLevel.Text = "Experience Level";
            // 
            // cmboxExpLevel
            // 
            this.cmboxExpLevel.Anchor = AnchorStyles.Right;
            this.cmboxExpLevel.FormattingEnabled = true;
            this.cmboxExpLevel.Location = new Point(123, 125);
            this.cmboxExpLevel.Name = "cmboxExpLevel";
            this.cmboxExpLevel.Size = new Size(209, 23);
            this.cmboxExpLevel.TabIndex = 2;
            // 
            // lblWorkMode
            // 
            this.lblWorkMode.AutoSize = true;
            this.lblWorkMode.Location = new Point(34, 154);
            this.lblWorkMode.Name = "lblWorkMode";
            this.lblWorkMode.Size = new Size(69, 15);
            this.lblWorkMode.TabIndex = 0;
            this.lblWorkMode.Text = "Work Mode";
            // 
            // cmboxWorkMode
            // 
            this.cmboxWorkMode.Anchor = AnchorStyles.Right;
            this.cmboxWorkMode.FormattingEnabled = true;
            this.cmboxWorkMode.Location = new Point(123, 154);
            this.cmboxWorkMode.Name = "cmboxWorkMode";
            this.cmboxWorkMode.Size = new Size(209, 23);
            this.cmboxWorkMode.TabIndex = 2;
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Location = new Point(51, 183);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new Size(52, 15);
            this.lblJobType.TabIndex = 0;
            this.lblJobType.Text = "Job Type";
            // 
            // cmboxJobType
            // 
            this.cmboxJobType.Anchor = AnchorStyles.Right;
            this.cmboxJobType.FormattingEnabled = true;
            this.cmboxJobType.Location = new Point(123, 183);
            this.cmboxJobType.Name = "cmboxJobType";
            this.cmboxJobType.Size = new Size(209, 23);
            this.cmboxJobType.TabIndex = 2;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new Point(70, 251);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new Size(33, 15);
            this.lblSkills.TabIndex = 0;
            this.lblSkills.Text = "Skills";
            // 
            // tboxSkills
            // 
            this.tboxSkills.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            this.tboxSkills.Location = new Point(123, 251);
            this.tboxSkills.Multiline = true;
            this.tboxSkills.Name = "tboxSkills";
            this.tboxSkills.Size = new Size(209, 58);
            this.tboxSkills.TabIndex = 4;
            // 
            // PostJobControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblHeader);
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
            this.Name = "PostJobControl";
            this.Size = new Size(370, 500);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox tboxTitle;
        private Label lblStatus;
        private ComboBox cmboxStatus;
        private DateTimePicker dateDeadline;
        private Label lblDeadline;
        private Label lblDescription;
        private TextBox tboxDescription;
        private Label lblHeader;
        private Button btnPost;
        private Label lblExpLevel;
        private ComboBox cmboxExpLevel;
        private Label lblWorkMode;
        private ComboBox cmboxWorkMode;
        private Label lblJobType;
        private ComboBox cmboxJobType;
        private Label lblSkills;
        private TextBox tboxSkills;
    }
}
