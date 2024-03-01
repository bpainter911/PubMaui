using System.ComponentModel.DataAnnotations;

namespace PubMaui.Api.Data.Entities
{
    public class MenuOptions
    {
        
        public int MenuId { get; set; }
        
 
        [Required, MaxLength(100)]
        public string ItemOption {  get; set; }
        [Range(0.1, double.MaxValue)]
        public double ItemOptionPrice { get; set; }

        public virtual Menu menu { get; set; }
    }

}
