using System.ComponentModel.DataAnnotations;

namespace DotnetCore.MediatR_testing.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
    }
}
