using Microsoft.AspNetCore.Mvc;

namespace CancerCare.WebApp.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
