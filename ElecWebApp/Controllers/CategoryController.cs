using Microsoft.AspNetCore.Mvc;

namespace ElecWebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
