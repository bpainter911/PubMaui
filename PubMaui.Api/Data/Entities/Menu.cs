using System.ComponentModel.DataAnnotations;

namespace PubMaui.Api.Data.Entities
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public string Category { get; set; }
        [Required, MaxLength(100)]
        public string MName { get; set; }
        [Required, MaxLength(180)]
        public string Image {  get; set; }
        [Required, MaxLength(1000)]
        public string Description { get; set; }

        [Range(0.1, double.MaxValue)]
        public double RetailPrice { get; set; }

        public virtual ICollection<MenuOptions> Options { get; set;}



    }

}
