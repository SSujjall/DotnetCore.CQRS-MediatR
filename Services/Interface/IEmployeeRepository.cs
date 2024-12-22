using DotnetCore.MediatR_testing.Models;

namespace DotnetCore.MediatR_testing.Services.Interface
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployeeListAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<int> UpdateEmployeeAsync(Employee employee);
        Task<int> DeleteEmployeeAsync(int id);
    }
}