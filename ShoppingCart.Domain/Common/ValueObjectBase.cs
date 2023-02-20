namespace ShoppingCart.Domain.Common
{
    public interface IValueObject
    {

    }

    public abstract class ValueObjectBase<T> : IValueObject
        where T : ValueObjectBase<T>
    {

    }
}
