using Microsoft.AspNetCore.Mvc;
using ReST.Attributes;
using ReST.Entities;
using ReST.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class StudentController : ControllerBase
    {

        IStudentService _studentService { get; set; }
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("add")]
        public IActionResult AddStudent(Student student)
        {
            var user = (User)HttpContext.Items["User"];
            student.AddedBy = user.Username ;

            var rollNumber = _studentService.Add(student);

            return Ok(new { rollNumber = rollNumber });
        }
    }

   
}
