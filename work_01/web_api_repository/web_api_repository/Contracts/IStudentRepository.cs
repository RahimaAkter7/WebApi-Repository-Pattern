using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_repository.Models;

namespace web_api_repository.Contracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents(bool trackChanges);
        void CreateStudent(Student student);
    }
}
