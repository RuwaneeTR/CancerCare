using Microsoft.AspNetCore.Mvc;

namespace CancerCare.WebApp.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
