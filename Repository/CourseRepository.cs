using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Repository
{
    public class CourseRepository
    {
        public List<Course> GetAllCourses(string semester, string ID)
        {
            string query = "SELECT * from CourseTable WHERE Semester= '" + semester + "'";
            List<Course> cList = new List<Course>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToDouble(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                cList.Add(c);
            }
            dcc.CloseConnection();
            return cList;
        }

        public Course GetCourseId(string courseName, string semester, string section)
        {
            string query = "SELECT * from CourseTable WHERE Name= '" + courseName + "' AND Semester ='" + semester + "' AND Section='" + section + "'";
            Course a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                a = new Course();
                a.CourseId = sdr["CourseId"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Semester = sdr["Semester"].ToString();
                a.Department = sdr["Department"].ToString();
                a.Section = sdr["Section"].ToString();
                a.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                a.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                a.Credit = Convert.ToInt32(sdr["Credit"]);
                a.Schedule = sdr["Schedule"].ToString();
            }
            dcc.CloseConnection();
            return a;
        }

        public List<Course> GetCourseIdStudent(string course, string semester, string section)
        {
            string query = "SELECT * from CourseTable WHERE Name= '" + course + "' AND Semester ='" + semester + "' AND Section='" + section + "'";
            List<Course> cList = new List<Course>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToDouble(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                cList.Add(c);
            }
            dcc.CloseConnection();
            return cList;
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

        public List<string> GetOnlySection(string semester, string course)
        {
            string query = "SELECT * from CourseRegistrationTable WHERE Semester= '" + semester + "'AND CourseName= '" + course + "'";
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

        public bool Increase2(string s)
        {
            try
            {
                string query = "UPDATE CourseTable SET CurrentStudent =CurrentStudent+1 WHERE CourseId='" + s + "' ";
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
        public bool Insert2(Course c)
        {
            try
            {
                string query = "INSERT into CourseTable VALUES ('" + c.CourseId + "', '" + c.Name + "', '" + c.Semester + "', '" + c.Department + "', '" + c.Section + "', '" + c.MaxStudent + "', '" + c.CurrentStudent + "', '" + c.Credit + "', '" + c.Schedule + "')";
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
        public bool Update2(Course c, string NewCourseId)
        {
            try
            {
                string query = " UPDATE CourseTable SET CourseId = '" + NewCourseId + "', Name = '" + c.Name + "', Semester = '" + c.Semester + "', Department = '" + c.Department + "', Section = '" + c.Section + "', MaxStudent = '" + c.MaxStudent + "', CurrentStudent = '" + c.CurrentStudent + "', Credit = '" + c.Credit + "', Schedule = '" + c.Schedule + "' WHERE CourseId = '" + c.CourseId + "' ";
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
        public bool Delete2(string CourseId)
        {
            try
            {
                string query = "DELETE from CourseTable WHERE CourseId = '" + CourseId + "'";
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
        public Course GetCourse2(string CourseId)
        {
            string query = "SELECT * from CourseTable WHERE CourseId = '" + CourseId + "'";
            Course c = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
            }
            dcc.CloseConnection();
            return c;
        }
        public List<string> GetCourseNames2()
        {
            string query = "SELECT * from CourseTable";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                cList.Remove(c.Name);
                cList.Add(c.Name);
            }
            dcc.CloseConnection();
            return cList;
        }
        public List<string> GetCourseNamesBySemester2(string Semester)
        {
            string query = "SELECT * from CourseTable WHERE Semester = '" + Semester +"'";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                cList.Remove(c.Name);
                cList.Add(c.Name);
            }
            dcc.CloseConnection();
            return cList;
        }
        public List<string> GetALLSections2()
        {
            string query = "SELECT * from CourseTable";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                cList.Remove(c.Section);
                cList.Add(c.Section);
            }
            dcc.CloseConnection();
            return cList;
        }
        public List<string> GetALLSectionsByCourseNameAndSemester2(string Name, string Semester)
        {
            string query = "SELECT * from CourseTable WHERE Name = '" + Name +"' AND Semester = '" + Semester + "'";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                cList.Remove(c.Section);
                cList.Add(c.Section);
            }
            dcc.CloseConnection();
            return cList;
        }
        public List<Course> GetAllCourses2()
        {
            string query = "SELECT * from CourseTable";
            List<Course> cList = new List<Course>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                cList.Add(c);
            }
            dcc.CloseConnection();
            return cList;
        }
        public bool CheckCourse2(Course s)
        {
            string query = "SELECT * from CourseTable WHERE Name = '" + s.Name + "' AND Semester = '" + s.Semester + "' AND Section = '" + s.Section + "'";
            Course c = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                return true;
            }
            dcc.CloseConnection();
            return false;
        }
        public List<string> GetCourseIds2()
        {
            string query = "SELECT * from CourseTable";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                cList.Add(c.CourseId);
            }
            dcc.CloseConnection();
            return cList;
        }
        public List<string> GetCourseIdNameSectionsBySemester2(string Semester)
        {
            string query = "SELECT * from CourseTable WHERE Semester = '" + Semester + "'";
            List<string> cList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Course c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                cList.Add(c.CourseId + " " + c.Name + " [" + c.Section + "]");
            }
            dcc.CloseConnection();
            return cList;
        }
        public bool CheckCourseIdAndSemesterName2(Course s)
        {
            string query = "SELECT * from CourseTable WHERE CourseId = '" + s.CourseId + "' AND Semester = '" + s.Semester + "'";
            Course c = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                c = new Course();
                c.CourseId = sdr["CourseId"].ToString();
                c.Name = sdr["Name"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Department = sdr["Department"].ToString();
                c.Section = sdr["Section"].ToString();
                c.MaxStudent = Convert.ToInt32(sdr["MaxStudent"]);
                c.CurrentStudent = Convert.ToInt32(sdr["CurrentStudent"]);
                c.Credit = Convert.ToInt32(sdr["Credit"]);
                c.Schedule = sdr["Schedule"].ToString();
                return true;
            }
            dcc.CloseConnection();
            return false;
        }

        public string GetOnlySchedule(string semester, string courseName, string section)
        {
            string query = "SELECT * from CourseTable WHERE Name = '" + courseName + "' AND Semester = '" + semester + "' AND Section='" + section + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            string schedule = "";
            if (sdr.Read())
            {
                schedule = sdr["Schedule"].ToString();
            }
            dcc.CloseConnection();
            return schedule;
        }
    }
}
