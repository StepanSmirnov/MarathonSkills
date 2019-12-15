using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MarathonSkills.Controllers
{
    public class RunnersController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult AskNewAccount()
        {
            return View();
        }
    }
}