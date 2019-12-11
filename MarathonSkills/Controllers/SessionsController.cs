using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarathonSkills.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MarathonSkills.Models;

namespace MarathonSkills.Controllers
{
    public class SessionsController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        public SessionsController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult New()
        {
            return View();
        }

        public async Task<IActionResult> CreateAsync(SessionViewModel model)
        {
            //var findResult = await userManager.FindByIdAsync(model.Email);
            var singInResult = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false) ;
            if (singInResult.Succeeded)
            {
                return View();
            }
            
            return View();
        }

        public IActionResult Destroy()
        {
            return View();
        }
    }
}