namespace Domain.Models
{
    public class Review : BaseModel
    {
        public Guid ProductId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public Product Product { get; set; }
    }
}
