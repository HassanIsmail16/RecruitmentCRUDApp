﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Models
{
    public partial class SavedJob
    {
        public int SavedJobId { get; set; }

        public DateTime? SaveDate { get; set; }

        public int JobseekerId { get; set; }

        public int VacancyId { get; set; }

        public virtual JobSeeker Jobseeker { get; set; }

        public virtual Vacancy Vacancy { get; set; }
    }
}
