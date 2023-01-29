using DAL.Interfaces;
using Domain.DTOs;
using Domain.Models;
using Domain.Responses;
using Service.Interfaces;

namespace Service;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<ResponseDTO> AddCustomer(CustomerDTO customerDTO)
    {
        return await _customerRepository.AddCustomer(customerDTO);
    }

    public Task<CustomerResponse> GetCustomer(Guid customerId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<CustomerResponse>> GetCustomers()
    {
        throw new NotImplementedException();
    }
}
