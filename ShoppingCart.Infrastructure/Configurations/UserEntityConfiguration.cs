namespace ShoppingCart.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ShoppingCart.Domain.BoundedContext.Users;

    internal class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User)).HasKey(t => t.Id);

            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.UserName).IsRequired();
            builder.Property(t => t.Email).IsRequired();
            builder.Property(t => t.CreatedAt).IsRequired();
            builder.Property(t => t.Phone).IsRequired();
            builder.Property(t => t.Password).IsRequired();

            builder.OwnsOne(u => u.ShoppingCart, navBldr =>
            {
                navBldr.Property(sc => sc.TotalAmount).HasColumnName(nameof(ShoppingCart.TotalAmount));
                navBldr.Property(m => m.ShoppingCartCreatedAt).HasColumnName(nameof(ShoppingCart.ShoppingCartCreatedAt));

                navBldr.HasData(new
                {
                    UserId = 1L,
                    TotalAmount = 0m,
                    ShoppingCartCreatedAt = DateTime.Now
                });
            });

            builder.HasMany(u => u.Products)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasData(
            new
            {
                Id = 1L,
                FirstName = "Pesho",
                LastName = "Peshov",
                UserName = "pesho_boga",
                Email = "pesho@pesho.be",
                CreatedAt = DateTime.Now,
                Phone = "12345678",
                Password = "ne kazvai na nikoi"
            });
        }
    }
}
