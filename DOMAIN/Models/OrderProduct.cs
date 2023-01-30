using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class OrderProduct
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
