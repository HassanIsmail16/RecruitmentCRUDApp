using DAL.Interfaces;
using Microsoft.IdentityModel.Tokens;
using RecruitmentApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApplication.Controllers
{
    internal class LoginController
    {
        frmLogin view;
        IUserRepository userRepository;

        public LoginController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void BindView(frmLogin view)
        {
            this.view = view;
            this.view.OnLogin += Login;
        }

        public void Login(object sender, frmLogin.LoginEventArgs e)
        {
            if (e == null)
            {
                return; // TODO: display errors here
            }

            if (e.Email.IsNullOrEmpty())
            {
                return; // TODO: display error
            }

            if (e.Password.IsNullOrEmpty())
            {
                return; // TODO: display error
            }

            if (userRepository.IsPasswordCorrect(e.Email, e.Password).Result)
            {
                // TODO: create session
            }
        }
    }
}
