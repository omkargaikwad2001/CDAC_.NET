using P7_RESTUsingRepositoryPattern.Models;
using P7_RESTUsingRepositoryPattern.Repositories;

namespace CompanyMgmt.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
        public readonly CompanydbContext _ComdbCtext;
        public DepartmentRepository(CompanydbContext CompanydbContext) {
            _ComdbCtext = CompanydbContext;
        }
        public void Add(Department entity)
        {
            _ComdbCtext.Departments.Add(entity);
            _ComdbCtext.SaveChanges();
        }

        public void Delete(int id)
        {
            var dept = _ComdbCtext.Departments.Find(id);
            _ComdbCtext.Departments.Remove(dept);
            _ComdbCtext.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _ComdbCtext.Departments.ToList();

        }

        public Department GetById(int id)
        {
            return _ComdbCtext.Departments.Find(id);
        }

        public void Update(Department entity)
        {
            _ComdbCtext.Departments.Update(entity);
            _ComdbCtext.SaveChanges();
        }
    }
}
