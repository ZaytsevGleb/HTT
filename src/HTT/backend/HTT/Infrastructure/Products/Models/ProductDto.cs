namespace BusinessLogic.Products.Models;

public sealed class ProductDto
{
    public Guid Id { get; init; }
    public Guid CategoryId { get; init; }
    public string Name { get; init; } = default!;
    public decimal Price { get; set; }
}
