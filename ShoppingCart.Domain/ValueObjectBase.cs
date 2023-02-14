namespace ShoppingCart.Domain
{
    public interface IValueObject
    {

    }

    public abstract class ValueObjectBase<T> : IValueObject
        where T : ValueObjectBase<T>
    {
        
    }
}
