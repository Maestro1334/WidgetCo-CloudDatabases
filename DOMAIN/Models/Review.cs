using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Review : BaseModel
    {
        public Guid ProductId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public Review() { }

        public Review(Guid id, Guid productId, string comment, int rating, DateTime createdDate)
        {
            ProductId = productId;
            Comment = comment;
            Rating = rating;
            CreatedDate = createdDate;
        }
    }
}
