using Domain.DTOs;
using Domain.Models;
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
        public async Task<Customer> AddHouse([FromBody] CustomerDTO customerDTO)
        {
            return await _customerService.AddCustomer(customerDTO);
        }
    }
}