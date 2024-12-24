using DotnetCore.MediatR_testing.Models;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Query
{
    public class GetDepartmentListQuery : IRequest<List<Department>>
    {
    }
}
