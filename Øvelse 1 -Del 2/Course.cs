using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_1__Del_2
{
    internal class Course
    {
        public string CourseName;
       
        //public int Teacherinfo;
        public Course(string courseName)
        {
            CourseName = courseName;
           

        }
        public override string ToString()  // ToString  gør at teksten kommer frem hver gang jeg kører programmet //
        {
            return CourseName;
        }
    }
}
