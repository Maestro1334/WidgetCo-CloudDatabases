using Domain.Responses;
using Service.Interfaces;

namespace Service;

public class CustomerService : ICustomerService
{

    public CustomerService() { }

    //public CustomerService()
    //{
    //    // add stuff
    //}

    public Task<CustomerResponse> GetCustomer(Guid customerId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<CustomerResponse>> GetCustomers()
    {
        throw new NotImplementedException();
    }
}
