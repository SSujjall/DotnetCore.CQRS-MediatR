using DotnetCore.MediatR_testing.Models;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Employees.Query
{
    public class GetEmployeeListQuery : IRequest<List<Employee>>
    {
    }
}
