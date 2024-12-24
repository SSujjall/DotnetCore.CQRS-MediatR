using DotnetCore.MediatR_testing.Models;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Query
{
    public class GetDepartmentByIdQuery : IRequest<Department>
    {
        public int Id { get; set; }
    }
}
