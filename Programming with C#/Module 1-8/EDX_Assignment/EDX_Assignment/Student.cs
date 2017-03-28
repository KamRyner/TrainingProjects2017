using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_Assignment
{
    class Student : Person
    {

        private Stack<string> grades = new Stack<string>();

        void TakeTest()
        {
            Console.WriteLine("TestTaken");
        }

        public static ushort StudentsEnrrolled
        {
            get
            {
                return studentsEnrrolled;
            }

            set
            {
                studentsEnrrolled = value;
            }
        }

        public Stack<string> Grades
        {
            get
            {
                return grades;
            }

            set
            {
                grades = value;
            }
        }

        private static ushort studentsEnrrolled = 0;

        public Student()
        {
            StudentsEnrrolled++;
        }

    }
}
