using DAL.Interfaces;
using Domain.DTOs;
using Domain.Models;
using Domain.Responses;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
    
        public async Task<ResponseDTO> AddOrder(OrderDTO orderDTO)
        {
            return await _orderRepository.AddOrder(orderDTO);
        }

        public async Task<ResponseDTO> CreateOrder(OrderDTO orderDTO)
        {
            return await _orderRepository.CreateOrder(orderDTO);
        }

        public Task<OrderResponse> GetOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<OrderResponse>> GetOrders()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDTO> ProcessOrder(OrderResponse order)
        {
            return await _orderRepository.ProcessOrder(order);
        }
    }
}
