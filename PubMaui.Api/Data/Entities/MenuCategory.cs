using System.ComponentModel.DataAnnotations;

namespace PubMaui.Api.Data.Entities
{
    public class MenuCategory
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        

        public string Category { get; set; }

        public string CategoryDiscription { get; set; }

        public virtual ICollection<Menu> Menu { get;}

    }
}
