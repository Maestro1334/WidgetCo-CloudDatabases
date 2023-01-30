using Azure;
using DAL.Interfaces;
using Domain.DTOs;
using Domain.Models;
using Domain.Responses;
using Newtonsoft.Json;

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

            return new ResponseDTO { Success = true, Message = JsonConvert.SerializeObject(product) };
        }

        public async Task<ProductResponse> GetProduct(Guid id)
        {
            Product? product = await _storeContext.Products.FindAsync(id);

            if (product == null)
            {
                return new ProductResponse() { Name = "Not found" };
            }
            else
            {
                return new ProductResponse { Id = product.Id, Description = product.Description, Name = product.Name, Price = product.Price, ImageUrl = "" };
            }
        }
    }
}
