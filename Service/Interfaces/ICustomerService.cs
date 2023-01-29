using Domain.Responses;

namespace Service.Interfaces;

public interface ICustomerService
{
    public Task<ICollection<CustomerResponse>> GetCustomers();
    public Task<CustomerResponse> GetCustomer(Guid customerId);
}
