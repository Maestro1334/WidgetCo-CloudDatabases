using Domain.DTOs;
using Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IReviewService
    {
        Task<ICollection<ReviewResponse>> GetReviews();
        Task<ReviewResponse> GetReview(Guid reviewId);
        Task<ResponseDTO> AddReview(ReviewDTO reviewDTO);
    }
}
