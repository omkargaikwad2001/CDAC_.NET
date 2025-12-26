using Microsoft.AspNetCore.Mvc;
using P2_StudentMVC.Models;

namespace P2_StudentMVC.Controllers
{
    public class StudentAddressController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student
            {
                Id = 1,
                Name = "Omkar",
                Age = 21,
                Marks = 90
            };

            Address a = new Address
            {
                AddressId = 101,
                City = "Pune",
                State = "Maharashtra",
                Pincode = 411001
            };

            StudentAddressViewModel vm = new StudentAddressViewModel
            {
                Student = s,
                Address = a
            };

            return View(vm);
        }
    }
}
