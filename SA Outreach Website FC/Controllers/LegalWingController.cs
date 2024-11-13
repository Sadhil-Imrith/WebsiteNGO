using Microsoft.AspNetCore.Mvc;

namespace SA_Outreach_Website.Controllers
{
    public class LegalWingController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/LegalWings.cshtml");
        }
    }
}
