using Microsoft.AspNetCore.Mvc;
using SA_Outreach_Website.Models;
using System.Diagnostics;

namespace SA_Outreach_Website.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View(); // This returns the 'AboutUs.cshtml' view from the Views/Home folder
        }

        public IActionResult ProjectsAndPrograms()
        {
            return View();
        }

        public IActionResult EventsPage()
        {
            return View();
        }

        public IActionResult FlyingWings()
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
