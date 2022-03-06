using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Services
{
   public interface IDepartmentServices
   {
     public List<Department> GetDepartmentDetails();
   }
}
