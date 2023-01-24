using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Customer : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public Customer() {}

        public Customer(Guid id, string email, string password, ICollection<Order> orders)
        {
            Id = id;
            Email = email;
            Password = password;
        }
    }
}
