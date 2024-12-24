using DotnetCore.MediatR_testing.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore.MediatR_testing.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department) // Each Employee has one Department
                .WithMany(d => d.Employee) // Each Department can have many Employees
                .HasForeignKey(e => e.DepartmentId) // Foreign key in Employee table
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
