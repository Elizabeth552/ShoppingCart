using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using ShoppingCart.Infrastructure;
using ShoppingCart.Infrastructure.Data.EF.Entities;
using ShoppingCartServices.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSingleton(ConfigureMapperService());
static IMapper ConfigureMapperService()
{
    var mapperServiceConfigureation = new MapperConfiguration(cfg =>
    {
        cfg.AddProfile<AutoMapperProfile>();
    });

    mapperServiceConfigureation.AssertConfigurationIsValid();

    return mapperServiceConfigureation.CreateMapper();
}

builder.Services.AddMvc(options => options.EnableEndpointRouting = false)
    .AddNewtonsoftJson(o => o.SerializerSettings.ContractResolver = new DefaultContractResolver());
builder.Services.AddDbContext<ShoppingCartDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<UserEntity, RoleEntity>(
        options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequiredUniqueChars = 0;

        }
        )
    .AddEntityFrameworkStores<ShoppingCartDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.MapControllers();
}

app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();
app.UseMvc(routes =>
{
    // need route and attribute on controller: [Area("Blogs")]
    routes.MapRoute(name: "mvcAreaRoute",
                    template: "{area:exists}/{controller=Home}/{action=Index}");

    // default route for non-areas
    routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
});


app.Run();
