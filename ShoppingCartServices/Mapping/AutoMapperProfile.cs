namespace ShoppingCartServices.Mapping
{
    using AutoMapper;
    using ShoppingCart.Domain.BoundedContext.Users;
    using ShoppingCartServices.Users;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.ShoppingCart, opt => opt.Ignore())
                .ForMember(dest => dest.Products, opt => opt.Ignore());

        }
    }
}
