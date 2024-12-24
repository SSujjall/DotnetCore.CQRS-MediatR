using DotnetCore.MediatR_testing.Features.Departments.Command;
using DotnetCore.MediatR_testing.Services.Interface;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Handlers
{
    public class UpdateDepartmentHandler(IDepartmentRepository _departmentRepository) : IRequestHandler<UpdateDepartmentCommand, int>
    {
        public async Task<int> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _departmentRepository.GetDepartmentByIdAsync(request.Id);
            if (department == null) return default;
            
            department.Name = request.Name;
            return await _departmentRepository.UpdateDepartmentAsync(department);
        }
    }
}
