using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Exam
    {
        private string courseId;
        private string semester;
        private string day;
        private string slot;
        private string room;
        private string assignedFacultyId;

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
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Slot
        {
            get { return slot; }
            set { slot = value; }
        }
        public string Room
        {
            get { return room; }
            set { room = value; }
        }
        public string AssignedFacultyId
        {
            get { return assignedFacultyId; }
            set { assignedFacultyId = value; }
        }

    }
}
