using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Repository
{
    public class CourseAssignRepository
    {
       public List<CourseAssign> GetAllSections(string accountId,string semseter)
        {
            string query = "SELECT * from CourseAssignTable WHERE AccountId='"+accountId+"' AND Semester='"+semseter+"'";
            List<CourseAssign> cList = new List<CourseAssign>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                CourseAssign c = new CourseAssign();
                c.AccountId = sdr["AccountId"].ToString();
                c.AssignedCourse = sdr["AssignedCourse"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Section = sdr["Section"].ToString();

                cList.Add(c);

            }
            dcc.CloseConnection();
            return cList;
        }

       public bool Insert2(CourseAssign s)
       {
           try
           {
               string query = "INSERT into CourseAssignTable VALUES ('" + s.AccountId + "', '" + s.AssignedCourse + "', '" + s.Semester + "', '" + s.Section + "')";
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
       public List<CourseAssign> GetAllAssignedCourses2()
       {
           string query = "SELECT * from CourseAssignTable";
           List<CourseAssign> sList = new List<CourseAssign>();
           DatabaseConnectionClass dcc = new DatabaseConnectionClass();
           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);
           while (sdr.Read())
           {
               CourseAssign s = new CourseAssign();
               s.AccountId = sdr["AccountId"].ToString();
               s.AssignedCourse = sdr["AssignedCourse"].ToString();
               s.Semester = sdr["Semester"].ToString();
               s.Section = sdr["Section"].ToString();
               sList.Add(s);
           }
           dcc.CloseConnection();
           return sList;
       }
       public bool CheckAssignedCourse2(CourseAssign s)
       {
           string query = "SELECT * from CourseAssignTable WHERE AccountId = '" + s.AccountId + "' AND AssignedCourse = '" + s.AssignedCourse + "' AND Section = '" + s.Section + "' AND Semester = '" + s.Semester + "'";
           DatabaseConnectionClass dcc = new DatabaseConnectionClass();
           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);
           if (sdr.Read())
           {
               dcc.CloseConnection();
               return false;
           }
           else
           {
               dcc.CloseConnection();
               return true;
           }
       }
    }
}
