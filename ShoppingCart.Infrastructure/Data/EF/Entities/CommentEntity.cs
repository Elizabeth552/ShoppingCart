namespace ShoppingCart.Infrastructure.Data.EF.Entities
{
    public class CommentEntity
    {
        public int Id { get; set; }
        public ProductEntity Product { get; set; }

        public int ProductId { get; set; }

        public string Content { get; set; }
    }
}
