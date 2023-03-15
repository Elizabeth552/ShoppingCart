namespace ShoppingCart.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ShoppingCart.Infrastructure.Data.EF.Entities;

    internal class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable(nameof(UserEntity)).HasKey(t => t.Id);

            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.Email).IsRequired();
            builder.Property(t => t.CreatedAt).IsRequired();
            builder.Property(t => t.PhoneNumber).IsRequired();
            builder.Property(t => t.City).IsRequired();
            builder.Property(t => t.Street).IsRequired();
            builder.Property(t => t.HouseNumber).IsRequired();
            builder.Ignore(u => u.AccessFailedCount);
            builder.Ignore(u => u.LockoutEnd);
            builder.Ignore(u => u.LockoutEnabled);
            builder.Ignore(u => u.TwoFactorEnabled);
            builder.Ignore(u => u.EmailConfirmed);
            builder.Ignore(u => u.PhoneNumberConfirmed);
            //builder.Ignore(u => u.UserName);
            //builder.Ignore(u => u.NormalizedUserName);
            //builder.Ignore(u => u.NormalizedEmail);

            builder.OwnsOne(u => u.ShoppingCart, navBldr =>
            {
                navBldr.Property(sc => sc.TotalAmount).HasColumnName(nameof(ShoppingCartEntity.TotalAmount));

                navBldr.HasData(new
                {
                    UserId = 1,
                    TotalAmount = 0m
                });
            });

            builder.HasMany(u => u.Products)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasData(
            new
            {
                Id = 1,
                FirstName = "Pesho",
                LastName = "Peshov",
                Email = "pesho@pesho.be",
                CreatedAt = "11.12.2022",
                PhoneNumber = "12345678",
                Password = "ne kazvai na nikoi",
                City = "burgas",
                Street = "Ivan",
                HouseNumber = "23M",
            });
        }
    }
}
