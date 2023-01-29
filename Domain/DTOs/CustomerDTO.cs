namespace Domain.DTOs;

public class CustomerDTO
{
    public string Email { get; set; }
    public string Password { get; set; }

    public CustomerDTO() { }

    public CustomerDTO(string email, string password)
    {
        Email = email;
        Password = password;
    }
}