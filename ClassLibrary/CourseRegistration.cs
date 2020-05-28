using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CourseRegistration
    {
        private string courseId;
        private string courseName;
        private string semester;
        private string section;
        private string accountId;
        private string status;

        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string Semester
        {
            get{return semester;}
            set{semester=value;}
        }

        public string Section
        {
            get{return section;}
            set{section=value;}
        }

        public string AccountId
        {
            get{return accountId;}
            set{accountId=value;}
        }

        public string Status
        {
            get{return status;}
            set{status=value;}
        }
    }
}
