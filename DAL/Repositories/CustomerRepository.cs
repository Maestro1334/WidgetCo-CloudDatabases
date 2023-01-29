using DAL.Interfaces;
using Domain.DTOs;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly StoreContext _storeContext;
        public CustomerRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<Customer> AddCustomer(CustomerDTO customerDTO)
        {
            Customer customer = new() { Id = Guid.NewGuid(), Email = customerDTO.Email, Password = customerDTO.Password };

            await _storeContext.Customers.AddAsync(customer);
            await _storeContext.SaveChangesAsync();

            return customer;
        }
    }
}
