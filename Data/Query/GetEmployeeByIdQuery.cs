using DotnetCore.MediatR_testing.Models;
using MediatR;

namespace DotnetCore.MediatR_testing.Data.Query
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
