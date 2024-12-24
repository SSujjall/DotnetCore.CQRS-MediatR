using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Command
{
    public class DeleteDepartmentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
