namespace ShoppingCart.Domain.Users
{
    using global::ShoppingCart.Domain.Common;

    public class UserAddress : ValueObjectBase<UserAddress>
    {
        public UserAddress()
        {

        }
        public string City { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }
    }
}
