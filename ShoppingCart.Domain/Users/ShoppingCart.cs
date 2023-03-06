namespace ShoppingCart.Domain.Users
{
    using System;
    using global::ShoppingCart.Domain.Common;
    using global::ShoppingCart.Domain.Products;

    public class ShoppingCart : ValueObjectBase<ShoppingCart>
    {
        public ShoppingCart()
        {
            ShoppingCartCreatedAt = DateTime.Now;
        }

        public DateTime ShoppingCartCreatedAt { get; }

        public User User { get; set; }
        public decimal TotalAmount { get; }

    }
}
