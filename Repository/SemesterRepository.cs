using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;


namespace Repository
{
    public class SemesterRepository
    {
        public List<string> GetAllSemesterName()
        {
            string query = "SELECT * from SemesterTable";
            List<string> sList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Semester s = new Semester();
                //s.Id = sdr["SemesterId"].ToString();
                s.Name = sdr["Name"].ToString();
                sList.Add(s.Name);
            }
            dcc.CloseConnection();
            return sList;
        }

        public List<Semester> GetAllSemesters()
        {
            string query = "SELECT * from SemesterTable";
            List<Semester> sList = new List<Semester>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Semester s = new Semester();
                s.SemesterId = sdr["SemesterId"].ToString();
                s.Name = sdr["Name"].ToString();
                sList.Add(s);
            }
            dcc.CloseConnection();
            return sList;
        }

        public bool CheckIsRegistrationOpen(string name)
        {
            string query = "SELECT * from SemesterTable WHERE Name = '" + name + "' AND RegistrationStatus = 'Open'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                dcc.CloseConnection();
                return true;
            }
            else
            {
                dcc.CloseConnection();
                return false;
            }
        }

        public bool Insert2(Semester s)
        {
            try
            {
                string query = "INSERT into SemesterTable VALUES ('" + s.SemesterId + "', '" + s.Name + "', '" + s.RegistrationStatus + "')";
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
        public int Update2(Semester a, string newId)
        {
            try
            {
                string query = "UPDATE SemesterTable SET Name = '" + a.Name + "', SemesterId = '" + newId + "' WHERE SemesterId= '" + a.SemesterId + "'";
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
        public int Delete2(string SemesterId)
        {
            try
            {
                string query = "DELETE from SemesterTable WHERE SemesterId = '" + SemesterId + "'";
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
        public List<Semester> GetAllSemesters2()
        {
            string query = "SELECT * from SemesterTable";
            List<Semester> sList = new List<Semester>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Semester s = new Semester();
                s.SemesterId = sdr["SemesterId"].ToString();
                s.Name = sdr["Name"].ToString();
                s.RegistrationStatus = sdr["RegistrationStatus"].ToString();
                sList.Add(s);
            }
            dcc.CloseConnection();
            return sList;
        }
        public List<string> GetAllSemesterNames2()
        {
            string query = "SELECT * from SemesterTable";
            List<string> sList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Semester s = new Semester();
                s.SemesterId = sdr["SemesterId"].ToString();
                s.Name = sdr["Name"].ToString();
                s.RegistrationStatus = sdr["RegistrationStatus"].ToString();
                sList.Add(s.Name);
            }
            dcc.CloseConnection();
            return sList;
        }
        public bool CheckSemester2(string SemsesterName)
        {
            string query = "SELECT * from SemesterTable WHERE Name = '" + SemsesterName + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                dcc.CloseConnection();
                return true;
            }
            else
            {
                dcc.CloseConnection();
                return false;
            }
        }
        public bool CheckIsRegistrationOpen2(string SemsesterName)
        {
            string query = "SELECT * from SemesterTable WHERE Name = '" + SemsesterName + "' AND RegistrationStatus = 'Open'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            dcc.CloseConnection();
            if (sdr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int UpdateRegistrationStatus2(string semesterId, string status)
        {
            try
            {
                string query = "UPDATE SemesterTable SET RegistrationStatus = '" + status + "' WHERE SemesterId = '" + semesterId + "'";
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
        public Semester GetSemester2(string SemesterId)
        {
            string query = "SELECT * from SemesterTable WHERE SemesterId = '" + SemesterId + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            Semester s = new Semester();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                s.SemesterId = sdr["SemesterId"].ToString();
                s.Name = sdr["Name"].ToString();
                s.RegistrationStatus = sdr["RegistrationStatus"].ToString();
            }
            dcc.CloseConnection();
            return s;
        }
    }
}
