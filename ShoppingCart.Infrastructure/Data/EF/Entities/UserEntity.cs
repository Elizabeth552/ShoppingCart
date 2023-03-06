namespace ShoppingCart.Infrastructure.Data.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ShoppingCart.Domain.Products;

    internal class UserEntity
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }  

        public string LastName { get; set; }

        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; }

        public ShoppingCartEntity? ShoppingCart { get; set; }

        public List<ProductEntity> Products { get; } = new List<ProductEntity>();

    }
}
