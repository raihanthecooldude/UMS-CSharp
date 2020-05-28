using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CourseAssign
    {
        private string accountId;
        private string assignedCourse;
        private string semester;
        private string section;

        public string AccountId 
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string AssignedCourse 
        {
            get { return assignedCourse; }
            set { assignedCourse = value; }
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
    }
}
