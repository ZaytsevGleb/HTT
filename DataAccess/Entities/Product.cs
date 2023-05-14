namespace DataAccess.Entities;

public sealed class Product
{
    public Guid Id { get; init; }
    public Guid CategoryId { get; init; }
    public string Name { get; init; } = default!;
    public decimal Price { get; init; }
    public DateTime CreatedDate { get; init; }
    public DateTime? ModifiedDate { get; set; }
    public Category Category { get; init; } = new();
}
