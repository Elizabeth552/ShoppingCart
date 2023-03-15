namespace ShoppingCartServices.Mapping
{
    using AutoMapper;
    using ShoppingCart.Domain.Users;
    using ShoppingCart.Infrastructure.Data.EF.Entities;
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
                .DisableCtorValidation();

            CreateMap<User, UserEntity>()
                .ForMember(dest => dest.Street, opt => opt.MapFrom(s => s.UserAddress.Street))
                .ForMember(dest => dest.City, opt => opt.MapFrom(s => s.UserAddress.City))
                .ForMember(dest => dest.HouseNumber, opt => opt.MapFrom(s => s.UserAddress.HouseNumber))
                .ForMember(dest => dest.ShoppingCart, opt => opt.MapFrom(s => s.ShoppingCart))
                .ForMember(dest => dest.AccessFailedCount, opt => opt.Ignore())
                .ForMember(dest => dest.LockoutEnd, opt => opt.Ignore())
                .ForMember(dest => dest.LockoutEnabled, opt => opt.Ignore())
                .ForMember(dest => dest.TwoFactorEnabled, opt => opt.Ignore())
                .ForMember(dest => dest.EmailConfirmed, opt => opt.Ignore())
                .ForMember(dest => dest.PhoneNumberConfirmed, opt => opt.Ignore())
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(s => s.Email))
                .ForMember(dest => dest.NormalizedUserName, opt => opt.MapFrom(s => s.Email))
                .ForMember(dest => dest.NormalizedEmail, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
                .ForMember(dest => dest.SecurityStamp, opt => opt.Ignore())
                .ForMember(dest => dest.ConcurrencyStamp, opt => opt.Ignore())
                .ForMember(dest => dest.Products, opt => opt.Ignore())
                .ForMember(dest => dest.IsEnabled, opt => opt.Ignore());

            CreateMap<ShoppingCart, ShoppingCartEntity>()
                .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(s => s.TotalAmount))
                .ForMember(dest => dest.User, opt => opt.Ignore());


        }
    }
}
