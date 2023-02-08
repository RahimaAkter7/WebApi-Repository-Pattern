using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_repository.Contracts
{
    public interface IRepositoryManager
    {
        IDepartmentRepository Department { get; }
        IStudentRepository Student { get; }
        void Save();
    }
}
