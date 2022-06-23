using ReST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReST.Services
{
    public interface IStudentService
    {
        int Add(Student student);
    }

    public class StudentService : IStudentService
    {
         List<Student> _lstStudents = new List<Student>();
         int _rollNumberCounter = 1;
        public int Add(Student student)
        {
            student.RollNumber = _rollNumberCounter++;
            _lstStudents.Add(student);
            return student.RollNumber;
        }
    }
}
