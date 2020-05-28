using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Notice
    {
        private string courseId;
        private string semester;
        private string section;
        private string notice;
        private string date;

        public string CourseId 
        {
            get { return courseId; }
            set { courseId = value; }
        }
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        public string Noticee
        {
            get { return notice; }
            set { notice = value; }
        }
        public string Date 
        {
            get { return date; }
            set { date = value; }
        }
    }
}
