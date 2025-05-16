using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Employer
    {
        // foreign keys
        public int userID { get; set; }
        public int companyID { get; set; }

        public virtual User User { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
        public virtual ICollection<Application> ReceivedApplications { get; set; } = new List<Application>();
    }
}
