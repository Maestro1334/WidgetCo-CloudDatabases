using DAL.Interfaces;
using DAL.Repositories;
using Domain.DTOs;
using Domain.Responses;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
    
        public async Task<ResponseDTO> AddReview(ReviewDTO reviewDTO)
        {
            return await _reviewRepository.AddReview(reviewDTO);
        }

        public Task<ReviewResponse> GetReview(Guid reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ReviewResponse>> GetReviews()
        {
            throw new NotImplementedException();
        }
    }
}
