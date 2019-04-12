using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTful.Models;

namespace RESTful.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        //GET: api/REST
        [HttpGet]
        public List<Student>GetStudents()
        {
            return Manage.GetContent().GetAllStudent();
        }

        //GET: api/REST/5
        [HttpGet("{id}")]
        public Student GetOneStudents(int id)
        {
            return Manage.GetContent().GetOneStudent(id);
        }
    }
}
