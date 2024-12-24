using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCore.MediatR_testing.Models.DTOs.EmployeeDTOs
{
    public class UpdateEmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public int DepartmentId { get; set; }
    }
}
