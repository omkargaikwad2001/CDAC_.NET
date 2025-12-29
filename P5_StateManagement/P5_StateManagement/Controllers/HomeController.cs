using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using P5_StateManagement.Models;

namespace P5_StateManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            // TempData.Keep(); stores data for one more request


            _logger = logger;
        }

        public IActionResult Index()
        {
            Response.Cookies.Append("user", "student");
            Response.Cookies.Append("userid", "10", new CookieOptions
            {
                Expires = DateTime.Now.AddDays(2),
                HttpOnly = true
            });

            HttpContext.Session.SetInt32("sid", 34566);
            return View();
        }

        public IActionResult Privacy()
        {
            string user = Request.Cookies["user"];
            int id;
            int.TryParse(Request.Cookies["userid"], out id);

            ViewBag.Id = id;
            ViewBag.User = user;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
