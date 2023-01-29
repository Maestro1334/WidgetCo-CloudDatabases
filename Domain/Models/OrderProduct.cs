﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class OrderProduct
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }

        //[ForeignKey("OrderId")]
        public Order Order { get; set; }

        //[ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int Quantity { get; set; }

        //public OrderProduct() { }

        //public OrderProduct(Guid orderId, Guid productId, int quantity) 
        //{
        //    OrderId = orderId;
        //    ProductId = productId;
        //    Quantity = quantity;
        //}
    }
}
