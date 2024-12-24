using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Command
{
    public class UpdateDepartmentCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
