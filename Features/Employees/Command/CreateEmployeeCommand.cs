using DotnetCore.MediatR_testing.Models;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Employees.Command
{
    public class CreateEmployeeCommand : IRequest<Employee>
    {
        public CreateEmployeeCommand(string name, string address, string mobileNumber, int departmentId)
        {
            Name = name;
            Address = address;
            MobileNumber = mobileNumber;
            DepartmentId = departmentId;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public int DepartmentId { get; set; }
    }
}
