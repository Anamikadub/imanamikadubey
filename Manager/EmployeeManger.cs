using Employeemanagement.Model;
using Employeemanagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Manager
{
    public class EmployeeManger : IEmployeemanager
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeManger(IEmployeeService employeeServices)
        {
            _employeeService = employeeServices;
        }
        public List<Employee> GetEmployeeDetails()
        {
          return _employeeService.GetEmployeeDetails();
        }
        public Employee GetEmployeeRecord(int employeeId)
        {
          return _employeeService.GetEmployeeRecord(employeeId);
        }
        public bool UpdateEmployees(int EmpId)
        {
          return _employeeService.UpdateEmployees(EmpId);
        }
    }
}