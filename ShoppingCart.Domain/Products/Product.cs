namespace ShoppingCart.Domain.Products
{
    using System.Collections.Generic;
    using ShoppingCart.Domain.Comments;
    using ShoppingCart.Domain.Common;

    public class Product : EntityBase
    {
        public Product(string name, string description, string categoty, decimal price, string photo, string createdAt)
        {
            Name = name;
            Description = description;
            Category = categoty;
            Price = price;
            Photo = photo;
            CreatedAt = createdAt;
            Comments = new List<Comment>();
        }

        public string Name { get; }
        public string Description { get; }
        public string Category { get; }
        public decimal Price { get; }
        public string CreatedAt { get; }
        public string Photo { get; }
        public List<Comment>? Comments { get; } = new List<Comment>();

    }
}
