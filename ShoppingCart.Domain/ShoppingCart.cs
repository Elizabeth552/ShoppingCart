namespace ShoppingCart.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ShoppingCart : ValueObjectBase<ShoppingCart>
    {
        public ShoppingCart(long userId)
        {
            UserId = userId;
            CreatedAt = DateTime.Now;
            Products= new List<Product>();
        }

        public long UserId { get; }

        public DateTime CreatedAt { get; }

        public decimal TotalAmount { get; }

        public List<Product> Products { get; }
    }
}
