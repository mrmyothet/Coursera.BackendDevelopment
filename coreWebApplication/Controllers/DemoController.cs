﻿using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Method1()
        {
            TempData["Message"] = "Demo - Data Passing Techniques - TempData";

            return View();
        }

        public IActionResult Method2()
        {
            if (TempData["Message"] is null)
            { 
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
