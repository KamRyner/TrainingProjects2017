using EDX_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Teacher teacher1 = new Teacher();
            Course cour = new Course();
            Degree deg = new Degree();
            UProgram uprog = new UProgram();
            cour.courseName = "Programming with C#";

            #region studentsData
            student1.FirstName = "James";
            student1.LastName = "Cameron";
            student2.FirstName = "Cloe";
            student2.LastName = "Decker";
            student3.FirstName = "Robert";
            student3.LastName = "De Niro";
            #endregion

            cour.students.Add(student1);
            cour.students.Add(student2);
            cour.students.Add(student3);
            cour.Teachers[0] = teacher1;
            deg.DegName = "Bachelor of Computer Science";
            deg.Course = cour;
            uprog.programName = "Information Technology";
            uprog.degrees = deg;
            Console.WriteLine("The {0} program contains the {1} degree", uprog.programName, deg.DegName);
            Console.WriteLine("The {0} degree contains the course {1}", deg.DegName, cour.courseName);
            Console.WriteLine("The {0} course contains {1} student(s)", cour.courseName, Student.StudentsEnrrolled);
            cour.ListStudents();

        }
    }
}
