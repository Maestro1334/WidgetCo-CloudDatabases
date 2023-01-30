using Domain.DTOs;
using Domain.Responses;

namespace DAL.Interfaces
{
    public interface IProductRepository
    {
        Task<ResponseDTO> AddProduct(ProductDTO productDTO);
        Task<ProductResponse> GetProduct(Guid id);
    }
}
