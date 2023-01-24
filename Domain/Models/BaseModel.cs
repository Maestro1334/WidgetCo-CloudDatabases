using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public abstract class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
