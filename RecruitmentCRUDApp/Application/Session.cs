using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Session
    {
        public static int? CurrentUserId { get; set; }

        public static void Login(int userId)
        {
            CurrentUserId = userId;
        }

        public static void Logout()
        {
            CurrentUserId = null;
        }
        
        public static bool IsAuthenticated => CurrentUserId != null;

    }
}
