using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarathonSkills.Models;
using MarathonSkills.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarathonSkills.Controllers
{
    public class RunnersController : Controller
    {
        private readonly Models.MarathonSkillsContext context;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public RunnersController(Models.MarathonSkillsContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IActionResult AskNewAccount()
        {
            return View();
        }

        public IActionResult New()
        {
            RunnerViewModel viewModel = new RunnerViewModel();
            viewModel.Genders = new SelectList(context.Genders.ToList(), "GenderName", "GenderName");
            viewModel.Countries = new SelectList(context.Countries.ToList(), "CountryCode", "CountryName");
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(RunnerViewModel viewModel)
        {
            viewModel.Genders = new SelectList(context.Genders.ToList(), "GenderName", "GenderName");
            viewModel.Countries = new SelectList(context.Countries.ToList(), "CountryCode", "CountryName");

            if (ModelState.IsValid)
            {
                if (viewModel.Password != viewModel.PasswordConfirmation)
                {
                    ModelState.AddModelError(string.Empty, "Введенные пароли не совпадают");
                    return View("New", viewModel);
                }

                User user = new User { Email = viewModel.Email, UserName = viewModel.Email, FirstName = viewModel.FirstName, LastName = viewModel.LastName };
                IdentityResult userResult = await userManager.CreateAsync(user, viewModel.Password);
                if (userResult.Succeeded)
                {
                    IdentityResult roleResult = await userManager.AddToRoleAsync(user, "Runner");
                    if (roleResult.Succeeded)
                    {
                        Runner runner = new Runner() { 
                            UserId = user.Id, 
                            Gender = viewModel.Gender,
                            DateOfBirth = viewModel.DateOfBirth,
                            CountryCode = viewModel.CountryCode 
                        };
                        context.Runners.Add(runner);
                        context.SaveChanges();
                        return View("RegistrationSuccess");
                    }
                    else
                    {
                        foreach (var error in roleResult.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                else
                {
                    foreach (var error in userResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View("New", viewModel);
        }
    }
}