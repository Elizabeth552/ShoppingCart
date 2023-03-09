namespace ShoppingCart.Infrastructure.Data.EF.Entities
{
    using System;

    public class ShoppingCartEntity
    {
        public DateTime ShoppingCartCreatedAt { get; set; }

        public UserEntity User { get; set; }

        public decimal TotalAmount { get; }
    }
}
