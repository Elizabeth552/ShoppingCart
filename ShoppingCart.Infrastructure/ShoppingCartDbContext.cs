namespace ShoppingCart.Infrastructure
{
    using System.Reflection;
    using Microsoft.EntityFrameworkCore;
    using ShoppingCart.Domain.Comments;
    using ShoppingCart.Domain.Products;

    public class ShoppingCartDbContext : DbContext
    {
        private const string ConnectionString = "Server=.;Database=ShoppingCartDB;Encrypt=False;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true";

        public ShoppingCartDbContext()
        {

        }

        public ShoppingCartDbContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString);
            base.OnConfiguring(options);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<decimal>().HavePrecision(18, 2);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.HasSequence("SnackMachineSeq").StartsAt(1).IncrementsBy(5).HasMin(0).HasMax(long.MaxValue);
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
