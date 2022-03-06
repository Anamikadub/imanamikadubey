using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employeemanagement.Models
{
    public partial class Employee
    {
        public int? EmpId { get; set; }
        [StringLength(30)]
        public string EmpFirstName { get; set; }
        [StringLength(30)]
        public string EmpLastName { get; set; }
        public int? EmpAge { get; set; }
        [StringLength(30)]
        public string EmpAddress { get; set; }
        [StringLength(30)]
        public string Empphno { get; set; }
    }
}
