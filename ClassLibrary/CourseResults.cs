using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CourseResults
    {
        private string courseName;
        private string accountId;
        private string semester;
        private string section;
        private double quiz;
        private double term;
        private double finalMark;
        private double grade;
        private string status;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
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

        public double Quiz
        {
            get { return quiz; }
            set { quiz = value; }
        }

        public double Term
        {
            get { return term; }
            set { term = value; }
        }

        public double FinalMark
        {
            get { return finalMark; }
            set { finalMark = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
