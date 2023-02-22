namespace ShoppingCartServices.Users
{
    using ShoppingCart.Domain.BoundedContext.Users;

    public interface IUsersServices
    {
        void CreateUser(UserDto userDto);

        // CHange this to return UserDto
        User GetUserById(long id);

        void DeleteUser(long id);

        void UpdateUser(UserDto user);
    }
}
