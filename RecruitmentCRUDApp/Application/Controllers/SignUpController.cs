using DAL.Interfaces;
using Microsoft.IdentityModel.Tokens;
using RecruitmentApplication.Views.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RecruitmentApplication.Controllers
{
    internal class SignUpController
    {
        private frmSignup view;
        private readonly IUserRepository userRepository;
        private readonly IJobSeekerRepository jobSeekerRepository;
        private readonly IEmployerRepository employerRepository;

        public SignUpController(IUserRepository userRepository,
            IJobSeekerRepository jobSeekerRepository,
            IEmployerRepository employerRepository,
            frmSignup view)
        {
            this.userRepository = userRepository;
            this.jobSeekerRepository = jobSeekerRepository;
            this.employerRepository = employerRepository;
            BindView(view);
        }

        public void BindView(frmSignup view)
        {
            this.view = view;
            this.view.OnSignUp += SignUp;
        }

        public async void SignUp(object sender, frmSignup.SignUpEventArgs e)
        {
            if (e == null)
            {
                MessageBox.Show("Signup error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.FullName.IsNullOrEmpty())
            {
                MessageBox.Show("Full name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (e.ConfirmPassword != e.Password)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.UserType.IsNullOrEmpty())
            {
                MessageBox.Show("User type must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (await userRepository.GetByEmailAsync(e.Email) != null)
            {
                MessageBox.Show("Email is already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                User newUser = new User
                {
                    Name = e.FullName,
                    Email = e.Email,
                    Password = e.Password,
                    Phone = e.PhoneNumber,
                    BirthDate = e.BirthDate,
                    SignupDate = DateTime.Now,
                    UserType = e.UserType
                };

                int userId = await userRepository.AddAsync(newUser);
                Debug.WriteLine($"user id is {userId}");

                if (e.UserType == "JobSeeker")
                {
                    await jobSeekerRepository.AddAsync(new JobSeeker
                    {
                        UserId = userId,
                    });
                }
                else if (e.UserType == "Employer")
                {
                    await employerRepository.AddAsync(new Employer
                    {
                        UserId = userId,
                    });
                }

                MessageBox.Show("Registration successful! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                view.Invoke((MethodInvoker) delegate
                {
                    view.Hide();
                    var loginForm = new Views.frmLogin();
                    var loginController = new LoginController(userRepository, loginForm);
                    loginForm.Show();
                    view.Close();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}