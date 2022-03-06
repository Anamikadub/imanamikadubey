using Employeemanagement.Manager;
using Employeemanagement.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentManager _departmentmanager;
        public DepartmentController(IDepartmentManager DepartmentManager)
        {
            _departmentmanager = DepartmentManager;
        }
        [Route("GetDepartmentDetails")]
        [HttpGet]
        public List<Department> GetDepartmentDetails()
        {
            return _departmentmanager.GetDepartmentDetails();
        }
    }
}
