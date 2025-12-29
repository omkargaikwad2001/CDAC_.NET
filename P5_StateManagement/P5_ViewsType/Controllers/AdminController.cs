using Microsoft.AspNetCore.Mvc;

namespace ViewTypes.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
