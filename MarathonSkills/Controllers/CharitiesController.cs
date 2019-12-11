using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarathonSkills.Models;
using MarathonSkills.Utils;
using MarathonSkills.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MarathonSkills.Controllers
{
    public class CharitiesController : Controller
    {
        private readonly Models.MarathonSkillsContext context;
        private PagesManager<Charity> pagesManager;
        private PagesViewModel<Charity> pagesViewModel;

        public CharitiesController(Models.MarathonSkillsContext context)
        {
            this.context = context;
            pagesViewModel = new PagesViewModel<Charity>();
            pagesViewModel.Data = new PageData()
            {
                ControllerName = "Charities",
                ActionName = "Index",
                ButtonsLimit = 6
            };
            pagesManager = new PagesManager<Charity>(context.Charities, 5);
        }

        public IActionResult Index(int page = 1)
        {
            pagesViewModel.Items = pagesManager.LoadPage(page);
            pagesViewModel.Data.CurrentPage = page;
            pagesViewModel.Data.PagesCount = pagesManager.PagesCount();
            return View(pagesViewModel);
        }
    }
}