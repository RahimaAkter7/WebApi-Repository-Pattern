using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_repository.Contracts;
using web_api_repository.Models;

namespace web_api_repository.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationContext ApplicationContext) : base(ApplicationContext)
        {
        }

        public IEnumerable<Student> GetAllStudents(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public void CreateStudent(Student student) => Create(student);
    }
}
