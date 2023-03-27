using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Photos()
        {
            return View();
        }
    }
}
