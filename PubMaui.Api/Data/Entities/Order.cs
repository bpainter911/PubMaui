using System.ComponentModel.DataAnnotations;

namespace PubMaui.Api.Data.Entities
{
    public class Order
    {
        [Key]
        public long OrderId { get; set;}

        public DateTime OrderAt { get; set; } =DateTime.Now;

        public Guid CustomerId { get; set; }

        [Required, MaxLength(90)]
        public Guid CustomerFullName { get; set; }
        [Required, MaxLength(100)]
        public Guid CustomerEmail { get; set; }
        public Guid CustomerPhNumber { get; set; }
        public Guid CustomerAddress { get; set; }
        public Guid CustomerCityTown { get; set; }
        [Range(0.1, double.MaxValue)]
        public double Price { get; set; }

        [Range(0.1, double.MaxValue)]
        public double Tax { get; set; }

        [Range(0.1, double.MaxValue)]
        public double OrderSum { get; set; }

        public virtual ICollection<OrderItems> Items { get; set; }

    }

}
