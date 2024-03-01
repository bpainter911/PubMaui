using System.ComponentModel.DataAnnotations;

namespace PubMaui.Api.Data.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(30)]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required, MinLength(20)]
        public string Salt { get; set; }
        [Required, MinLength(180)]
        public string Hash { get; set; }

        public string? PhNumber { get; set; }
        [Required, MaxLength(90)]
        public string? FullName { get; set; }

        public string? Address { get; set; }

        public string? CityTown { get; set; }

        public string? PostalCode { get; set; }
    }

}
