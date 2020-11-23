using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaumeDube.Models
{
    public partial class Employee
    {
        [Key]
        public string EmployeeNumber { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Over18 { get; set; }
        public int? RelationshipSatisfaction { get; set; }
        public int? DistanceFromHome { get; set; }
    }
}
