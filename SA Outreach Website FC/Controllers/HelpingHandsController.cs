using Microsoft.AspNetCore.Mvc;

namespace SA_Outreach_Website.Controllers
{
    public class HelpingHandController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/HelpingHands.cshtml");
        }
    }
}
