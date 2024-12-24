using DotnetCore.MediatR_testing.Features.Departments.Query;
using DotnetCore.MediatR_testing.Models;
using DotnetCore.MediatR_testing.Services.Interface;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Handlers
{
    public class GetDepartmentHandler(IDepartmentRepository _departmentRepository) : IRequestHandler<GetDepartmentByIdQuery, Department>
    {
        public async Task<Department> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            return await _departmentRepository.GetDepartmentByIdAsync(request.Id);
        }
    }
}
