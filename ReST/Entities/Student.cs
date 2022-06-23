using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReST.Entities
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public string Div { get; set; }
        public string AddedBy { get; set; }
    }
}
