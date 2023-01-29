using Domain.Models;

namespace Domain.Responses
{
    public class OrderResponse
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public virtual ICollection<OrderProduct> Products { get; set; }
        public double Total { get; set; }
        public OrderStatus Status { get; set; }
    }
}
