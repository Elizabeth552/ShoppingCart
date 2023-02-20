using ShoppingCart.Domain.BoundedContext.Products;
using ShoppingCart.Domain.Common;

namespace ShoppingCart.Domain.BoundedContext.Comments
{
    public class Comment : EntityBase
    {
        public Comment() { }

        public Comment(string content)
        {
            Content = content;
        }

        public Product Product { get; set; }

        public long ProductId { get; set; }

        public string Content { get; }
    }
}
