using DotnetCore.MediatR_testing.Models;
using MediatR;

namespace DotnetCore.MediatR_testing.Data.Command
{
    public class CreateEmployeeCommand : IRequest<Employee>
    {
        public CreateEmployeeCommand(string name, string address, string mobileNumber)
        {
            Name = name;
            Address = address;
            MobileNumber = mobileNumber;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
    }
}
