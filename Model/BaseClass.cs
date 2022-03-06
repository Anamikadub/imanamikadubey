using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Model
{
    public abstract class BaseClass
    {
     public int CreatedBy { get; set; }
     public DateTime CreatedAt { get; set; }
     public int UpdatedBy { get; set;}
     public DateTime UpdatedAt { get; set;}
     public bool IsActive { get; set; }
    }
}