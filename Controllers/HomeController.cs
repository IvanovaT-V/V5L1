using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using V5L1.Models;

namespace V5L1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Repository Repository = Repository.SharedRepository;
        public IActionResult Index() => View(Repository.SharedRepository.Links.Where(p => p?.Name != null));

        [HttpGet]
        public IActionResult AddLink() => View(new Link());
        [HttpPost]
        public IActionResult AddLink(Link r)
        {
            Repository.AddLink(r);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
