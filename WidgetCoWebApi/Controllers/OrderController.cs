using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetCoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger _logger;

        public OrderController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<OrderController>();
        }
    }
}
