namespace BusinessLogic.Products.Models;

public sealed class ProductModel
{
    public Guid Id { get; init; }
    public Guid CategoryId { get; init; }
    public string Name { get; init; } = default!;
    public decimal Price { get; init; }
    public DateTime CreatedDate { get; init; }
    public DateTime? ModifiedDate { get; set; }
}
