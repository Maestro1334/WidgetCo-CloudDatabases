using Domain.DTOs;
using Domain.Models;
using Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IOrderRepository
    {
        Task<ResponseDTO> AddOrder(OrderDTO orderDTO);

        Task<ResponseDTO> ProcessOrder(OrderResponse order);
    }
}
