namespace ShoppingCartServices.Users
{
    using AutoMapper;
    using ShoppingCart.Domain.Users;
    using ShoppingCart.Infrastructure.Repositories;

    public class UsersServices : IUsersServices
    {


        private readonly IMapper _mapper;
        private UnitOfWork unitOfWork = new UnitOfWork();

        public UsersServices(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void CreateUser(UserDto userDto)
        {
           var user = _mapper.Map<User>(userDto);
            unitOfWork.UserRepository.Insert(user);
        }

        public void DeleteUser(long id)
        {
            unitOfWork.UserRepository.Delete(id);
        }

        public void UpdateUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            unitOfWork.UserRepository.Update(user);
        }

        public UserDto GetUserById(long id)
        {
            var user = unitOfWork.UserRepository.GetByID(id);

            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
