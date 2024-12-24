using DotnetCore.MediatR_testing.Models;

namespace DotnetCore.MediatR_testing.Services.Interface
{
    public interface IDepartmentRepository
    {
        Task<Department> AddDepartmentAsync(Department model);
        Task<int> DeleteDepartmentAsync(int id);
        Task<Department> GetDepartmentByIdAsync(int id);
        Task<List<Department>> GetDepartmentListAsync();
        Task<int> UpdateDepartmentAsync(Department model);
    }
}