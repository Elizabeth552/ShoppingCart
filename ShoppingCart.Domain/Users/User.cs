namespace ShoppingCart.Domain.Users
{
    using System.Globalization;
    using global::ShoppingCart.Domain.Common;

    public class User : EntityBase
    {
        public User()
        {

        }
        public User(string email, string firstName, string lastName, string phoneNumber)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string PhoneNumber { get; }
        public string CreatedAt { get; private set; }
        public UserAddress UserAddress { get; set; }
        public ShoppingCart? ShoppingCart { get; private set; }

        public void CreateShoppingCart()
        {
            ShoppingCart = new ShoppingCart();
        }

        public void PopulateCreatedAtDate()
        {
            CreatedAt = DateTime.Now.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
