using Microsoft.AspNetCore.Mvc;

namespace CancerCare.WebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
