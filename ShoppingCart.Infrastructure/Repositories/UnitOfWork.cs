namespace ShoppingCart.Infrastructure.Repositories
{
    using System;
    using ShoppingCart.Domain.BoundedContext.Users;

    public class UnitOfWork : IDisposable
    {
        private ShoppingCartDbContext context = new ShoppingCartDbContext();
        private RepositoryBase<User> userRepository;

        public RepositoryBase<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new RepositoryBase<User>(context);
                }
                return userRepository;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
