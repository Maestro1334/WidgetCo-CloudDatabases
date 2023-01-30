using Domain.DTOs;
using Domain.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
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
    public class ProductController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IProductService _productService;
        private readonly IImageService _imageService;

        public ProductController(ILoggerFactory loggerFactory, IProductService productService, IImageService imageService)
        {
            _logger = loggerFactory.CreateLogger<OrderController>();
            _productService = productService;
            _imageService = imageService;
        }

        [HttpPost(Name = "AddProduct")]
        public async Task<IActionResult> AddProduct([FromBody] ProductDTO productDTO)
        {
            ResponseDTO response = await _productService.AddProduct(productDTO);

            if (!response.Success)
            {
                return StatusCode(500, response);
            }

            return Ok(response);
        }

        [HttpGet(Name = "GetProduct")]
        public async Task<IActionResult> GetProduct(Guid productId)
        {
            ProductResponse product = await _productService.GetProduct(productId);

            if (product == null)
                return NotFound();

            string imageUrl = string.Empty;
            try
            {
                imageUrl = _imageService.GetUrl(product.Description.ToLower() + ".avif");
            }
            catch(Exception ex) { return StatusCode(500, ex); }
            

            product.ImageUrl= imageUrl;

            return Ok(product);
        }
    }
}
