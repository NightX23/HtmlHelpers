using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlHelpers.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Person p)
        {
            if (ModelState.IsValid)
            {
                return View(p);
            }
            return View();

        }
    }
}