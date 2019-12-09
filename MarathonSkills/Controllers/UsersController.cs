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
            return View();
        }
    }
}