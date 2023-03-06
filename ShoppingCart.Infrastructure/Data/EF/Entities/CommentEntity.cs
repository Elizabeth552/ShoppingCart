namespace ShoppingCart.Infrastructure.Data.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ShoppingCart.Domain.Products;

    internal class CommentEntity
    {
        public ProductEntity Product { get; set; }

        public int ProductId { get; set; }

        public string Content { get; set; }
    }
}
