namespace RecruitmentApplication.Views
{
    partial class frmCreateCompany
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
            labelHeader = new Label();
            labelCompanyName = new Label();
            labelEmail = new Label();
            labelDescription = new Label();
            labelPhone = new Label();
            btnCancel = new Button();
            brnCreate = new Button();
            txtCompanyName = new TextBox();
            textPhone = new TextBox();
            textEmail = new TextBox();
            textDescription = new TextBox();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(110, 29);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(202, 32);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Create Company";
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Location = new Point(62, 93);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(42, 15);
            labelCompanyName.TabIndex = 1;
            labelCompanyName.Text = "Name:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(65, 147);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(34, 255);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(70, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(60, 201);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(44, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(163, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 39);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // brnCreate
            // 
            brnCreate.Location = new Point(244, 399);
            brnCreate.Name = "brnCreate";
            brnCreate.Size = new Size(75, 39);
            brnCreate.TabIndex = 6;
            brnCreate.Text = "Create";
            brnCreate.UseVisualStyleBackColor = true;
            brnCreate.Click += brnCreate_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(110, 90);
            txtCompanyName.MaxLength = 100;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PlaceholderText = "Company or organization name\n\n";
            txtCompanyName.Size = new Size(209, 23);
            txtCompanyName.TabIndex = 1;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(110, 198);
            textPhone.MaxLength = 20;
            textPhone.Name = "textPhone";
            textPhone.PlaceholderText = "e.g., +1 123 456 7890\n\n";
            textPhone.Size = new Size(209, 23);
            textPhone.TabIndex = 9;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(110, 144);
            textEmail.MaxLength = 100;
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "e.g., company@example.com\n\n";
            textEmail.Size = new Size(209, 23);
            textEmail.TabIndex = 2;
            // 
            // textDescription
            // 
            textDescription.Location = new Point(110, 252);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.PlaceholderText = "Briefly describe the company\n\n";
            textDescription.Size = new Size(209, 139);
            textDescription.TabIndex = 10;
            // 
            // frmCreateCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(344, 451);
            ControlBox = false;
            Controls.Add(textDescription);
            Controls.Add(textEmail);
            Controls.Add(textPhone);
            Controls.Add(txtCompanyName);
            Controls.Add(brnCreate);
            Controls.Add(btnCancel);
            Controls.Add(labelPhone);
            Controls.Add(labelDescription);
            Controls.Add(labelEmail);
            Controls.Add(labelCompanyName);
            Controls.Add(labelHeader);
            MaximumSize = new Size(360, 490);
            MinimumSize = new Size(360, 490);
            Name = "frmCreateCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Company Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private Label labelCompanyName;
        private Label labelEmail;
        private Label labelDescription;
        private Label labelPhone;
        private Button btnCancel;
        private Button brnCreate;
        private TextBox txtCompanyName;
        private TextBox textPhone;
        private TextBox textEmail;
        private TextBox textDescription;
    }
}