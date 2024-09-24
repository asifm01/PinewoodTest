using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
    }
}
