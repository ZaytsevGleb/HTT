namespace WebApi.Dtos;

public sealed class CategoryDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = default!;
    public List<ProductDto> Products { get; init; } = new();
    public DateTime CreatedDate { get; init; }
}
