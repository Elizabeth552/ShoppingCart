namespace ShoppingCartServices.Mapping
{
    using AutoMapper;
    using ShoppingCart.Domain.Users;
    using ShoppingCart.Web.Models.Users;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<User, UserDto>()
            //    .ForMember(dest => dest.ShoppingCart, opt => opt.Ignore())
            //    .ForMember(dest => dest.Products, opt => opt.Ignore());
            //CreateMap<Product, ProductDto>();

            CreateMap<RegisterViewModel, User>()
                .ForMember(dest => dest.UserAddress, opt => opt.MapFrom(s => new UserAddress()
                {
                    Street = s.Street,
                    City = s.City,
                    HouseNumber = s.HouseNumber
                }))
                .ForMember(dest => dest.ShoppingCart, opt => opt.MapFrom(s => new ShoppingCart()))
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.Products, opt => opt.Ignore())
                .DisableCtorValidation();

        }
    }
}
