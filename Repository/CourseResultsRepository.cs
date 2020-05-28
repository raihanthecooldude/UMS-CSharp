using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Repository
{
    public class CourseResultsRepository
    {
        public List<CourseResults> GetAllResult(string ID)
        {
            string query = "SELECT * from CourseResultsTable WHERE AccountId= '" + ID + "'";
            List<CourseResults> cgList = new List<CourseResults>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseResults c = new CourseResults();
                //c.CourseName = sdr["CourseName"].ToString();
                //c.Section = sdr["Section"].ToString();
                //c.Quiz = Convert.ToDouble(sdr["Quiz"]);
                //c.Term = Convert.ToDouble(sdr["Term"]);
                //c.FinalMark = Convert.ToDouble(sdr["FinalMark"]);
                c.Grade = Convert.ToDouble(sdr["Grade"]);
                c.Status = sdr["Status"].ToString();
                cgList.Add(c);
            }
            dcc.CloseConnection();
            return cgList;
        }

        public List<CourseResults> GetAllResult(string semester, string ID)
        {
            string query = "SELECT * from CourseResultsTable WHERE Semester= '" + semester + "' AND AccountId= '" + ID + "'";
            List<CourseResults> gList = new List<CourseResults>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseResults c = new CourseResults();
                c.CourseName = sdr["CourseName"].ToString();
                c.Section = sdr["Section"].ToString();
                c.Quiz = Convert.ToDouble(sdr["Quiz"]);
                c.Term= Convert.ToDouble(sdr["Term"]);
                c.FinalMark = Convert.ToDouble(sdr["FinalMark"]);
                c.Grade = Convert.ToDouble(sdr["Grade"]);
                c.Status = sdr["Status"].ToString();
                gList.Add(c);
            }
            dcc.CloseConnection();
            return gList;
        }

        //public bool DropCourse(string ID, string semester, string courseName)
        //{
        //    try
        //    {
        //        string query = "UPDATE CourseResultsTable SET Status = 'Apply Drop' WHERE AccountId= '" + ID + "' AND Semester= '" + semester + "' AND CourseName= '" + courseName + "'";
        //        DatabaseConnectionClass dcc = new DatabaseConnectionClass();
        //        dcc.ConnectWithDB();
        //        int x = dcc.ExecuteSQL(query);
        //        dcc.CloseConnection();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public bool UpdateQuizMark(CourseResults a)
        {
            try
            {
                string query = "UPDATE CourseResultsTable SET  Quiz= '" + a.Quiz + "'  WHERE AccountId= '" + a.AccountId + "' AND CourseName = '" + a.CourseName + "' AND Section='" + a.Section + "' AND Semester='" + a.Semester + "'";
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
        public bool UpdateTermMark(CourseResults a)
        {
            try
            {
                string query = "UPDATE CourseResultsTable SET  Term= '" + a.Term + "' , FinalMark = '" + a.FinalMark + "' , Grade='" + a.Grade + "' WHERE AccountId= '" + a.AccountId + "' AND CourseName = '" + a.CourseName + "' AND Section='" + a.Section + "' AND Semester='" + a.Semester + "'";
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
        public double GetQuizMark(CourseResults cr)
        {
            string query = "SELECT * from CourseResultsTable WHERE AccountId= '" + cr.AccountId + "' AND CourseName='" + cr.CourseName + "' AND Semester='" + cr.Semester + "' AND Section='" + cr.Section + "'";
            double quizMark = 0;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                quizMark = Convert.ToDouble(sdr["Quiz"]);
            }
            dcc.CloseConnection();
            return quizMark;
        }
        public List<CourseResults> GetAllDroppedStudent(string semester, string course, string section)
        {
            string query = "SELECT * from CourseResultsTable WHERE Semester='" + semester + "' AND CourseName='" + course + "' AND Section='" + section + "'";
            List<CourseResults> cList = new List<CourseResults>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseResults c = new CourseResults();
                c.CourseName = sdr["CourseName"].ToString();
                c.Section = sdr["Section"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.AccountId = sdr["AccountId"].ToString();
                c.Quiz = Convert.ToDouble(sdr["Quiz"]);
                c.Term = Convert.ToDouble(sdr["Term"]);
                c.FinalMark = Convert.ToDouble(sdr["FinalMark"]);
                c.Grade = Convert.ToDouble(sdr["Grade"]);
                c.Status = sdr["Status"].ToString();

                cList.Add(c);

            }
            dcc.CloseConnection();
            return cList;
        }
        public bool UpdateStatus(CourseResults c)
        {
            try
            {
                string query = "UPDATE CourseResultsTable SET Status = '" + c.Status + "' WHERE AccountId= '" + c.AccountId + "' AND CourseName = '" + c.CourseName + "' AND Section='" + c.Section + "' AND Semester='" + c.Semester + "'";
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

        public bool DoReg(string ID, string courseId, string semester, string section, string courseName)
        {
            try
            {
                string query = "INSERT INTO CourseResultsTable (Semester, Section, AccountId, CourseName, Status) VALUES ('"+semester + "', '" + section + "', '" + ID + "', '" + courseName + "', 'Active')";
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
    }
}
