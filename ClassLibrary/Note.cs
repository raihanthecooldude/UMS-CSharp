using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Note
    {
        private string courseName;
        private string section;
        private string semester;
        private string notePath;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        public string NotePath
        {
            get { return notePath; }
            set { notePath = value; }
        }
    }
}
