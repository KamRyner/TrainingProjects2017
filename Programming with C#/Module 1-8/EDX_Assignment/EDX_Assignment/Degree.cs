using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_Assignment
{
    class Degree
    {
        
string degName;
        int creditsReq;
        Course course;

        public string DegName
        {
            get
            {
                return degName;
            }

            set
            {
                degName = value;
            }
        }

        public int CreditsReq
        {
            get
            {
                return creditsReq;
            }

            set
            {
                creditsReq = value;
            }
        }

        public Course Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }
    }
}
