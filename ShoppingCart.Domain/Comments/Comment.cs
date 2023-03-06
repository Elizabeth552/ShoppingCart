using ShoppingCart.Domain.Common;
using ShoppingCart.Domain.Products;

namespace ShoppingCart.Domain.Comments
{
    public class Comment : EntityBase
    {
        public Comment() { }

        public Comment(string content)
        {
            Content = content;
        }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public string Content { get; }
    }
}
