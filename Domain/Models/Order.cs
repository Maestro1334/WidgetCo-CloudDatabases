namespace Domain.Models
{
    public class Order : BaseModel
    {
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual ICollection<OrderProduct> Products { get; set; }

        public double Total { get; set; }

        public OrderStatus Status { get; set; }
        
        //public Order() { }

        //public Order(Guid id, Guid customerId, DateTime orderDate, ICollection<OrderProduct> products, decimal total, OrderStatus status)
        //{
        //    Id = id;
        //    CustomerId = customerId;
        //    OrderDate = orderDate;
        //    Products = products;
        //    Total = total;
        //    Status = status;
        //}
    }
}
