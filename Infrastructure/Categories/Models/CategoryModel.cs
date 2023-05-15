namespace BusinessLogic.Categories.Models;

public sealed class CategoryModel
{
    public Guid Id { get; init; }
    public string Name { get; init; } = default!;
    public DateTime CreatedDate { get; init; }
    public Guid? ModifiedByUserId { get; init; }
}
