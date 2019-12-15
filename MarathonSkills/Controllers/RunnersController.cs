using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarathonSkills.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarathonSkills.Controllers
{
    public class RunnersController : Controller
    {
        private readonly Models.MarathonSkillsContext context;

        public RunnersController(Models.MarathonSkillsContext context)
        {
            this.context = context;
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
    }
}