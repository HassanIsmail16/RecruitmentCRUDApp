using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum StatusType
    {
        OPEN,
        CLOSED,
        DRAFT
    }
    public class Vacancy
    {
        // primary key
        public int vacancyID { get; set; }

        // foreign keys
        public int companyID { get; set; }
        public int employerID { get; set; }

        public string title { get; set; }
        public string description { get; set; }

        // required skills
        public string skills { get; set; }

        public StatusType status { get; set; } = StatusType.OPEN;

        // application deadline
        public DateTime? deadline { get; set; }

        public DateTime postDate { get; set; } = DateTime.Now;


        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
        public virtual ICollection<SavedJob> SavedByUsers { get; set; } = new List<SavedJob>();
    }
}
