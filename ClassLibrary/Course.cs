using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Course
    {
        private string courseId;
        private string name;
        private string semester;
        private string department;
        private string section;
        private int maxStudent;
        private int currentStudent;
        private double credit;
        private string schedule;

        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        public int MaxStudent
        {
            get { return maxStudent; }
            set { maxStudent = value; }
        }

        public int CurrentStudent
        {
            get { return currentStudent; }
            set { currentStudent = value; }
        }

        public double Credit
        {
            get { return credit; }
            set { credit = value; }
        }

        public string Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }
    }
}
