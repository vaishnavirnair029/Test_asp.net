using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
