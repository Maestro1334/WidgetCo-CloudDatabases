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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository= productRepository;
        }

        public async Task<ResponseDTO> AddProduct(ProductDTO productDTO)
        {
            return await _productRepository.AddProduct(productDTO);
        }

        public async Task<ProductResponse> GetProduct(Guid productId)
        {
            return await _productRepository.GetProduct(productId);
        }

        public Task<ICollection<ProductResponse>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
