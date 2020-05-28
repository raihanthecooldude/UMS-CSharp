using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Repository
{
    public class ExamRepository
    {
        public bool Insert2(Exam e)
        {
            try
            {
                string query = "INSERT into ExamTable VALUES ('" + e.CourseId + "', '" + e.Semester + "', '" + e.Day + "', '" + e.Slot + "', '" + e.Room + "', '" + e.AssignedFacultyId + "')";
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
        public bool CheckExamCourseId2(string CourseId)
        {
            string query = "SELECT * from ExamTable WHERE CourseId = '" + CourseId + "'";
            Exam e = new Exam();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                e = new Exam();
                e.CourseId = sdr["CourseId"].ToString();
                e.Semester = sdr["Semester"].ToString();
                e.Day = sdr["Day"].ToString();
                e.Slot = sdr["Slot"].ToString();
                e.AssignedFacultyId = sdr["AssignedFacultyId"].ToString();
                e.Room = sdr["Room"].ToString();
                return true;
            }
            dcc.CloseConnection();
            return false;
        }
        public bool Update2(Exam e)
        {
            try
            {
                string query = " UPDATE ExamTable SET Semester = '" + e.Semester + "', Day = '" + e.Day + "', Slot = '" + e.Slot + "', Room = '" + e.Room + "', AssignedFacultyId = '" + e.AssignedFacultyId + "' WHERE CourseId = '" + e.CourseId + "' ";
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
        public int Delete2(string CourseId)
        {
            try
            {
                string query = "DELETE from ExamTable WHERE CourseId = '" + CourseId + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return x;
            }
            catch
            {
                return 0;
            }
        }
        public List<Exam> GetAllExams2()
        {
            string query = "SELECT * from ExamTable";
            List<Exam> eList = new List<Exam>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Exam e = new Exam();
                e.CourseId = sdr["CourseId"].ToString();
                e.Semester = sdr["Semester"].ToString();
                e.Day = sdr["Day"].ToString();
                e.Slot = sdr["Slot"].ToString();
                e.Room = sdr["Room"].ToString();
                e.AssignedFacultyId = sdr["AssignedFacultyId"].ToString();
                eList.Add(e);
            }
            dcc.CloseConnection();
            return eList;
        }
    }
}
