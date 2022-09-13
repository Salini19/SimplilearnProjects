using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseAssignmnets
{
    public class Subject : Teacher
    {

        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public Teacher Teacher;
    }
}
