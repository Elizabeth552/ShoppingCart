namespace ShoppingCart.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
        }

        public string UserName { get; }
        public string Password { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Phone { get; }
        public DateTime CreatedAt { get; }
        public ShoppingCart? ShoppingCart { get; private set; }

        public void CreateShoppingCart()
        {
            ShoppingCart = new ShoppingCart(Id);
        }
    }
}
