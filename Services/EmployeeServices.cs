using Employeemanagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Services
{
    public class EmployeeServices : IEmployeeService
    {
        public List<Employee> baseEmployeeList = new()
            {
                new Employee() { EmployeeId = 1, EmployeeAge = 27, EmployeeName = "Pankaj",  EmployeeSalary = 10000, CreatedBy = 100, CreatedAt = DateTime.Now, UpdatedBy = 100, UpdatedAt = DateTime.Now,  IsActive = true},
                new Employee() { EmployeeId = 2, EmployeeAge = 22, EmployeeName = "Anamika", EmployeeSalary = 15000, CreatedBy = 200, CreatedAt = DateTime.Now, UpdatedBy = 200, UpdatedAt = DateTime.Now,  IsActive = true },
                new Employee() { EmployeeId = 3, EmployeeAge = 25, EmployeeName = "Aishwar", EmployeeSalary = 20000, CreatedBy = 300, CreatedAt = DateTime.Now, UpdatedBy = 300, UpdatedAt = DateTime.Now,  IsActive = true },
                new Employee() { EmployeeId = 4, EmployeeAge = 28, EmployeeName = "aditya",  EmployeeSalary = 30000, CreatedBy = 400, CreatedAt = DateTime.Now, UpdatedBy = 400, UpdatedAt = DateTime.Now,  IsActive = true },
                new Employee() { EmployeeId = 5, EmployeeAge = 35, EmployeeName = "Rahul",   EmployeeSalary = 40000, CreatedBy = 500, CreatedAt = DateTime.Now, UpdatedBy = 500, UpdatedAt = DateTime.Now,  IsActive = false },
                new Employee() { EmployeeId = 6, EmployeeAge = 55, EmployeeName = "Manan",   EmployeeSalary = 50000, CreatedBy = 600, CreatedAt = DateTime.Now, UpdatedBy = 600, UpdatedAt = DateTime.Now,  IsActive = false },
                new Employee() { EmployeeId = 7, EmployeeAge = 22, EmployeeName = "Akshit",  EmployeeSalary = 60000, CreatedBy = 700, CreatedAt = DateTime.Now, UpdatedBy = 700, UpdatedAt = DateTime.Now,  IsActive = true },
                new Employee() { EmployeeId = 8, EmployeeAge = 33, EmployeeName = "Sudhans", EmployeeSalary = 70000 ,CreatedBy = 750, CreatedAt = DateTime.Now, UpdatedBy = 750, UpdatedAt = DateTime.Now , IsActive = false },
                new Employee() { EmployeeId = 9, EmployeeAge = 29, EmployeeName = "pallavi", EmployeeSalary = 25000, CreatedBy = 800, CreatedAt = DateTime.Now, UpdatedBy = 800, UpdatedAt = DateTime.Now,  IsActive = true },
                new Employee() { EmployeeId = 10, EmployeeAge = 30,EmployeeName = "Pragya",  EmployeeSalary = 12000, CreatedBy = 900, CreatedAt = DateTime.Now, UpdatedBy = 900, UpdatedAt = DateTime.Now,  IsActive = true },  
            };

        public List<Employee> GetEmployeeDetails()
        {
          return baseEmployeeList.FindAll(item => item.IsActive);  
        }
        public Employee GetEmployeeRecord(int employeeId)
        {
          return baseEmployeeList.Find(item => item.EmployeeId == employeeId && item.IsActive);
        }
        public bool UpdateEmployees(int EmpId)
        {
            var employeeToUpdate = baseEmployeeList.Find(item => item.EmployeeId == EmpId);
            if(employeeToUpdate is not null)
            {
               employeeToUpdate.IsActive = false;
            }
            return true;
        }
    }
}
