namespace ShoppingCart.Domain
{
    using System;
    using System.Collections.Generic;

    public class Product : EntityBase
    {
        public Product()
        {

        }

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

    }
}
