using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P7_RESTUsingRepositoryPattern.Models;
using P7_RESTUsingRepositoryPattern.Repositories;


namespace CompanyMgmt.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public readonly IRepository<Department> _repo;
        public DepartmentController(IRepository<Department> repo) { 
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAllDept()
        {
            return Ok(_repo.GetAll());
        }
        [HttpGet]
        public IActionResult GetDept(int id)
        {
            return Ok(_repo.GetById(id));
        }
        [HttpPost]
        public IActionResult SaveDept(Department department)
        {
            _repo.Add(department);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDept(Department department)
        {
            _repo.Update(department);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDept(int id)
        {
            _repo.Delete(id);
            return Ok();
        }

    }
}
