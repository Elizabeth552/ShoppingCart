namespace ShoppingCart.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ShoppingCart.Domain.Products;

    internal class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product)).HasKey(t => t.Id);

            builder.Property(t => t.Name).HasMaxLength(125).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(250).IsRequired();
            builder.Property(t => t.Category).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Price).IsRequired();
            builder.Property(t => t.CreatedAt).IsRequired();
            builder.Property(t => t.Photo).HasMaxLength(100).IsRequired();

            builder.HasMany(t => t.Comments)
                .WithOne(c => c.Product)
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new { Id = 1L, Name = "Purse", Description = "pretty purse", Category = "purses", Price = 111.99m, CreatedAt = DateTime.Now, Photo = "photo.jpeg", UserId = 1L },
                new { Id = 2L, Name = "Scarf", Description = "blah", Category = "scarfs", Price = 300.99m, CreatedAt = DateTime.Now, Photo = "scarf.jpeg", UserId = 1L });
        }
    }
}
