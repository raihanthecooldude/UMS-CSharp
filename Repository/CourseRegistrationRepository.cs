using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Repository
{
    public class CourseRegistrationRepository
    {
        public List<CourseRegistration> GetAllCourseInfo(string semester, string ID)
        {
            string query = "SELECT * from CourseRegistrationTable WHERE Semester= '" + semester + "' AND AccountId= '" + ID + "'";
            List<CourseRegistration> courseList = new List<CourseRegistration>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseRegistration c = new CourseRegistration();
                c.CourseId = sdr["CourseId"].ToString();
                c.CourseName = sdr["CourseName"].ToString();
                c.Section = sdr["Section"].ToString();
                c.AccountId = sdr["AccountId"].ToString();
                c.Status = sdr["Status"].ToString();
                courseList.Add(c);
            }
            dcc.CloseConnection();
            return courseList;
        }

        public List<string> GetOnlyCourses(string semester, string ID)
        {
            string query = "SELECT * from CourseRegistrationTable WHERE Semester= '" + semester + "' AND AccountId= '" + ID + "'";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseRegistration c = new CourseRegistration();
                c.CourseId = sdr["CourseId"].ToString();
                c.CourseName = sdr["CourseName"].ToString();
                c.Section = sdr["Section"].ToString();
                c.AccountId = sdr["AccountId"].ToString();
                c.Status = sdr["Status"].ToString();
                cList.Add(c.CourseName);
            }
            dcc.CloseConnection();
            return cList;
        }

        public List<string> GetOnlySection(string semester, string ID, string course)
        {
            string query = "SELECT * from CourseRegistrationTable WHERE Semester= '" + semester + "' AND AccountId= '" + ID + "'AND CourseName= '" + course + "'";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseRegistration c = new CourseRegistration();
                c.CourseId = sdr["CourseId"].ToString();
                c.CourseName = sdr["CourseName"].ToString();
                c.Section = sdr["Section"].ToString();
                c.AccountId = sdr["AccountId"].ToString();
                c.Status = sdr["Status"].ToString();
                cList.Add(c.Section);
            }
            dcc.CloseConnection();
            return cList;
        }

        public List<string> GetOnlyID(string semester, string ID, string course, string section)
        {
            string query = "SELECT * from CourseRegistrationTable WHERE Semester= '" + semester + "' AND CourseName= '" + course + "' AND Section= '" + section + "'";
            List<string> courseList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseRegistration c = new CourseRegistration();
                c.CourseId = sdr["CourseId"].ToString();
                c.CourseName = sdr["CourseName"].ToString();
                c.Section = sdr["Section"].ToString();
                c.AccountId = sdr["AccountId"].ToString();
                c.Status = sdr["Status"].ToString();

                if (c.AccountId != ID)
                {
                    courseList.Add(c.AccountId);
                }
            }
            dcc.CloseConnection();
            return courseList;
        }

        public List<CourseRegistration> GetAllStudents(string semester, string course, string section)
        {
            string query = "SELECT * from CourseRegistrationTable WHERE Semester='" + semester + "'AND CourseName='" + course + "' AND Section='" + section + "'";
            List<CourseRegistration> cList = new List<CourseRegistration>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseRegistration cr = new CourseRegistration();

                cr.CourseId = sdr["CourseId"].ToString();
                cr.CourseName = sdr["CourseName"].ToString();
                cr.Semester = sdr["Semester"].ToString();
                cr.Section = sdr["Section"].ToString();
                cr.AccountId = sdr["AccountId"].ToString();
                cr.Status = sdr["Status"].ToString();

                cList.Add(cr);
            }
            dcc.CloseConnection();
            return cList;
        }

        public bool DoRegistration(string ID, string courseId, string semester, string section, string courseName)
        {
            try
            {
                string query = "INSERT INTO CourseRegistrationTable (CourseId, Semester, Section, AccountId, CourseName, Status) VALUES ('" + courseId + "', '" + semester + "', '" + section + "', '" + ID + "', '" + courseName + "', 'Confirm')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }

        string s;
        public bool Insert2(CourseRegistration a)
        {
            try
            {
                string query = "INSERT into CourseRegistrationTable VALUES ('" + a.CourseId + "', '" + a.CourseName + "', '" + a.Semester + "', '" + a.Section + "', '" + a.AccountId + "', '" + a.Status + "')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string CourseVerification2(string courseId)
        {
            string query = "SELECT * from CourseTable WHERE CourseId= '" + courseId + "'";
            Course a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                a = new Course();
                a.CourseId = sdr["CourseId"].ToString();
                // a.Name = sdr["Name"].ToString();
                // a.Name = sdr["Name"].ToString();
                // a.Gender = sdr["Gender"].ToString();
                // a.Address = sdr["Address"].ToString();
                // a.AccountType = sdr["AccountType"].ToString();
                //  a.BloodGroup = sdr["BloodGroup"].ToString();
                // a.Dob = sdr["DOB"].ToString(); ;

            }
            dcc.CloseConnection();
            try
            {
                s = a.CourseId;
            }
            catch
            {

            }
            return s;
        }
        public List<Course> GetAllCourse2(string accountid, string sname)
        {
            string query = "SELECT Name,Schedule from CourseTable WHERE CourseId IN (SELECT CourseId from CourseRegistrationTable WHERE AccountId='" + accountid + "' AND Semester='" + sname + "')";
            List<Course> aList = new List<Course>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course a = new Course();

                a.Name = sdr["Name"].ToString();
                a.Schedule = sdr["Schedule"].ToString();


                aList.Add(a);
            }
            dcc.CloseConnection();
            return aList;
        }
        public bool RoutineVerification2(string accountid, string sname)
        {
            string query = "SELECT CourseId from CourseRegistrationTable WHERE AccountId='" + accountid + "' AND Semester='" + sname + "'";
            Course a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {

                a = new Course();
                dcc.CloseConnection();
                return true;


            }

            else
            {
                dcc.CloseConnection();
                return false;
            }

        }

        public bool DropCourse(string ID, string semester, string courseName)
        {
            try
            {
                string query = "UPDATE CourseRegistrationTable SET Status = 'Apply Drop' WHERE AccountId= '" + ID + "' AND Semester= '" + semester + "' AND CourseName= '" + courseName + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<string> GetOnlyCourses(string semester)
        {
            string query = "SELECT * from CourseRegistrationTable WHERE Semester= '" + semester + "'";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseRegistration c = new CourseRegistration();
                c.CourseId = sdr["CourseId"].ToString();
                c.CourseName = sdr["CourseName"].ToString();
                c.Section = sdr["Section"].ToString();
                c.AccountId = sdr["AccountId"].ToString();
                c.Status = sdr["Status"].ToString();
                cList.Add(c.CourseName);
            }
            dcc.CloseConnection();
            return cList;
        }
        public List<CourseRegistration> GetAllCourses2()
        {
            string query = "SELECT * from CourseRegistrationTable";
            List<CourseRegistration> cList = new List<CourseRegistration>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseRegistration c = new CourseRegistration();
                c.CourseId = sdr["CourseId"].ToString();
                c.CourseName = sdr["CourseName"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Section = sdr["Section"].ToString();
                c.AccountId = sdr["AccountId"].ToString();
                c.Status = sdr["Status"].ToString();
                cList.Add(c);
            }
            dcc.CloseConnection();
            return cList;
        }
        public List<string> DoubleIDRegistrationVerify(string ID, string courseid)
        {
            string query = "SELECT * from CourseRegistrationTable WHERE CourseId= '" + courseid + "' AND AccountId= '" + ID + "'";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseRegistration c = new CourseRegistration();
                c.CourseId = sdr["CourseId"].ToString();
                c.CourseName = sdr["CourseName"].ToString();
                c.Section = sdr["Section"].ToString();
                c.AccountId = sdr["AccountId"].ToString();
                c.Status = sdr["Status"].ToString();
                cList.Add(c.AccountId);
            }
            dcc.CloseConnection();
            return cList;
        }
        public CourseRegistration GetCourse2(string CourseId)
        {
            string query = "SELECT * from CourseTable WHERE CourseId = '" + CourseId + "'";
            CourseRegistration c = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                c = new CourseRegistration();
                c.CourseId = sdr["CourseId"].ToString();
                c.CourseName = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Section = sdr["Section"].ToString();
               
            }
            dcc.CloseConnection();
            return c;
        }

    }
}
