using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_Assignment
{
    class Course
    {
        public List<Student> students = new List<Student>();
        private Teacher[] teachers = new Teacher[3];
        public Teacher[] Teachers
        {
            get
            {
                return teachers;
            }

            set
            {
                teachers = value;
            }
        }

        public string courseName { get; set; }
        public string teacher { get; set; }
        public int credits { get; set; }
        public int durInWeeks { get; set; }

        public void ListStudents()
        {
            foreach (Student st in students)
            {
                Console.WriteLine("Name: {0} ; LastName: {1};", st.FirstName, st.LastName);
            }
        }

    }
}
