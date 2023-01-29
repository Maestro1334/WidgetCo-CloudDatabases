namespace Domain.Responses;

public class CustomerResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    //public CustomerResponse() { }

    //public CustomerResponse(Guid id, string email, string password)
    //{
    //    Id = id;
    //    Email = email;
    //    Password = password;
    //}
}