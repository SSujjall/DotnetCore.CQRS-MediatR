using DotnetCore.MediatR_testing.Data;
using DotnetCore.MediatR_testing.Models;
using DotnetCore.MediatR_testing.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore.MediatR_testing.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;
        public EmployeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            var result = _dbContext.Employees.Add(employee);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteEmployeeAsync(int id)
        {
            var filteredData = _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.Employees.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var result = _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public async Task<List<Employee>> GetEmployeeListAsync()
        {
            var result = await _dbContext.Employees.ToListAsync();
            return result;
        }

        public async Task<int> UpdateEmployeeAsync(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
