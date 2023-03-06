namespace ShoppingCartServices.Mapping
{
    using AutoMapper;
    using ShoppingCart.Domain.Products;
    using ShoppingCart.Domain.Users;
    using ShoppingCart.Web.Dtos;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<User, UserDto>()
            //    .ForMember(dest => dest.ShoppingCart, opt => opt.Ignore())
            //    .ForMember(dest => dest.Products, opt => opt.Ignore());
            //CreateMap<Product, ProductDto>();
        }
    }
}
