using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Model
{
    public class Employee : BaseClass
    {
        public int EmployeeId { get; set;}
        public string EmployeeName { get; set;}
        public int EmployeeAge { get; set;}
        public int EmployeeSalary { get ; set;}
        public bool IsEmployeeAdult { get { return EmployeeAge > 18; } set { } }
        public bool IsTDSApplicable { get { return EmployeeSalary > 30000; } set { } }
    }
}
