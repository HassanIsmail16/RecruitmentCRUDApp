using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JobSeeker
    {
        // foreign key
        public int userID { get; set; }

        public string skills { get; set; }
        public byte[] resume { get; set; }
        public string experiences { get; set; }
        public string preferredLocation { get; set; }
        public string interests { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
        public virtual ICollection<SavedJob> SavedJobs { get; set; } = new List<SavedJob>();
    }
}
