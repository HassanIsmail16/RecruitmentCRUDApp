﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Models
{
    public partial class JobSeeker
    {
        public int UserId { get; set; }

        public string Skills { get; set; }

        public byte[] Resume { get; set; }

        public string PreferredLoc { get; set; }

        public string Interests { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();

        public virtual ICollection<SavedJob> SavedJobs { get; set; } = new List<SavedJob>();

        public virtual User User { get; set; }
    }
}
