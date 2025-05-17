namespace RecruitmentApplication.Views
{
    partial class EditJobForm
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
            btnCancel = new Button();
            btnSave = new Button();
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
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(191, 460);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(272, 460);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(125, 27);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(106, 32);
            lblHeader.TabIndex = 41;
            lblHeader.Text = "Edit Job";
            // 
            // tboxSkills
            // 
            tboxSkills.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tboxSkills.Location = new Point(138, 262);
            tboxSkills.Multiline = true;
            tboxSkills.Name = "tboxSkills";
            tboxSkills.Size = new Size(209, 58);
            tboxSkills.TabIndex = 40;
            // 
            // tboxDescription
            // 
            tboxDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tboxDescription.Location = new Point(138, 326);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(209, 126);
            tboxDescription.TabIndex = 39;
            // 
            // dateDeadline
            // 
            dateDeadline.Anchor = AnchorStyles.Right;
            dateDeadline.Location = new Point(138, 228);
            dateDeadline.Name = "dateDeadline";
            dateDeadline.Size = new Size(209, 23);
            dateDeadline.TabIndex = 38;
            // 
            // cmboxJobType
            // 
            cmboxJobType.Anchor = AnchorStyles.Right;
            cmboxJobType.FormattingEnabled = true;
            cmboxJobType.Location = new Point(138, 194);
            cmboxJobType.Name = "cmboxJobType";
            cmboxJobType.Size = new Size(209, 23);
            cmboxJobType.TabIndex = 36;
            // 
            // cmboxWorkMode
            // 
            cmboxWorkMode.Anchor = AnchorStyles.Right;
            cmboxWorkMode.FormattingEnabled = true;
            cmboxWorkMode.Location = new Point(138, 165);
            cmboxWorkMode.Name = "cmboxWorkMode";
            cmboxWorkMode.Size = new Size(209, 23);
            cmboxWorkMode.TabIndex = 35;
            // 
            // cmboxExpLevel
            // 
            cmboxExpLevel.Anchor = AnchorStyles.Right;
            cmboxExpLevel.FormattingEnabled = true;
            cmboxExpLevel.Location = new Point(138, 136);
            cmboxExpLevel.Name = "cmboxExpLevel";
            cmboxExpLevel.Size = new Size(209, 23);
            cmboxExpLevel.TabIndex = 37;
            // 
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Location = new Point(66, 194);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(53, 15);
            lblJobType.TabIndex = 25;
            lblJobType.Text = "Job Type";
            // 
            // cmboxStatus
            // 
            cmboxStatus.Anchor = AnchorStyles.Right;
            cmboxStatus.FormattingEnabled = true;
            cmboxStatus.Location = new Point(138, 107);
            cmboxStatus.Name = "cmboxStatus";
            cmboxStatus.Size = new Size(209, 23);
            cmboxStatus.TabIndex = 34;
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Location = new Point(85, 262);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(33, 15);
            lblSkills.TabIndex = 31;
            lblSkills.Text = "Skills";
            // 
            // lblWorkMode
            // 
            lblWorkMode.AutoSize = true;
            lblWorkMode.Location = new Point(49, 165);
            lblWorkMode.Name = "lblWorkMode";
            lblWorkMode.Size = new Size(69, 15);
            lblWorkMode.TabIndex = 30;
            lblWorkMode.Text = "Work Mode";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(51, 326);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 29;
            lblDescription.Text = "Description";
            // 
            // lblExpLevel
            // 
            lblExpLevel.AutoSize = true;
            lblExpLevel.Location = new Point(24, 136);
            lblExpLevel.Name = "lblExpLevel";
            lblExpLevel.Size = new Size(93, 15);
            lblExpLevel.TabIndex = 28;
            lblExpLevel.Text = "Experience Level";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(65, 234);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(53, 15);
            lblDeadline.TabIndex = 27;
            lblDeadline.Text = "Deadline";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(79, 107);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 26;
            lblStatus.Text = "Status";
            // 
            // tboxTitle
            // 
            tboxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tboxTitle.Location = new Point(138, 75);
            tboxTitle.Name = "tboxTitle";
            tboxTitle.Size = new Size(209, 23);
            tboxTitle.TabIndex = 33;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(89, 78);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Title";
            // 
            // EditJobForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 528);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Name = "EditJobForm";
            Text = "EditJobForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
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
    }
}