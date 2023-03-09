namespace ShoppingCart.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ShoppingCart.Infrastructure.Data.EF.Entities;

    internal class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable(nameof(ProductEntity)).HasKey(t => t.Id);

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
                new { Id = 1, Name = "Purse", Description = "pretty purse", Category = "purses", Price = 111.99m, CreatedAt = DateTime.Now, Photo = "photo.jpeg", UserId = 1 },
                new { Id = 2, Name = "Scarf", Description = "blah", Category = "scarfs", Price = 300.99m, CreatedAt = DateTime.Now, Photo = "scarf.jpeg", UserId = 1 });
        }
    }
}
