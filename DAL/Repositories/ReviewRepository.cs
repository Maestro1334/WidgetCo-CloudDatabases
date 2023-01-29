using DAL.Interfaces;
using Domain.DTOs;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly StoreContext _storeContext;

        public ReviewRepository(StoreContext storeContext)
        {
            _storeContext= storeContext;
        }

        public async Task<ResponseDTO> AddReview(ReviewDTO reviewDTO)
        {
            Product? reviewedProduct = await _storeContext.Products.FindAsync(reviewDTO.ProductId);

            if (reviewedProduct == null)
            {
                return new ResponseDTO { Success = false, Message = $"Product with productId {reviewDTO.ProductId} not found." };
            }

            Review review = new()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Product = reviewedProduct,
                Comment = reviewDTO.Comment,
                Rating = reviewDTO.Rating,
            };

            await _storeContext.Reviews.AddAsync(review);
            await _storeContext.SaveChangesAsync();

            return new ResponseDTO { Success = true, Message = JsonSerializer.Serialize(review) };
        }
    }
}
