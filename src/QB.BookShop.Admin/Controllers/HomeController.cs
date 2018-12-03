using Microsoft.AspNetCore.Mvc;

namespace QB.BookShop.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TestEdit()
        {
            return View();
        }
    }
}
