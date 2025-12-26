using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [NonAction] //will be ignored by mvc
        public string Test()
        {
            return "Testing...";

        }

        [ActionName("greet")]
        public string Greet()
        {
            return "Hello User";
        }

        [ActionName("hello")]
        public string GetStudent()
        {
            return "Hello Omkar...";
        }

        public IActionResult Student()
        {
            return View();
        }

        public IActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult register(string sname, int smarks) {
            
            ViewBag.sname = sname;
            ViewBag.smarks = smarks;

            return View();
        }

    }
}
