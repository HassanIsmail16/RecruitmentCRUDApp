namespace RecruitmentApplication.Views.Auth
{
    partial class frmSignup
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
            labelCreateAccMsg = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            labelFullName = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            labelPhoneNumber = new Label();
            labelBirthDate = new Label();
            labelConfPassword = new Label();
            birthDate = new DateTimePicker();
            btnSignup = new Button();
            radioBtnJobseeker = new RadioButton();
            radioBtnEmployer = new RadioButton();
            labelLoginMsg = new Label();
            linkLogin = new LinkLabel();
            SuspendLayout();
            // 
            // labelCreateAccMsg
            // 
            labelCreateAccMsg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCreateAccMsg.AutoSize = true;
            labelCreateAccMsg.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCreateAccMsg.Location = new Point(33, 7);
            labelCreateAccMsg.Name = "labelCreateAccMsg";
            labelCreateAccMsg.Size = new Size(582, 32);
            labelCreateAccMsg.TabIndex = 0;
            labelCreateAccMsg.Text = "Create an account to launch your professional career.";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.Location = new Point(218, 66);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter your full name";
            txtFullName.Size = new Size(261, 23);
            txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(218, 125);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email address";
            txtEmail.Size = new Size(261, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(218, 184);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(261, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.Location = new Point(218, 244);
            txtConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            txtConfirmPassword.MaxLength = 255;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Write your password again";
            txtConfirmPassword.Size = new Size(261, 23);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(218, 303);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.MaxLength = 20;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Enter your phone number";
            txtPhoneNumber.Size = new Size(261, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // labelFullName
            // 
            labelFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(221, 49);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(61, 15);
            labelFullName.TabIndex = 7;
            labelFullName.Text = "Full Name";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(218, 167);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(221, 108);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(218, 286);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(88, 15);
            labelPhoneNumber.TabIndex = 10;
            labelPhoneNumber.Text = "Phone Number";
            // 
            // labelBirthDate
            // 
            labelBirthDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(218, 345);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(59, 15);
            labelBirthDate.TabIndex = 11;
            labelBirthDate.Text = "Birth Date";
            // 
            // labelConfPassword
            // 
            labelConfPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelConfPassword.AutoSize = true;
            labelConfPassword.Location = new Point(218, 226);
            labelConfPassword.Name = "labelConfPassword";
            labelConfPassword.Size = new Size(131, 15);
            labelConfPassword.TabIndex = 12;
            labelConfPassword.Text = "Confirm your password";
            // 
            // birthDate
            // 
            birthDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            birthDate.Location = new Point(218, 362);
            birthDate.Margin = new Padding(3, 2, 3, 2);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(261, 23);
            birthDate.TabIndex = 6;
            // 
            // btnSignup
            // 
            btnSignup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSignup.Location = new Point(307, 450);
            btnSignup.Margin = new Padding(3, 2, 3, 2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(82, 22);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // radioBtnJobseeker
            // 
            radioBtnJobseeker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioBtnJobseeker.AutoSize = true;
            radioBtnJobseeker.Checked = true;
            radioBtnJobseeker.Location = new Point(218, 408);
            radioBtnJobseeker.Margin = new Padding(3, 2, 3, 2);
            radioBtnJobseeker.Name = "radioBtnJobseeker";
            radioBtnJobseeker.Size = new Size(80, 19);
            radioBtnJobseeker.TabIndex = 7;
            radioBtnJobseeker.TabStop = true;
            radioBtnJobseeker.Text = "Job Seeker";
            radioBtnJobseeker.UseVisualStyleBackColor = true;
            // 
            // radioBtnEmployer
            // 
            radioBtnEmployer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioBtnEmployer.AutoSize = true;
            radioBtnEmployer.Location = new Point(397, 408);
            radioBtnEmployer.Margin = new Padding(3, 2, 3, 2);
            radioBtnEmployer.Name = "radioBtnEmployer";
            radioBtnEmployer.Size = new Size(75, 19);
            radioBtnEmployer.TabIndex = 8;
            radioBtnEmployer.Text = "Employer";
            radioBtnEmployer.UseVisualStyleBackColor = true;
            // 
            // labelLoginMsg
            // 
            labelLoginMsg.Anchor = AnchorStyles.Bottom;
            labelLoginMsg.AutoSize = true;
            labelLoginMsg.Location = new Point(253, 494);
            labelLoginMsg.Name = "labelLoginMsg";
            labelLoginMsg.Size = new Size(142, 15);
            labelLoginMsg.TabIndex = 17;
            labelLoginMsg.Text = "Already have an account?";
            // 
            // linkLogin
            // 
            linkLogin.Anchor = AnchorStyles.Bottom;
            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(414, 494);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(40, 15);
            linkLogin.TabIndex = 10;
            linkLogin.TabStop = true;
            linkLogin.Text = "Log in";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // frmSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 530);
            Controls.Add(linkLogin);
            Controls.Add(labelLoginMsg);
            Controls.Add(radioBtnEmployer);
            Controls.Add(radioBtnJobseeker);
            Controls.Add(btnSignup);
            Controls.Add(birthDate);
            Controls.Add(labelConfPassword);
            Controls.Add(labelBirthDate);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelFullName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(labelCreateAccMsg);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCreateAccMsg;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtPhoneNumber;
        private Label labelFullName;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelPhoneNumber;
        private Label labelBirthDate;
        private Label labelConfPassword;
        private DateTimePicker birthDate;
        private Button btnSignup;
        private RadioButton radioBtnJobseeker;
        private RadioButton radioBtnEmployer;
        private Label labelLoginMsg;
        private LinkLabel linkLogin;
    }
}