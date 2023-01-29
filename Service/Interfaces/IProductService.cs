using Domain.DTOs;
using Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IProductService
    {
        Task<ICollection<ProductResponse>> GetProducts();
        Task<ProductResponse> GetProduct(Guid productId);
        Task<ResponseDTO> AddProduct(ProductDTO productDTO);
    }
}
