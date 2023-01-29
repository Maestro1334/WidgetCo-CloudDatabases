using DAL.Interfaces;
using Domain.DTOs;
using Domain.Models;
using System.Text.Json;

namespace DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly StoreContext _storeContext;
        public CustomerRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<ResponseDTO> AddCustomer(CustomerDTO customerDTO)
        {
            Customer customer = new() { Id = Guid.NewGuid(), Email = customerDTO.Email, Password = customerDTO.Password };

            await _storeContext.Customers.AddAsync(customer);
            await _storeContext.SaveChangesAsync();

            return new ResponseDTO { Success = true, Message = JsonSerializer.Serialize(customer) };
        }
    }
}
