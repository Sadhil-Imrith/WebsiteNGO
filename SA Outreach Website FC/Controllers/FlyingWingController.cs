using Microsoft.AspNetCore.Mvc;

namespace SA_Outreach_Website.Controllers
{
    public class FlyingWingController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/FlyingWings.cshtml");
        }
    }
}
