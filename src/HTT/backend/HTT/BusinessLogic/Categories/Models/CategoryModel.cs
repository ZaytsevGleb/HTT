using BusinessLogic.Products.Models;

namespace BusinessLogic.Categories.Models;

public sealed class CategoryModel
{
    public Guid Id { get; init; }
    public string Name { get; init; } = default!;
    public List<ProductModel> Products { get; init; } = new();
    public DateTime CreatedDate { get; init; }
    public DateTime? ModifiedDate { get; set; }
}
