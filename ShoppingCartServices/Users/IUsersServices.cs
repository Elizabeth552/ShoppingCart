namespace ShoppingCartServices.Users
{
    using ShoppingCart.Domain.BoundedContext.Users;

    public interface IUsersServices
    {
        UserDto CreateUser();

        // CHange this to return UserDto
        User GetUserById(long id);
    }
}
