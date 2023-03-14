namespace ShoppingCart.Domain.Users
{
    using System;
    using global::ShoppingCart.Domain.Common;

    public class ShoppingCart : ValueObjectBase<ShoppingCart>
    {
        public ShoppingCart()
        {
            ShoppingCartCreatedAt = DateTime.Now;
        }

        public DateTime ShoppingCartCreatedAt { get; }

        public decimal TotalAmount { get; }

    }
}
