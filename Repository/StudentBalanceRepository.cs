using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Repository
{
    public class StudentBalanceRepository
    {
        public bool Insert2(StudentBalance a)
        {
            try
            {
                string query = "INSERT into StudentBalanceTable VALUES ('" + a.AccountId + "', '" + a.Semester + "','" + a.Scholarship + "', " + a.Balance + ",'" + a.Validation + "')";
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
        public bool UpdateScholarshipPercentage2(StudentBalance s)
        {
            try
            {
                string query = "UPDATE StudentBalanceTable SET Scholarship = '" + s.Scholarship + "' WHERE AccountId= '" + s.AccountId + "'";
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
        public bool UpdateScholarshipEligible2(StudentBalance s)
        {
            try
            {
                string query = "UPDATE StudentBalanceTable SET Scholarship = '" + s.Scholarship + "' WHERE AccountId= '" + s.AccountId + "'";
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
        public bool UpdateInvalide2(StudentBalance s)
        {
            try
            {
                string query = "UPDATE StudentBalanceTable SET Validation = 'Valid', Balance = '"+ s.Balance +"' WHERE AccountId = '" + s.AccountId + "'";
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
        public List<string> GetAccountIdsScholarshipApprove2()
        {
            string query = "SELECT * from StudentBalanceTable WHERE Scholarship = 'Eligible For Scholarship'";
            List<string> sList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                StudentBalance s = new StudentBalance();
                s.AccountId = sdr["AccountId"].ToString();
                s.Semester = sdr["Semester"].ToString();
                s.Scholarship = sdr["Scholarship"].ToString();
                s.Balance = Convert.ToDouble(sdr["Balance"]);
                s.Validation = sdr["Validation"].ToString();
                sList.Add(s.AccountId);
            }
            dcc.CloseConnection();
            return sList;
        }
        public List<string> GetAccountIdsInvalid2()
        {
            string query = "SELECT * from StudentBalanceTable WHERE Validation = 'Invalid'";
            List<string> sList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                StudentBalance s = new StudentBalance();
                s.AccountId = sdr["AccountId"].ToString();
                s.Semester = sdr["Semester"].ToString();
                s.Scholarship = sdr["Scholarship"].ToString();
                s.Balance = Convert.ToDouble(sdr["Balance"]);
                s.Validation = sdr["Validation"].ToString();
                sList.Add(s.AccountId);
            }
            dcc.CloseConnection();
            return sList;
        }
        public bool UpdateStudentBalance(StudentBalance s)
        {
            try
            {
                string query = "UPDATE StudentBalanceTable  SET Balance =Balance+5000 WHERE AccountId = '" + s.AccountId + "' ";
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
        public float GetBalance(string AccountId)
        {
            string query = "SELECT * from StudentBalanceTable  WHERE AccountId= '" + AccountId + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            float Balance = 0;
            if (sdr.Read())
            {
                Balance = float.Parse(sdr["Balance"].ToString());
            }
            dcc.CloseConnection();
            return Balance;
        }

    }
}
