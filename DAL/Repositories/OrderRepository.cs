using DAL.Interfaces;
using Domain.DTOs;
using Domain.Models;
using System.Text.Json;

namespace DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StoreContext _storeContext;
        public OrderRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<ResponseDTO> AddOrder(OrderDTO orderDTO)
        {
            Customer? customer = await _storeContext.Customers.FindAsync(orderDTO.CustomerId);

            if (customer == null)
            {
                return new ResponseDTO { Success = false, Message = $"Customer with customerId {orderDTO.CustomerId} not found." };
            }

            // create empty list of OrderProducts
            ICollection<OrderProduct> products = new List<OrderProduct>();

            // create orderId
            Guid orderId = Guid.NewGuid();

            // for each orderProductDTO, check if product exists, then convert to OrderProduct with orderId
            foreach (OrderProductDTO orderProductDTO in orderDTO.Products)
            {
                if (_storeContext.Products.Any(p => p.Id == orderProductDTO.ProductId))
                {
                    products.Add(new() { OrderId = orderId, ProductId = orderProductDTO.ProductId, Quantity = orderProductDTO.Quantity });
                }
                else
                {
                    return new ResponseDTO() { Success = false, Message = $"Product with productId {orderProductDTO.ProductId} not found." };
                }
            }

            double totalPrice = 0.0;
            // calculate total price of order
            foreach (OrderProduct orderProduct in products)
            {
                Product? product = await _storeContext.Products.FindAsync(orderProduct.ProductId);

                if (product == null)
                {
                    continue;
                }
                totalPrice += (orderProduct.Quantity * product.Price);
            }

            // create order
            Order order = new() { 
                Id = orderId, 
                CustomerId = customer.Id, 
                Products = products, 
                Status = OrderStatus.Processing, 
                OrderDate = DateTime.Now, 
                Total = totalPrice };

            await _storeContext.Orders.AddAsync(order);
            await _storeContext.SaveChangesAsync();

            return new ResponseDTO { Success = true, Message = JsonSerializer.Serialize(order) };
        }
    }
}
