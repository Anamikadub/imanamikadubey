using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Manager
{
   public interface IDepartmentManager
   {
        public List<Department> GetDepartmentDetails();
    }
}
