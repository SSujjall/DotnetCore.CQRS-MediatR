using DotnetCore.MediatR_testing.Features.Departments.Command;
using DotnetCore.MediatR_testing.Services.Interface;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Handlers
{
    public class DeleteDepartmentHandler(IDepartmentRepository _departmentRepository) : IRequestHandler<DeleteDepartmentCommand, int>
    {
        public async Task<int> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _departmentRepository.GetDepartmentByIdAsync(request.Id);
            if (department == null) return default;

            return await _departmentRepository.DeleteDepartmentAsync(request.Id);
        }
    }
}
