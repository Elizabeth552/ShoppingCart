namespace ShoppingCartServices.Users
{

    public interface IUsersServices
    {
        void CreateUser(UserDto userDto);

        UserDto GetUserById(long id);

        void DeleteUser(long id);

        void UpdateUser(UserDto user);
    }
}
