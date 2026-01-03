using Microsoft.AspNetCore.Mvc;

namespace CancerCare.WebApp.Models
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
