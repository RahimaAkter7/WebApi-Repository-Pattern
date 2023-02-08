using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_repository.Contracts;
using web_api_repository.Models;

namespace web_api_repository.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationContext ApplicationContext) : base(ApplicationContext)
        {
        }
        public IEnumerable<Department> GetAllDepartments(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public void CreateDepartment(Department department) => Create(department);
    }
}
