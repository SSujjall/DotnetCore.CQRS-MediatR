using DotnetCore.MediatR_testing.Data;
using DotnetCore.MediatR_testing.Models;
using DotnetCore.MediatR_testing.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore.MediatR_testing.Services
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _dbContext;
        public DepartmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Department> AddDepartmentAsync(Department model)
        {
            var result = await _dbContext.Department.AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteDepartmentAsync(int id)
        {
            var filteredData = _dbContext.Department.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.Department.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            var filteredData = _dbContext.Department.Where(x => x.Id == id).FirstOrDefault();
            return filteredData;
        }

        public async Task<List<Department>> GetDepartmentListAsync()
        {
            var result = await _dbContext.Department.ToListAsync();
            return result;
        }

        public async Task<int> UpdateDepartmentAsync(Department model)
        {
            _dbContext.Department.Update(model);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
