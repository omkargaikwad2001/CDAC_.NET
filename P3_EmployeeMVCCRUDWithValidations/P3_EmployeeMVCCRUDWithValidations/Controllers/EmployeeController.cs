using Microsoft.AspNetCore.Mvc;
using P3_EmployeeMVCCRUDWithValidations.Models;

namespace P3_EmployeeMVCCRUDWithValidations.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var db = new DotnetContext();
            List<Employee> emplist = db.Employees.ToList();
            return View(emplist);
        }

        [HttpGet]
        public IActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveEmp(Employee e)
        {
            //if (!string.IsNullOrWhiteSpace(e.Ename) && e.Ename.StartsWith("S"))
            //{
            //    ModelState.AddModelError("Ename", "Emp Name should not start with S");
            //}

            //if (ModelState.IsValid)
            //{
                var db = new DotnetContext();
                db.Employees.Add(e);
                db.SaveChanges();
                return RedirectToAction("Index");
            //}

            //return View("AddEmp", e);
        }



        public IActionResult EditEmp(int id)
        {
            var db = new DotnetContext();
            Employee e = db.Employees.Find(id);
            return View(e);
        }

        [HttpPost]
        public IActionResult EditEmp(Employee e)
        {
            var db = new DotnetContext();
            db.Employees.Update(e);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult DeleteEmp(int id)
        {
            var db = new DotnetContext();
            Employee e = db.Employees.Find(id);
            db.Employees.Remove(e);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
