namespace ShoppingCart.Domain.BoundedContext.Products
{
    using ShoppingCart.Domain.BoundedContext.Comments;

    public class ProductDto
    {
        public ProductDto(long id, string name, string description, string categoty, decimal price, string photo)
        {
            Name = name;
            Description = description;
            Category = categoty;
            Price = price;
            Photo = photo;
            CreatedAt = DateTime.Now;
            Comments = new List<Comment>();
        }

        public long Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Category { get; }
        public decimal Price { get; }
        public DateTime CreatedAt { get; }
        public string Photo { get; }
        public List<Comment>? Comments { get; } = new List<Comment>();

    }
}
