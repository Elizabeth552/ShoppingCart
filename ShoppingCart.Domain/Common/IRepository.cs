namespace ShoppingCart.Domain.Common
{
    public interface IRepository<T> where T : EntityBase
    {
        public T? GetById(long Id);

        public void Save(T entity);
    }
}
