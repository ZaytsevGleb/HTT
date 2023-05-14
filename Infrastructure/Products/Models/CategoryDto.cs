namespace BusinessLogic.Products.Models;

public sealed class CategoryDto
{
    public Guid Id { get; init; }
    public string Name { get; set; } = default!;
    public DateTime CreatedDate { get; init; }
    public List<ProductModel> Products { get; set; } = new();
}
