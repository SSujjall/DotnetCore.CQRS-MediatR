using MediatR;

namespace DotnetCore.MediatR_testing.Features.Employees.Command
{
    public class DeleteEmployeeCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
