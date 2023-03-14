namespace ShoppingCartServices.Mapping
{
    using AutoMapper;
    using ShoppingCart.Domain.Products;
    using ShoppingCart.Domain.Users;
    using ShoppingCart.Infrastructure.Data.EF.Entities;
    using ShoppingCart.Web.Dtos;
    using ShoppingCart.Web.Models.Users;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<User, UserDto>()
            //    .ForMember(dest => dest.ShoppingCart, opt => opt.Ignore())
            //    .ForMember(dest => dest.Products, opt => opt.Ignore());
            //CreateMap<Product, ProductDto>();

            CreateMap<RegisterViewModel, UserEntity>()
                .ForMember(dest => dest.CreatedAt , opt => opt.MapFrom(s => DateTime.Now))
                .ForMember(dest => dest.Products, opt => opt.Ignore())
                .ForMember(dest=> dest.ShoppingCart, opt => opt.MapFrom(s=> new ShoppingCart()));

        }
    }
}
