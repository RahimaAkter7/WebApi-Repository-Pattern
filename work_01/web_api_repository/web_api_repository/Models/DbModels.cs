using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_repository.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfStudents { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
