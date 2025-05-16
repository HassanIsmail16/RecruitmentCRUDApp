using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum UserType
    {
        JOB_SEEKER,
        EMPLOYER
    }
    internal class User
    {
        // primary key
        public int userID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public DateTime? birthDate { get; set; }
        public DateTime signupDate { get; set; } = DateTime.Now;

        public int? age
        {
            get
            {
                if (!birthDate.HasValue)
                {
                    return null;
                }

                var today = DateTime.Today;
                var age = today.Year - birthDate.Value.Year;

                if (birthDate.Value.Date > today.AddYears(-age))
                    age--;
                return age;
            }
        }
        public UserType type { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
        public virtual Employer Employer { get; set; }
    }
}
