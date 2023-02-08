using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_repository.Contracts;
using web_api_repository.Models;

namespace web_api_repository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;

        public StudentsController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _repository.Student.GetAllStudents(trackChanges: false);
            return Ok(students);
        }

        [HttpPost]
        public IActionResult CreateStudents()
        {
            var student = new Student
            {
                Name = "Emmanuel Nzekwe"
            };

            _repository.Student.CreateStudent(student);
            _repository.Save();
            return Ok();
        }


    }
}
