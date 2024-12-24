using DotnetCore.MediatR_testing.Features.Departments.Command;
using DotnetCore.MediatR_testing.Models;
using DotnetCore.MediatR_testing.Services.Interface;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Handlers
{
    public class CreateDepartmentHandler(IDepartmentRepository _departmentRepository) : IRequestHandler<CreateDepartmentCommand, Department>
    {
        public async Task<Department> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var departmentModel = new Department
            {
                Name = request.Name,
            };

            return await _departmentRepository.AddDepartmentAsync(departmentModel);
        }
    }
}
