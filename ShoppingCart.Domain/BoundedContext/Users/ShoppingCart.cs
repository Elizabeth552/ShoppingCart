namespace ShoppingCart.Domain.BoundedContext.Users
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

        public User User { get; set; }
        public decimal TotalAmount { get; }
    }
}
