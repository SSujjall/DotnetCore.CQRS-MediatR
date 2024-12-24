using DotnetCore.MediatR_testing.Models;
using MediatR;

namespace DotnetCore.MediatR_testing.Features.Employees.Command
{
    public class UpdateEmployeeCommand : IRequest<int>
    {
        public UpdateEmployeeCommand(int id, string name, string address, string mobileNumber, int departmentId)
        {
            Id = id;
            Name = name;
            Address = address;
            MobileNumber = mobileNumber;
            DepartmentId = departmentId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public int DepartmentId { get; set; }
    }
}
