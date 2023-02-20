namespace ShoppingCartServices.Users
{
    using AutoMapper;
    using ShoppingCart.Domain.BoundedContext.Users;
    using ShoppingCart.Infrastructure.Repositories;

    public class UsersServices : IUsersServices
    {


        private readonly IMapper _mapper;
        private UnitOfWork unitOfWork = new UnitOfWork();

        public UsersServices(IMapper mapper)
        {
            _mapper = mapper;
        }

        public UserDto CreateUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(long id)
        {
            var user = unitOfWork.UserRepository.GetByID(id);

            // Map user to UserDto
            var userDto = _mapper.Map<UserDto>(user);
            return user;
        }
    }
}
