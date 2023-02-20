namespace ShoppingCart.Domain.BoundedContext.Users
{
    using System;
    using global::ShoppingCart.Domain.BoundedContext.Products;
    using global::ShoppingCart.Domain.Common;

    public class User : EntityBase
    {
        public User(string firstName, string lastName, string userName, string password, string email, string phone)
        {
            UserName = userName;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            CreatedAt = DateTime.Now;
            Products = new List<Product>();
        }

        public string UserName { get; }
        public string Password { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Phone { get; }
        public DateTime CreatedAt { get; }
        public ShoppingCart? ShoppingCart { get; private set; }
        public List<Product> Products { get; } = new List<Product>();

        public void CreateShoppingCart()
        {
            ShoppingCart = new ShoppingCart();
        }
    }
}
