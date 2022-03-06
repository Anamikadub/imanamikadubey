using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Model
{
    public class Department :BaseClass
    {
       public int DepartmentId {get; set;}
       public string DepartmentName {get; set;}
       public int DepartmentBudget {get; set;}
       public int DepartmentRating {get; set;}
       public bool IsDepartmentHighBudget { get {return DepartmentBudget > 30000; } set { } }
       public bool IsDepartmentHighRated { get { return DepartmentRating > 4; } set { } }
    }
}
