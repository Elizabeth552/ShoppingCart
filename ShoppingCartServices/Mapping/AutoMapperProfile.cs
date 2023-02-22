namespace ShoppingCartServices.Mapping
{
    using AutoMapper;
    using ShoppingCart.Domain.BoundedContext.Users;
    using ShoppingCart.Domain.BoundedContext.Products;
    using ShoppingCartServices.Users;
    using ShoppingCartServices.Products;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.ShoppingCart, opt => opt.Ignore())
                .ForMember(dest => dest.Products, opt => opt.Ignore());
            CreateMap<Product, ProductDto>();
        }
    }
}
