using DotnetCore.MediatR_testing.Features.Departments.Query;
using DotnetCore.MediatR_testing.Models;
using DotnetCore.MediatR_testing.Services.Interface;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Handlers
{
    public class GetDepartmentListHandler(IDepartmentRepository _departmentRepository) : IRequestHandler<GetDepartmentListQuery, List<Department>>
    {
        public Task<List<Department>> Handle(GetDepartmentListQuery request, CancellationToken cancellationToken)
        {
            return _departmentRepository.GetDepartmentListAsync();
        }
    }
}
