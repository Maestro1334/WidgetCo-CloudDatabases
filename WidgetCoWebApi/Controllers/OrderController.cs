using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetCoWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IOrderService _orderService;

        public OrderController(ILoggerFactory loggerFactory, IOrderService orderService)
        {
            _logger = loggerFactory.CreateLogger<OrderController>();
            _orderService = orderService;
        }

        [HttpPost(Name = "AddOrder")]
        public async Task<IActionResult> AddOrder([FromBody] OrderDTO orderDTO)
        {
            ResponseDTO response = await _orderService.AddOrder(orderDTO);

            if (!response.Success)
            {
                return StatusCode(500, response);
            }

            return Ok(response);
        }
    }
}
