using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class ReviewDTO
    {
        public Guid ProductId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}
