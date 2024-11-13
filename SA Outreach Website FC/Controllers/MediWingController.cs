using Microsoft.AspNetCore.Mvc;

namespace SA_Outreach_Website.Controllers
{
    public class MediWingController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/MediWings.cshtml");
        }
    }
}
