using Domain.DTOs;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IReviewRepository
    {
        Task<ResponseDTO> AddReview(ReviewDTO reviewDTO);
    }
}
