namespace ShoppingCart.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ShoppingCart.Infrastructure.Data.EF.Entities;

    internal class CommentEntityConfiguration : IEntityTypeConfiguration<CommentEntity>
    {
        public void Configure(EntityTypeBuilder<CommentEntity> builder)
        {
            builder.ToTable(nameof(CommentEntity)).HasKey(t => t.Id);

            builder.Property(t => t.Content).HasMaxLength(225).IsRequired();

            builder.HasOne(c => c.Product)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new { Id = 1, Content = "very good my friend", ProductId = 1 },
                new { Id = 2, Content = "im no like", ProductId = 2 });
        }
    }
}
