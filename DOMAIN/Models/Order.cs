namespace Domain.Models
{
    public class Order : BaseModel
    {
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual ICollection<OrderProduct> Products { get; set; }

        public double Total { get; set; }

        public OrderStatus Status { get; set; }
    }
}
