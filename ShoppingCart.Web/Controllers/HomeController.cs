namespace ShoppingCart.Web.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using ShoppingCart.Web.Models;
    using ShoppingCartServices.Users;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUsersServices _usersServices;

        public HomeController(ILogger<HomeController> logger, IUsersServices usersServices)
        {
            _logger = logger;
            _usersServices = usersServices;
        }

        public IActionResult Index()
        {
            var user = _usersServices.GetUserById(1L);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}