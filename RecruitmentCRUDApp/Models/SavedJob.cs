using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SavedJob
    {
        // primary key
        public int saved_jobID { get; set; }

        // foreign keys
        public int jobseekerID { get; set; }
        public int vacancyID { get; set; }


        public DateTime saveDate { get; set; } = DateTime.Now;

        public virtual JobSeeker JobSeeker { get; set; }
        public virtual Vacancy Vacancy { get; set; }
    }
}
