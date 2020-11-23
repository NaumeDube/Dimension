using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaumeDube.Models
{
    public partial class Job
    {
        [Key]
        public int JobId { get; set; }
        public string EmployeeNumber { get; set; }
        public int? JobInvolvement { get; set; }
        public string JobRole { get; set; }
        public int? JobLevel { get; set; }
        public int? JobSatisfaction { get; set; }
        public string BusinessTravel { get; set; }
    }
}
