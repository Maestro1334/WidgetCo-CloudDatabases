using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class OrderDTO
    {
        public Guid CustomerId { get; set; }
        public virtual ICollection<OrderProductDTO> Products { get; set; }
    }
}
