using AutoMapper;
using ShoppingCart.Infrastructure;
using ShoppingCartServices.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ShoppingCartDbContext>();


builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddSingleton(ConfigureMapperService());

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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
