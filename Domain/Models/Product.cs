using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Domain.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Product() { }

        public Product(Guid id, string name, string description, string imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
