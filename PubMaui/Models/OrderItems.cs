using System.ComponentModel.DataAnnotations;

namespace PubMaui.Models
{
    public class OrderItems
    {
        [Key]
        public long Id { get; set; }

        public long OrderId { get; set; }

        public int MId { get; set; }
        [Required, MaxLength(90)]
        public string Name { get; set; }
        [Range(0.1, double.MaxValue)]
        public double Price { get; set; }

        [Range(0.1, double.MaxValue)]
        public double Tax { get; set; }

        [Range(0.1, double.MaxValue)]
        public double OrderSum { get; set; }

        [Range(1, 100)]
        public double Quantity { get; set; }

        [Required, MaxLength(100)]
        public string ItemOption { get; set; }

        public double ItemOptionPrice { get; set; }

        [Range(0.1, double.MaxValue)]
        public double TotalPrice { get; set; }

        [Range(0.1, double.MaxValue)]
        public double TotalTax { get; set; }

        [Range(0.1, double.MaxValue)]
        public double TotalOrderSum { get; set; }

        public virtual Order Order { get; set; }
    }

}
