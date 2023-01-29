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
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _storeContext;
        public ProductRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<ResponseDTO> AddProduct(ProductDTO productDTO)
        {
            Product product = new() { 
                Id = Guid.NewGuid(), 
                Name = productDTO.Name, 
                Price = productDTO.Price, 
                Description = productDTO.Description, 
                ImageUrl = productDTO.ImageUrl 
            };

            await _storeContext.Products.AddAsync(product);
            await _storeContext.SaveChangesAsync();

            return new ResponseDTO { Success = true, Message = JsonSerializer.Serialize(product) };
        }
    }
}
