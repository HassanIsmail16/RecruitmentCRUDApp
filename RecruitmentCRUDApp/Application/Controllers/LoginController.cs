using DAL.Interfaces;
using Microsoft.IdentityModel.Tokens;
using Models;
using RecruitmentApplication.Core.Navigation;
using RecruitmentApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentApplication.Controllers
{
    internal class LoginController
    {
        private readonly frmLogin view;
        private readonly IUserRepository userRepository;

        public LoginController(IUserRepository userRepository, frmLogin view)
        {
            this.userRepository = userRepository;
            this.view = view;
            this.view.OnLogin += Login;
        }

        public async void Login(object sender, frmLogin.LoginEventArgs e)
        {
            if (e == null)
            {
                MessageBox.Show("Login error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.Email.IsNullOrEmpty())
            {
                MessageBox.Show("Email cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.Password.IsNullOrEmpty())
            {
                MessageBox.Show("Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool isPasswordCorrect = await userRepository.IsPasswordCorrect(e.Email, e.Password);
                if (isPasswordCorrect)
                {
                    User user = await userRepository.GetByEmailAsync(e.Email);
                    Session.Login(user);

                    // Update UI on the UI thread
                    view.Invoke((MethodInvoker) delegate
                    {
                        // Create the main form first
                        var mainForm = new MainForm();

                        // Show the main form before hiding/closing login form
                        mainForm.Show();

                        // Hide the login form without closing it
                        // This keeps the application running even if the login form is hidden
                        view.Hide();
                    });
                }
                else
                {
                    MessageBox.Show("Invalid email or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}