using Microsoft.AspNetCore.Mvc;

namespace SA_Outreach_Website.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/ContactUs.cshtml");
        }
    }
}
