using DAL.Repositories;

namespace RecruitmentApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Create a shared database context
            var context = new RecruitmentContext();

            // Create repositories
            var userRepository = new UserRepository(context);
            var jobSeekerRepository = new JobSeekerRepository(context);
            var employerRepository = new EmployerRepository(context);

            // Create login form with properly initialized controller
            var loginForm = new Views.frmLogin();
            var signupForm = new Views.Auth.frmSignup();
            var loginController = new Controllers.LoginController(userRepository, loginForm);
            var signupController = new Controllers.SignUpController(userRepository, jobSeekerRepository, employerRepository, signupForm);

            Application.Run(signupForm);
        }
    }
}