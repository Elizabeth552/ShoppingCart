namespace ShoppingCart.Domain.Users
{
    using System;
    using global::ShoppingCart.Domain.Common;
    using global::ShoppingCart.Domain.Products;

    public class User : EntityBase
    {
        public User(string firstName, string lastName, string userName, string email, string phone)
        {
            UserName = userName;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            CreatedAt = DateTime.Now;
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
