using Microsoft.AspNetCore.Mvc;
using ReverseName.Models;
using System.Diagnostics;

namespace ReverseName.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReverseN(string Name)
        {
            var reverse = new string(Name.Reverse().ToArray());
            ViewData["RN"] = reverse;
            return View("Index");
        }
    }
}