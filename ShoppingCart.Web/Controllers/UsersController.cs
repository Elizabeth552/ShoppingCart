﻿namespace ShoppingCart.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using ShoppingCart.Domain.Users;
    using ShoppingCart.Infrastructure.Data.EF.Entities;
    using ShoppingCart.Web.Models;
    using ShoppingCart.Web.Models.Users;

    [ApiController]
    [Route("api/v/[controller]")]
    public class UsersController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<RoleEntity> _roleManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly IMapper _mapper;
        public UsersController(UserManager<UserEntity> userManager, RoleManager<RoleEntity> roleManager, SignInManager<UserEntity> signInManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModel = new List<UserRolesViewModel>();
            foreach (UserEntity user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesViewModel.Add(thisViewModel);
            }
            return View(userRolesViewModel);
        }
        private async Task<List<string>> GetUserRoles(UserEntity user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("LoginPost")]
        public async Task<IActionResult> LoginPost([FromForm] LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, lockoutOnFailure: true);
            return View();
        }

        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("RegisterPost")]
        public async Task<IActionResult> RegisterPost([FromForm] RegisterViewModel model)
        {
            var user = _mapper.Map<User>(model);
            user.PopulateCreatedAtDate();
            var userEntity = _mapper.Map<UserEntity>(user);
            var result = await _userManager.CreateAsync(userEntity, model.Password);

            //await _userManager.AddToRoleAsync(user, "Visitor");
            return View();
        }
    }
}
