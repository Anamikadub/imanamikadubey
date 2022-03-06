using Employeemanagement.Model;
using System;
using System.Collections.Generic;

namespace Employeemanagement.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private static List<Department> GenerateDepartmentData()
        {
            List<Department> departments = new()
            {
              new Department() { DepartmentId = 1, DepartmentName = "B.tech",DepartmentBudget = 1000,  DepartmentRating = 5, CreatedBy = 100, CreatedAt = DateTime.Now, UpdatedBy = 100, UpdatedAt = DateTime.Now, IsActive = true },
              new Department() { DepartmentId = 2, DepartmentName = "M.tech",DepartmentBudget = 20000, DepartmentRating = 3, CreatedBy = 200, CreatedAt = DateTime.Now, UpdatedBy = 200, UpdatedAt = DateTime.Now, IsActive = true },
              new Department() { DepartmentId = 3, DepartmentName = "BCA",   DepartmentBudget = 30000, DepartmentRating = 4, CreatedBy = 300, CreatedAt = DateTime.Now, UpdatedBy = 300, UpdatedAt = DateTime.Now, IsActive = true },
              new Department() { DepartmentId = 4, DepartmentName = "B.COM", DepartmentBudget = 40000, DepartmentRating = 6, CreatedBy = 400, CreatedAt = DateTime.Now, UpdatedBy = 300, UpdatedAt = DateTime.Now, IsActive = true },
              new Department() { DepartmentId = 5, DepartmentName = "MBA",   DepartmentBudget = 50000, DepartmentRating = 7, CreatedBy = 500, CreatedAt = DateTime.Now, UpdatedBy = 500, UpdatedAt = DateTime.Now, IsActive = true },
            };
          return departments;
        }
        public List<Department> GetDepartmentDetails()
        {
           List<Department> departments = GenerateDepartmentData();
           return departments.FindAll(item => item.IsActive);
        }
    }
}
