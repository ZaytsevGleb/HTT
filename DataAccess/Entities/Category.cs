namespace DataAccess.Entities;

public sealed class Category
{
    public Guid Id { get; init; }
    public string Name { get; set; } = default!;
    public DateTime CreatedDate { get; init; }
    public DateTime? ModifiedDate { get; set; }
    public List<Product> Products { get; set; } = new();
}