using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Employeemanagement.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              optionsBuilder.UseSqlServer("Server=ANAMIKAD;Database=DE_Database;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DepBudget).IsUnicode(false);

                entity.Property(e => e.DepLocation).IsUnicode(false);

                entity.Property(e => e.DepName).IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmpAddress).IsUnicode(false);

                entity.Property(e => e.EmpFirstName).IsUnicode(false);

                entity.Property(e => e.EmpLastName).IsUnicode(false);

                entity.Property(e => e.Empphno).IsUnicode(false);
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Phno).IsUnicode(false);

                entity.Property(e => e.Age).IsUnicode(false);
               
            }); 
           OnModelCreatingPartial(modelBuilder);
        }
      partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
