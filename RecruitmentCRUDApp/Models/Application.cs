using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Application
    {
        // primary key
        public int appID { get; set; }

        // foreign keys
        public int jobseekerID { get; set; }
        public int vacancyID { get; set; }
        public int employerID { get; set; }

        public DateTime appDate { get; set; } = DateTime.Now;

        public virtual JobSeeker JobSeeker { get; set; }
        public virtual Vacancy Vacancy { get; set; }
        public virtual Employer Employer { get; set; }
    }
}
