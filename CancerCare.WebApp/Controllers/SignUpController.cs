using Microsoft.AspNetCore.Mvc;

namespace CancerCare.WebApp.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
