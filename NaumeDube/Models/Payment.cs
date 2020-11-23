using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaumeDube.Models
{
    public partial class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string EmployeeNumber { get; set; }
        public int DailyRate { get; set; }
        public int? HourlyRate { get; set; }
        public int? MonthlyIncome { get; set; }
        public int? MonthlyRate { get; set; }
        public int? PercentSalaryhike { get; set; }
        public int? PerformanceRating { get; set; }
    }
}
