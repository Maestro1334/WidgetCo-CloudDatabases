using Domain.DTOs;
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
    public class ReviewController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IReviewService _reviewService;

        public ReviewController(ILoggerFactory loggerFactory, IReviewService reviewService)
        {
            _logger = loggerFactory.CreateLogger<OrderController>();
            _reviewService = reviewService;
        }

        [HttpPost(Name = "AddReview")]
        public async Task<IActionResult> AddReview([FromBody] ReviewDTO reviewDTO)
        {
            ResponseDTO response = await _reviewService.AddReview(reviewDTO);

            if (!response.Success)
            {
                return StatusCode(500, response);
            }

            return Ok(response);
        }
    }
}
