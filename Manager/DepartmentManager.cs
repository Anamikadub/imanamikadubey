using Employeemanagement.Model;
using Employeemanagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Manager
{
    public class DepartmentManager : IDepartmentManager
    {
      private readonly IDepartmentServices _departmentService;
      public DepartmentManager(IDepartmentServices departmentServices)
      {
       _departmentService = departmentServices;
      }
        public List<Department> GetDepartmentDetails()
        {
         return _departmentService.GetDepartmentDetails();
        }
    }
}
