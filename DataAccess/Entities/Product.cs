namespace DataAccess.Entities;

public sealed class Product
{
    public Guid Id { get; init; }
    public Guid CategoryId { get; set; }
    public string Name { get; init; } = default!;
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; init; }
    public DateTime? ModifiedDate { get; set; }
    public Category Category { get; set; } = new();
}
