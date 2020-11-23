using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaumeDube.Models
{
    public partial class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string EmployeeNumber { get; set; }
        public int? NumCompaniesWorked { get; set; }
        public int? TrainingTimesLastYear { get; set; }
        public int? YearsAtCompany { get; set; }
        public int? YearsInCurrentRole { get; set; }
        public int? YearsSinceLastPromotion { get; set; }
        public int? YearsWithCurrManager { get; set; }
    }
}
