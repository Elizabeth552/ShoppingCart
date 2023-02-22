namespace ShoppingCartServices.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<CommentDto> Comments { get; set; } = new List<CommentDto>();
    }
}
