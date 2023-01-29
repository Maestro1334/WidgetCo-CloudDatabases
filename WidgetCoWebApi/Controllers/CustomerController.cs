using Domain.DTOs;
using Domain.Models;
using Domain.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Interfaces;

namespace WidgetCoWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly ICustomerService _customerService;

        public CustomerController(ILoggerFactory loggerFactory, ICustomerService customerService)
        {
            _logger = loggerFactory.CreateLogger<OrderController>();
            _customerService = customerService;
        }

        [HttpPost(Name = "AddCustomer")]
        public async Task<IActionResult> AddHouse([FromBody] CustomerDTO customerDTO)
        {
            ResponseDTO response = await _customerService.AddCustomer(customerDTO);

            if (!response.Success)
            {
                return StatusCode(500, response);
            }

            return Ok(response);
        }
    }
}