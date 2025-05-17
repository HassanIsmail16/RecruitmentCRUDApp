using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using RecruitmentApplication.Views;

namespace RecruitmentApplication.Views
{
    partial class JobDetailsForm
    {
        private int jobId;
        public JobDetailsForm(int jobId)
        {
            this.jobId = jobId;
        }

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
            lblCompanyName = new Label();
            tboxSkills = new TextBox();
            tboxDescription = new TextBox();
            dateDeadline = new DateTimePicker();
            lblJobType = new Label();
            lblSkills = new Label();
            lblWorkMode = new Label();
            lblDescription = new Label();
            lblExpLevel = new Label();
            lblDeadline = new Label();
            lblStatus = new Label();
            lblTitle = new Label();
            btnApply = new Button();
            btnCancel = new Button();
            lblHeader = new Label();
            tboxStatus = new TextBox();
            tboxExpLevel = new TextBox();
            tboxWorkMode = new TextBox();
            tboxJobType = new TextBox();
            tboxTitle = new TextBox();
            SuspendLayout();
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(46, 36);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(38, 15);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "label1";
            lblCompanyName.Click += lblCompanyName_Click;
            // 
            // tboxSkills
            // 
            tboxSkills.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tboxSkills.Location = new Point(118, 270);
            tboxSkills.Multiline = true;
            tboxSkills.Name = "tboxSkills";
            tboxSkills.ReadOnly = true;
            tboxSkills.Size = new Size(209, 58);
            tboxSkills.TabIndex = 19;
            // 
            // tboxDescription
            // 
            tboxDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tboxDescription.Location = new Point(118, 334);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.ReadOnly = true;
            tboxDescription.Size = new Size(209, 126);
            tboxDescription.TabIndex = 20;
            // 
            // dateDeadline
            // 
            dateDeadline.Anchor = AnchorStyles.Right;
            dateDeadline.Location = new Point(118, 236);
            dateDeadline.Name = "dateDeadline";
            dateDeadline.Size = new Size(209, 23);
            dateDeadline.TabIndex = 18;
            // 
            // lblJobType
            // 
            lblJobType.AutoSize = true;
            lblJobType.Location = new Point(46, 202);
            lblJobType.Name = "lblJobType";
            lblJobType.Size = new Size(53, 15);
            lblJobType.TabIndex = 5;
            lblJobType.Text = "Job Type";
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Location = new Point(65, 270);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(33, 15);
            lblSkills.TabIndex = 6;
            lblSkills.Text = "Skills";
            // 
            // lblWorkMode
            // 
            lblWorkMode.AutoSize = true;
            lblWorkMode.Location = new Point(29, 173);
            lblWorkMode.Name = "lblWorkMode";
            lblWorkMode.Size = new Size(69, 15);
            lblWorkMode.TabIndex = 7;
            lblWorkMode.Text = "Work Mode";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(31, 334);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // lblExpLevel
            // 
            lblExpLevel.AutoSize = true;
            lblExpLevel.Location = new Point(4, 144);
            lblExpLevel.Name = "lblExpLevel";
            lblExpLevel.Size = new Size(93, 15);
            lblExpLevel.TabIndex = 9;
            lblExpLevel.Text = "Experience Level";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(45, 242);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(53, 15);
            lblDeadline.TabIndex = 10;
            lblDeadline.Text = "Deadline";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(59, 115);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(69, 86);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Title";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(252, 466);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 29);
            btnApply.TabIndex = 21;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(171, 466);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(171, 19);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(140, 32);
            lblHeader.TabIndex = 22;
            lblHeader.Text = "Job Details";
            // 
            // tboxStatus
            // 
            tboxStatus.Location = new Point(118, 115);
            tboxStatus.Name = "tboxStatus";
            tboxStatus.Size = new Size(209, 23);
            tboxStatus.TabIndex = 23;
            // 
            // tboxExpLevel
            // 
            tboxExpLevel.Location = new Point(118, 144);
            tboxExpLevel.Name = "tboxExpLevel";
            tboxExpLevel.Size = new Size(209, 23);
            tboxExpLevel.TabIndex = 24;
            // 
            // tboxWorkMode
            // 
            tboxWorkMode.Location = new Point(118, 173);
            tboxWorkMode.Name = "tboxWorkMode";
            tboxWorkMode.Size = new Size(209, 23);
            tboxWorkMode.TabIndex = 25;
            // 
            // tboxJobType
            // 
            tboxJobType.Location = new Point(118, 202);
            tboxJobType.Name = "tboxJobType";
            tboxJobType.Size = new Size(209, 23);
            tboxJobType.TabIndex = 26;
            // 
            // tboxTitle
            // 
            tboxTitle.Location = new Point(118, 86);
            tboxTitle.Name = "tboxTitle";
            tboxTitle.Size = new Size(209, 23);
            tboxTitle.TabIndex = 27;
            // 
            // JobDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 507);
            Controls.Add(tboxTitle);
            Controls.Add(tboxJobType);
            Controls.Add(tboxWorkMode);
            Controls.Add(tboxExpLevel);
            Controls.Add(tboxStatus);
            Controls.Add(lblHeader);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(tboxSkills);
            Controls.Add(tboxDescription);
            Controls.Add(dateDeadline);
            Controls.Add(lblJobType);
            Controls.Add(lblSkills);
            Controls.Add(lblWorkMode);
            Controls.Add(lblDescription);
            Controls.Add(lblExpLevel);
            Controls.Add(lblDeadline);
            Controls.Add(lblStatus);
            Controls.Add(lblTitle);
            Controls.Add(lblCompanyName);
            Name = "JobDetailsForm";
            Text = "JobDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCompanyName;
        private TextBox tboxSkills;
        private TextBox tboxDescription;
        private DateTimePicker dateDeadline;
        private Label lblJobType;
        private Label lblSkills;
        private Label lblWorkMode;
        private Label lblDescription;
        private Label lblExpLevel;
        private Label lblDeadline;
        private Label lblStatus;
        private Label lblTitle;
        private Button btnApply;
        private Button btnCancel;
        private Label lblHeader;
        private TextBox tboxStatus;
        private TextBox tboxExpLevel;
        private TextBox tboxWorkMode;
        private TextBox tboxJobType;
        private TextBox tboxTitle;
    }
}