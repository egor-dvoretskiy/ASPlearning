using Microsoft.AspNetCore.Mvc;

namespace Tutorial_site_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
