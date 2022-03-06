using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Services
{
   public interface IEmployeeService
    {
     public List<Employee> GetEmployeeDetails();
     public Employee GetEmployeeRecord(int employeeId);
     public bool UpdateEmployees(int EmpId);
   }
}
