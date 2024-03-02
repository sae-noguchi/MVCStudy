using Microsoft.AspNetCore.Mvc;
using MVCstudy.Models;
using System.Diagnostics;

namespace MVCstudy.Controllers
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
            ViewBag.Message = "Ç±ÇÒÇ…ÇøÇÕÅAê¢äE";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Lesson()
        {
            ViewBag.Message = "Ç±ÇÒÇ…ÇøÇÕÅAê¢äE";
            return View();
        }

        public IActionResult ToDOList()
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
