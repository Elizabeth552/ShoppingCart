namespace ShoppingCart.Infrastructure.Data.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ShoppingCart.Domain.Comments;
    using ShoppingCart.Domain.Users;

    internal class ProductEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Photo { get; set; }
        public List<CommentEntity>? Comments { get; set; } = new List<CommentEntity>();

        public UserEntity User { get; set; }

        public int UserId { get; set; }
    }
}
