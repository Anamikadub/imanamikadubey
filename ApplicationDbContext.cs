using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Employeemanagement
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer("Server=ANAMIKAD;Database=DE_Database");
         base.OnConfiguring(optionsBuilder);
        }
    }
}