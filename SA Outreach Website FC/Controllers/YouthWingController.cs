using Microsoft.AspNetCore.Mvc;

namespace SA_Outreach_Website.Controllers
{
    public class YouthWingController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/YouthWings.cshtml");
        }
    }
}
