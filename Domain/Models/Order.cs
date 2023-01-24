using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Order : BaseModel
    {
        Guid CustomerId { get; set; }
        DateTime OrderDate { get; set; }
        public virtual ICollection<OrderProduct> Products { get; set; }

        decimal Total { get; set; }

        OrderStatus Status { get; set; }
        
        public Order() { }

        public Order(Guid id, Guid customerId, DateTime orderDate, ICollection<OrderProduct> products, decimal total, OrderStatus status)
        {
            Id = id;
            CustomerId = customerId;
            OrderDate = orderDate;
            Products = products;
            Total = total;
            Status = status;
        }
    }
}
