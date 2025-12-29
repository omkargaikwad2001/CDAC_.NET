using Microsoft.AspNetCore.Mvc;

namespace P5_StateManagement.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            TempData["data"] = "I  have visited EMployeepage";
            ViewBag.Message = "I  have visited EMployeepage using VieBag";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index1()
        {
            int? sid = HttpContext.Session.GetInt32("sid");

            ViewData["sid"] = sid;
            return View();
        }
    }
}
