namespace ShoppingCart.Infrastructure.Data.EF.Entities
{
    public class ShoppingCartEntity
    {
        public UserEntity User { get; set; }

        public decimal TotalAmount { get; }
    }
}
