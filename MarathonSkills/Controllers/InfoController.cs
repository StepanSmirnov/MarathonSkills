using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MarathonSkills.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.ReturnUrl = Url.ActionLink("Index", "Info");
            return View();
        }
    }
}