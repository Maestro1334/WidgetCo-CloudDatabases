﻿namespace Domain.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
