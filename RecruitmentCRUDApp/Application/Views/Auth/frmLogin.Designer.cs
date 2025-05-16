namespace RecruitmentApplication.Views
{
    partial class frmLogin
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
            this.labelLogin = new Label();
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.linkSignup = new LinkLabel();
            this.labelEmail = new Label();
            this.btnLogin = new Button();
            this.labelPassword = new Label();
            this.labelSignupMsg = new Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point,  0);
            this.labelLogin.Location = new Point(40, 15);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new Size(566, 32);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Welcome back! Log in to continue your career path.";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.txtEmail.Location = new Point(220, 98);
            this.txtEmail.Margin = new Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter your email address";
            this.txtEmail.Size = new Size(256, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.txtPassword.Location = new Point(220, 177);
            this.txtPassword.Margin = new Padding(3, 2, 3, 2);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Enter your password";
            this.txtPassword.Size = new Size(256, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // linkSignup
            // 
            this.linkSignup.Anchor = AnchorStyles.Bottom;
            this.linkSignup.AutoSize = true;
            this.linkSignup.Location = new Point(386, 268);
            this.linkSignup.Name = "linkSignup";
            this.linkSignup.Size = new Size(47, 15);
            this.linkSignup.TabIndex = 4;
            this.linkSignup.TabStop = true;
            this.linkSignup.Text = "Sign up";
            this.linkSignup.LinkClicked += this.linkSignup_LinkClicked;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(220, 81);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(36, 15);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.btnLogin.Location = new Point(306, 219);
            this.btnLogin.Margin = new Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(82, 22);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += this.btnLogin_Click;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new Point(220, 160);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new Size(57, 15);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // labelSignupMsg
            // 
            this.labelSignupMsg.Anchor = AnchorStyles.Bottom;
            this.labelSignupMsg.AutoSize = true;
            this.labelSignupMsg.Location = new Point(238, 268);
            this.labelSignupMsg.Name = "labelSignupMsg";
            this.labelSignupMsg.Size = new Size(131, 15);
            this.labelSignupMsg.TabIndex = 8;
            this.labelSignupMsg.Text = "Don't have an account?";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(700, 338);
            this.Controls.Add(this.labelSignupMsg);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.linkSignup);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelLogin);
            this.Margin = new Padding(3, 2, 3, 2);
            this.MinimumSize = new Size(527, 310);
            this.Name = "frmLogin";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private LinkLabel linkSignup;
        private Label labelEmail;
        private Button btnLogin;
        private Label labelPassword;
        private Label labelSignupMsg;
    }
}