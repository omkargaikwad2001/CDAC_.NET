using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P7_RESTUsingRepositoryPattern.Models;
using P7_RESTUsingRepositoryPattern.Repositories;

namespace CompanyMgmt.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IRepository<Employee> _repo;
        public EmployeeController(IRepository<Employee> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAllEmp()
        {
            return Ok(_repo.GetAll());
        }
        [HttpGet]
        public IActionResult GetEmp(int id)
        {
            return Ok(_repo.GetById(id));
        }
        [HttpPost]
        public IActionResult SaveEmp(Employee emp)
        {
            _repo.Add(emp);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateEmp(Employee emp)
        {
            _repo.Update(emp);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmp(int id)
        {
            _repo.Delete(id);
            return Ok();
        }

    }
}
