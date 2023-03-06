namespace ShoppingCart.Infrastructure.Data.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ShoppingCart.Domain.Users;

    internal class ShoppingCartEntity
    {
        public DateTime ShoppingCartCreatedAt { get; set; }

        public UserEntity User { get; set; }

        public decimal TotalAmount { get; }
    }
}
