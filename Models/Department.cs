using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotnetCore.MediatR_testing.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        // Navigation Property
        [JsonIgnore]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
