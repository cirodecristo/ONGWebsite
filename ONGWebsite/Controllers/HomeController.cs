using Microsoft.AspNetCore.Mvc;

namespace ONGWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
