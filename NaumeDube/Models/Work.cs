using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NaumeDube.Models
{
    public partial class Work
    {
        [Key]
        public int WorkId { get; set; }
        public int? EnvironmentSatisfaction { get; set; }
        public string OverTime { get; set; }
        public int? StandardHours { get; set; }
        public int? StockOptionLevel { get; set; }
        public int? TotalWorkingYears { get; set; }
        public int? WorkLifeBalance { get; set; }
    }
}
