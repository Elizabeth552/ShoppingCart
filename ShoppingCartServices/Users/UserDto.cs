namespace ShoppingCartServices.Users
{
    using ShoppingCartServices.Products;

    public class UserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public ShoppingCartDto? ShoppingCart { get; private set; }
        public List<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
