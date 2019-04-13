using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTful.Models;

namespace RESTful.Controllers
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

        //POST: api/REST
        [HttpPost]
        public IActionResult PostStu(Student stu)
        {
                Manage.GetContent().Add(stu);
                return Ok();
            
        }

        //PUT: api/REST/5
        [HttpPut("{id}")]
        public IActionResult PutStudent(int id, Student stu)
        {
            if (Manage.GetContent().GetOneStudent(id) == null)
            { 
            Manage.GetContent().Add(stu);
            return Ok();
            }
            else
                Manage.GetContent().UpdateStudent(stu);
            return Ok();
        }

        //DELETE: api/REST/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok(Manage.GetContent().Remove(id));
        }
    }
}
