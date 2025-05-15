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
            label2 = new Label();
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
            labelCreateAccMsg.Location = new Point(38, 9);
            labelCreateAccMsg.Name = "labelCreateAccMsg";
            labelCreateAccMsg.Size = new Size(721, 41);
            labelCreateAccMsg.TabIndex = 0;
            labelCreateAccMsg.Text = "Create an account to launch your professional career.";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.Location = new Point(249, 88);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Enter your full name";
            txtFullName.Size = new Size(298, 27);
            txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(249, 167);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email address";
            txtEmail.Size = new Size(298, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(249, 246);
            txtPassword.MaxLength = 255;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(298, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.Location = new Point(249, 325);
            txtConfirmPassword.MaxLength = 255;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Write your password again";
            txtConfirmPassword.Size = new Size(298, 27);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(249, 404);
            txtPhoneNumber.MaxLength = 20;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Enter your phone number";
            txtPhoneNumber.Size = new Size(298, 27);
            txtPhoneNumber.TabIndex = 5;
            // 
            // labelFullName
            // 
            labelFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(253, 65);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(76, 20);
            labelFullName.TabIndex = 7;
            labelFullName.Text = "Full Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(249, 223);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(253, 144);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(249, 381);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(108, 20);
            labelPhoneNumber.TabIndex = 10;
            labelPhoneNumber.Text = "Phone Number";
            // 
            // labelBirthDate
            // 
            labelBirthDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(249, 460);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(76, 20);
            labelBirthDate.TabIndex = 11;
            labelBirthDate.Text = "Birth Date";
            // 
            // labelConfPassword
            // 
            labelConfPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelConfPassword.AutoSize = true;
            labelConfPassword.Location = new Point(249, 302);
            labelConfPassword.Name = "labelConfPassword";
            labelConfPassword.Size = new Size(162, 20);
            labelConfPassword.TabIndex = 12;
            labelConfPassword.Text = "Confirm your password";
            // 
            // birthDate
            // 
            birthDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            birthDate.Location = new Point(249, 483);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(298, 27);
            birthDate.TabIndex = 6;
            // 
            // btnSignup
            // 
            btnSignup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSignup.Location = new Point(351, 600);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(94, 29);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // radioBtnJobseeker
            // 
            radioBtnJobseeker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioBtnJobseeker.AutoSize = true;
            radioBtnJobseeker.Checked = true;
            radioBtnJobseeker.Location = new Point(249, 544);
            radioBtnJobseeker.Name = "radioBtnJobseeker";
            radioBtnJobseeker.Size = new Size(101, 24);
            radioBtnJobseeker.TabIndex = 7;
            radioBtnJobseeker.TabStop = true;
            radioBtnJobseeker.Text = "Job Seeker";
            radioBtnJobseeker.UseVisualStyleBackColor = true;
            // 
            // radioBtnEmployer
            // 
            radioBtnEmployer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioBtnEmployer.AutoSize = true;
            radioBtnEmployer.Location = new Point(454, 544);
            radioBtnEmployer.Name = "radioBtnEmployer";
            radioBtnEmployer.Size = new Size(93, 24);
            radioBtnEmployer.TabIndex = 8;
            radioBtnEmployer.Text = "Employer";
            radioBtnEmployer.UseVisualStyleBackColor = true;
            // 
            // labelLoginMsg
            // 
            labelLoginMsg.Anchor = AnchorStyles.Bottom;
            labelLoginMsg.AutoSize = true;
            labelLoginMsg.Location = new Point(289, 658);
            labelLoginMsg.Name = "labelLoginMsg";
            labelLoginMsg.Size = new Size(178, 20);
            labelLoginMsg.TabIndex = 17;
            labelLoginMsg.Text = "Already have an account?";
            // 
            // linkLogin
            // 
            linkLogin.Anchor = AnchorStyles.Bottom;
            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(473, 658);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(50, 20);
            linkLogin.TabIndex = 10;
            linkLogin.TabStop = true;
            linkLogin.Text = "Log in";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // frmSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 707);
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
            Controls.Add(label2);
            Controls.Add(labelFullName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(labelCreateAccMsg);
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
        private Label label2;
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