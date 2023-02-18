namespace ShoppingCart.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ShoppingCart.Domain.BoundedContext.Comments;

    internal class CommentEntityConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable(nameof(Comment)).HasKey(t => t.Id);

            builder.Property(t => t.Content).HasMaxLength(225).IsRequired();

            builder.HasOne(c => c.Product)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new { Id = 1L, Content = "very good my friend", ProductId = 1L },
                new { Id = 2L, Content = "im no like", ProductId = 2L });
        }
    }
}
