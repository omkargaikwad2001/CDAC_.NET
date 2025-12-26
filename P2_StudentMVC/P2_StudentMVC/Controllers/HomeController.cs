using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using P2_StudentMVC.Models;

namespace P2_StudentMVC.Controllers
{
    public class HomeController : Controller
    {

        // View()
        public IActionResult View1()
        {
            return View();
        }

        // View(model)
        public IActionResult View2()
        {
            Student s = new Student
            {
                Id = 1,
                Name = "Omkar",
                Age = 21,
                Marks = 88
            };

            return View(s);
        }

        // View(viewname)
        public IActionResult View3()
        {
            return View("Privacy");
        }

        // View(viewname, model)
        public IActionResult View4()
        {
            Student s = new Student
            {
                Id = 2,
                Name = "Amit",
                Age = 22,
                Marks = 92
            };

            return View("Privacy", s);
        }

        public IActionResult Index()
        {
            return View();
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
