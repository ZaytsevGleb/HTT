namespace WebApi.Models
{
    public class ProductDto
    {
        public Guid Id { get; init; }
        public Guid CategoryId { get; init; }
        public string Name { get; init; } = default!;
        public decimal Price { get; init; }
        public DateTime CreatedDate { get; init; }
    }
}
