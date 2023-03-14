namespace ShoppingCart.Infrastructure.Data.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class UserEntity : IdentityUser<int>
    {
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; }

        public ShoppingCartEntity? ShoppingCart { get; set; }

        public List<ProductEntity> Products { get; } = new List<ProductEntity>();

    }
}
