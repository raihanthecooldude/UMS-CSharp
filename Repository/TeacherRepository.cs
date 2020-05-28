using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Repository
{
    public class TeacherRepository
    {
        public bool Insert2(Teacher a)
        {
            try
            {
                string query = "INSERT into TeacherTable VALUES ('" + a.AccountId + "', " + a.WeekHour + ",'" + a.Status + "', " + a.Salary + ")";
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
        public bool Update2(string AccountId, double salary)
        {
            try
            {
                string query = " UPDATE TeacherTable SET Salary = '" + salary + "' WHERE AccountId = '" + AccountId + "' ";
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
        public bool Update2(Teacher a)
        {
            try
            {
                string query = "UPDATE TeacherTable SET WeekHour = " + a.WeekHour + ", Status='" + a.Status + "', Salary=" + a.Salary + " WHERE AccountId= '" + a.AccountId + "'";
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
        public List<Teacher> GetAllTeacherInfo2()
        {
            string query = "SELECT * from TeacherTable";
            List<Teacher> cList = new List<Teacher>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Teacher t = new Teacher();
                t.AccountId = sdr["AccountId"].ToString();
                t.WeekHour = Convert.ToInt32(sdr["WeekHour"]);
                t.Status = sdr["Status"].ToString();
                t.Salary = Convert.ToDouble(sdr["Salary"]);
                cList.Add(t);
            }
            dcc.CloseConnection();
            return cList;
        }

        public bool UpdateStatusNadim(string accountId)
        {
            try
            {
                string query = "UPDATE TeacherTable SET Status = 'Vacation Applied' WHERE AccountId='" + accountId + "'";
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
        public bool UpdateStatusShovon(string accountId,string status,int weekhour)
        {
            try
            {
                string query = "UPDATE TeacherTable SET Status = '"+status+"',WeekHour="+weekhour+" WHERE AccountId='" + accountId + "'";
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
