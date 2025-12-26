using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // ================================
        // 1️ ViewResult Examples
        // ================================

        // view()
        public IActionResult View1()
        {
            return View();
        }

        // view(model)
        public IActionResult View2()
        {
            string msg = "Hello from Model";
            return View(msg);
        }

        // view(viewname)
        public IActionResult View3()
        {
            return View("Privacy");
        }

        // view(viewname, model)
        public IActionResult View4()
        {
            string data = "Passing model with view name";
            return View("Privacy", data);
        }

        // ================================
        // 2️ JsonResult
        // ================================
        public JsonResult JsonData()
        {
            var student = new
            {
                Id = 1,
                Name = "Omkar",
                Marks = 85
            };

            return Json(student);
        }

        // ================================
        // 3️ RedirectToActionResult
        // ================================
        public IActionResult GoToPrivacy()
        {
            return RedirectToAction("Privacy");
        }

        // ================================
        // 4️ ContentResult (String + HTML)
        // ================================

        // Plain string
        public ContentResult Content1()
        {
            return Content("This is plain text response");
        }

        // HTML content
        public ContentResult Content2()
        {
            return Content("<h2 style='color:green'>This is HTML Content</h2>", "text/html");
        }

        // ================================
        // 5️ FileResult
        // ================================
        public IActionResult DownloadFile()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/sample.txt");
            return File(fileBytes, "text/plain", "sample.txt");
        }

        // ================================
        // 6️ StatusCodeResult
        // ================================
        public IActionResult Status()
        {
            return StatusCode(404); // Not Found
        }

        // ================================
        // Default Actions
        // ================================
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
