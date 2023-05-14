namespace BusinessLogic.Products.Models
{
    public sealed class CategoryModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTime CreatedDate { get; init; }
        public List<ProductModel> Products { get; set; } = new();
    }
}
