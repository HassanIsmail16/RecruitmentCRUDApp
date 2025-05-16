using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Company
    {
        // primary key
        public int companyID { get; set; }

        // foreign key
        public int? managerID { get; set; }

        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public byte[] logo { get; set; }
        public string description { get; set; }


        public virtual Employer Manager { get; set; }
        public virtual ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
        public virtual ICollection<Employer> Employees { get; set; } = new List<Employer>();
    }
}
