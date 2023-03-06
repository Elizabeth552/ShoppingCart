namespace ShoppingCart.Domain.Products
{
    using System;
    using System.Collections.Generic;
    using ShoppingCart.Domain.Comments;
    using ShoppingCart.Domain.Common;
    using ShoppingCart.Domain.Users;

    public class Product : EntityBase
    {
        public Product(string name, string description, string categoty, decimal price, string photo)
        {
            Name = name;
            Description = description;
            Category = categoty;
            Price = price;
            Photo = photo;
            CreatedAt = DateTime.Now;
            Comments = new List<Comment>();
        }

        public string Name { get; }
        public string Description { get; }
        public string Category { get; }
        public decimal Price { get; }
        public DateTime CreatedAt { get; }
        public string Photo { get; }
        public List<Comment>? Comments { get; } = new List<Comment>();

        public User User { get; set; }

        public int UserId { get; set; }

    }
}
