using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_Assignment
{
    class Teacher : Person
    {
        public int testGraded { get; set; }

        public Teacher()
        {

            testGraded = 0;
        }

        void GradeTest()
        {
            testGraded++;
        }

    }
}
