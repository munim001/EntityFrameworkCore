using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ef_coreCodeFirstApproach.Models
{
    public class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Country> Country { get; set; }

        protected override  void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-TQFM6AI\\SQLEXPRESS;Database=CompanyDbDev;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // for employee and vehicle
            // Relationship configuration

            modelBuilder.Entity<Employee>().HasOne(x => x.Vehicle).WithOne(x => x.Employee).
                HasForeignKey<Employee>(x => x.VehicleId);

            // property configuration
            
            modelBuilder.Entity<Vehicle>(entity=>
                {

                    entity.Property(x => x.VId).HasColumnName("Id");

                    entity.Property(x => x.Name).HasColumnName("VehicleName");
                
                });


            //Entity Configuration......
            // primary key


            modelBuilder.Entity<Vehicle>().HasKey(x => x.VId);

            modelBuilder.Entity<EmployeeRole>().HasKey(t => new { t.EmployeeId, t.RoleId }); //composite primary key.

          
            // Relationship configuration for Many to Many Relationship

            modelBuilder.Entity<EmployeeRole>()
                .HasOne(t => t.Employee)
                .WithMany(t => t.EmployeeRole)
                .HasForeignKey(t => t.EmployeeId);


            modelBuilder.Entity<EmployeeRole>()
               .HasOne(t => t.Role)
               .WithMany(t => t.EmployeeRole)
               .HasForeignKey(t => t.RoleId);

        }
    }
}
