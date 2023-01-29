using Domain.DTOs;
using Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IOrderService
    {
        Task<ICollection<OrderResponse>> GetOrders();
        Task<OrderResponse> GetOrder(Guid orderId);
        Task<ResponseDTO> AddOrder(OrderDTO orderDTO);
    }
}
