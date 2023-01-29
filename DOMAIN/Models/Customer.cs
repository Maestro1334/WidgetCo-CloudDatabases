namespace Domain.Models
{
    public class Customer : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        //public Customer() { }

        //public Customer(string email, string password, ICollection<Order> orders)
        //{
        //    Email = email;
        //    Password = password;
        //    Orders = orders;
        //}

        //public Customer(Guid id, string email, string password, ICollection<Order> orders)
        //{
        //    Id = id;
        //    Email = email;
        //    Password = password;
        //    Orders = orders;
        //}
    }
}
