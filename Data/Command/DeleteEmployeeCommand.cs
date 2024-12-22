using MediatR;

namespace DotnetCore.MediatR_testing.Data.Command
{
    public class DeleteEmployeeCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
