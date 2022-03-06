using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employeemanagement.Models
{
    public partial class Department
    {
        public int? DepNo { get; set; }
        [StringLength(30)]
        public string DepName { get; set; }
        [StringLength(30)]
        public string DepBudget { get; set; }
        [StringLength(30)]
        public string DepLocation { get; set; }
    }
}
