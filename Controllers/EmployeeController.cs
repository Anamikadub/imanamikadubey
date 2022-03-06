using Employeemanagement.Manager;
using Employeemanagement.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeemanager _employeeManager;
         public EmployeeController(IEmployeemanager employeeManger)
         {
           _employeeManager = employeeManger;
         }
        [Route("GetEmployeeDetails")]
        [HttpGet]
        public List<Employee> GetEmployeeDetails()
        {
         return _employeeManager.GetEmployeeDetails();
        }
        [Route("GetEmployeeRecord")]
        [HttpGet]
        public Employee GetEmployeeRecord(int employeeId)
        {
          return _employeeManager.GetEmployeeRecord(employeeId);
        }
        [Route("UpdateEmployees")]
        [HttpGet]
        public bool UpdateEmployees(int EmpId)
        {
            return _employeeManager.UpdateEmployees(EmpId);
        }
    }
}
