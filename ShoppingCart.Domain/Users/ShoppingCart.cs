namespace ShoppingCart.Domain.Users
{
    using global::ShoppingCart.Domain.Common;
    using global::ShoppingCart.Domain.Products;

    public class ShoppingCart : ValueObjectBase<ShoppingCart>
    {
        public ShoppingCart()
        {

        }

        public decimal TotalAmount { get; }

        public List<Product> Products { get; } = new List<Product>();

    }
}
