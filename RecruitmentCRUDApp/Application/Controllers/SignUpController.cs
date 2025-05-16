using DAL.Interfaces;
using Microsoft.IdentityModel.Tokens;
using RecruitmentApplication.Views.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Threading.Tasks;

namespace RecruitmentApplication.Controllers
{
    internal class SignUpController
    {
        frmSignup view;
        IUserRepository userRepository;
        IJobSeekerRepository jobSeekerRepository;
        IEmployerRepository employerRepository;

        public SignUpController(IUserRepository userRepository,
            IJobSeekerRepository jobSeekerRepository,
            IEmployerRepository employerRepository)
        {
            this.userRepository = userRepository;
            this.jobSeekerRepository = jobSeekerRepository;
            this.employerRepository = employerRepository;
        }

        public void BindView(frmSignup view)
        {
            this.view = view;
            this.view.OnSignUp += SignUp;
        }

        public void SignUp(object sender, frmSignup.SignUpEventArgs e)
        {
            if (e == null)
            {
                return;
            }

            if (e.FullName.IsNullOrEmpty())
            {
                return;
            }

            if (e.Email.IsNullOrEmpty())
            {
                return;
            }

            if (e.Password.IsNullOrEmpty())
            {
                return;
            }

            if (e.ConfirmPassword != e.Password)
            {
                return;
            }

            if (e.UserType.IsNullOrEmpty())
            {
                return;
            }

            if (userRepository.GetByEmailAsync(e.Email).Result != null)
            {
                return;
            }

            User newUser = new User
            {
                Name = e.FullName, Email = e.Email, Password = e.Password, Phone = e.PhoneNumber, BirthDate = e.BirthDate, SignupDate = DateTime.Now, UserType = e.UserType
            };

            userRepository.AddAsync(newUser);

            // TODO: add job seeker and employer insertion
        }
    }
}
