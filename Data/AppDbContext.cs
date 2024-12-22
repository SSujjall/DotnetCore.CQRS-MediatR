using DotnetCore.MediatR_testing.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore.MediatR_testing.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
