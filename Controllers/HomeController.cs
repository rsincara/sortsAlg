﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SortingAlgorithmsASP.Models;

namespace SortingAlgorithmsASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) { _logger = logger; }

        public IActionResult Index() { return View(); }

        public IActionResult Qsort(string value)
        {
            if(value!=null)
                TextModel.WordsByHoare=TextModel.GetDictionarySortedByHoare(value);
            return View();
        }

        public IActionResult Bsort(string value)
        {
            if(value!=null)
                TextModel.WordsByBubble=TextModel.GetDictionarySortedByBubble(value);
            return View();
        }

        public IActionResult Privacy() { return View(); }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
