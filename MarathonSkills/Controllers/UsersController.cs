using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarathonSkills.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MarathonSkills.Controllers
{
    public class UsersController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private MarathonSkillsContext context;

        public UsersController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager, SignInManager<User> signInManager, MarathonSkillsContext context)
        {
            this.roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            this.context = context;
        }

        public IActionResult Index()
        {
            //User user = new User() { Email = "sssprogramer@gmail.com", FirstName = "Stepan", LastName = "Smirnov" };
            //_userManager.CreateAsync(user, "");

            //foreach (var tempUser in context.TempUser)
            //{
            //    var user = new User() { UserName = tempUser.Email, Email = tempUser.Email, FirstName = tempUser.FirstName, LastName = tempUser.LastName };
            //    _userManager.CreateAsync(user, tempUser.Password).Wait();
            //    _userManager.AddToRoleAsync(user, context.Roles.Find(tempUser.RoleId[0]).RoleName).Wait();
            //    //_userManager.Dispose();
            //}
            //context.SaveChanges();
            return View();
        }
    }
}