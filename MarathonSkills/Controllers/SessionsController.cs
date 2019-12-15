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
            SessionViewModel viewModel = new SessionViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(SessionViewModel model)
        {
            await signInManager.SignOutAsync();
            //var findResult = await userManager.FindByIdAsync(model.Email);
            var singInResult = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false) ;
            if (singInResult.Succeeded)
            {
                var user = await userManager.FindByNameAsync(model.Email);
                if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    return Redirect(model.ReturnUrl);
                var claims = await signInManager.ClaimsFactory.CreateAsync(user);
                if (claims.IsInRole("Runner"))
                {
                    return View("~/Views/Menus/RunnerMenu.cshtml");
                }
                else if (claims.IsInRole("Coordinator"))
                {
                    return View("~/Views/Menus/CoordinatorMenu.cshtml");
                }
                else if (claims.IsInRole("Administrator"))
                {
                    return View("~/Views/Menus/AdministratorMenu.cshtml");
                }
            }
            ModelState.AddModelError("", "Неправильный логин и (или) пароль");
            return View("New", model);
            }

        public async Task<IActionResult> Destroy()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}