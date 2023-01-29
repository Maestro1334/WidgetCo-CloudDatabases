using Domain.DTOs;
using Domain.Models;
using Domain.Responses;

namespace Service.Interfaces;

public interface ICustomerService
{
    Task<ICollection<CustomerResponse>> GetCustomers();
    Task<CustomerResponse> GetCustomer(Guid customerId);
    Task<Customer> AddCustomer(CustomerDTO customerDTO);
}
