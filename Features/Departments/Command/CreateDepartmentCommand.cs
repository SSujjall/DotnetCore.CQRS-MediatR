using DotnetCore.MediatR_testing.Models;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Departments.Command
{
    public class CreateDepartmentCommand : IRequest<Department>
    {
        // Not necessary to create constructor like in CreateEmployeeCommand.
        public string Name { get; set; }
    }
}
