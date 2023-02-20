namespace ShoppingCartServices.Users
{
    using ShoppingCart.Domain.BoundedContext.Products;

    public class UserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Phone { get; }
        public DateTime CreatedAt { get; }
        public ShoppingCartDto? ShoppingCart { get; private set; }
        public List<ProductDto> Products { get; } = new List<ProductDto>();
    }
}
