using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Session
    {
        public static User CurrentUser { get; set; }

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout(User user)
        {
            CurrentUser = null;
        }
        
        public static bool IsAuthenticated => CurrentUser != null;

    }
}
