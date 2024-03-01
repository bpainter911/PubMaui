using System.ComponentModel.DataAnnotations;

namespace PubMaui.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required, MaxLength(20)]
        public string Password { get; set; }
        [Required, MinLength(20)]
        
        
        public string? PhNumber { get; set; }
        [Required, MaxLength(90)]
        public string? FullName { get; set; }

        public string? Address { get; set; }

        public string? CityTown { get; set; }

        public string? PostalCode { get; set; }

        public string Role { get; set; } = "User";
    }

}
