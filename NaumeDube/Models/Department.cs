using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaumeDube.Models
{
    public partial class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentInfo { get; set; }
        public int? Education { get; set; }
        public string EducationField { get; set; }
    }
}
