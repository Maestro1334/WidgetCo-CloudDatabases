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
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger _logger;

        public ProductController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<OrderController>();
        }
    }
}
