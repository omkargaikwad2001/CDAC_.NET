using P7_RESTUsingRepositoryPattern.Models;
using P7_RESTUsingRepositoryPattern.Repositories;

namespace CompanyMgmt.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public readonly CompanydbContext _ComdbCtext;
        public EmployeeRepository(CompanydbContext CompanydbContext)
        {
            _ComdbCtext = CompanydbContext;
        }
        public void Add(Employee entity)
        {
            _ComdbCtext.Employees.Add(entity);
            _ComdbCtext.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = _ComdbCtext.Employees.Find(id);
            _ComdbCtext.Employees.Remove(emp);
            _ComdbCtext.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _ComdbCtext.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _ComdbCtext.Employees.Find(id);
        }

        public void Update(Employee entity)
        {
            _ComdbCtext.Employees.Update(entity);
            _ComdbCtext.SaveChanges();
        }
    }
}
