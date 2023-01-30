namespace Domain.Models
{
    public class Customer : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
