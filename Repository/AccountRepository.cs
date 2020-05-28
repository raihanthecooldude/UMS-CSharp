using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Repository
{
    public class AccountRepository
    {
        /*public bool Insert(Account a)
        {
            try
            {
                string query = "INSERT into Accounts VALUES ('" + a.AccountId + "', " + a.Password + "', '" + a.AccountName + "', " + a.Salary + ", '" + a.Designation + "')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }*/
        /*public bool Update(Account a)
        {
            try
            {
                string query = "UPDATE Accounts SET AccountName = '" + a.AccountName + "', Salary = " + a.Salary + ", Designation = '" + a.Designation + "' WHERE AccountId= '" + a.AccountId + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }*/
        /*public bool Delete(string AccountId)
        {
            try
            {
                string query = "DELETE from Accounts WHERE AccountId = '" + AccountId + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }*/
        /*public Account GetAccount(string AccountId)
        {
            string query = "SELECT * from Accounts WHERE AccountId= '" + AccountId + "'";
            Account a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.AccountName = sdr["AccountName"].ToString();
                a.Salary = Convert.ToDouble(sdr["Salary"]);
                a.Designation = sdr["Designation"].ToString();
            }
            dcc.CloseConnection();
            return a;
        }*/

        /*public List<Account> GetAllAccounts()
        {
            string query = "SELECT * from Accounts";
            List<Account> aList = new List<Account>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.AccountName = sdr["AccountName"].ToString();
                a.Salary = Convert.ToDouble(sdr["Salary"]);
                a.Designation = sdr["Designation"].ToString();
                aList.Add(a);
            }
            dcc.CloseConnection();
            return aList;
        }*/
        public Account UserLoginVerification(Account a)
        {
            string query = "SELECT * from AccountTable WHERE AccountId= '" + a.AccountId + "' AND Password= '" + a.Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                a.Name = sdr["Name"].ToString();
                //a.Gender = Convert.ToDouble(sdr["Salary"]);
                //a.Address = sdr["Designation"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                dcc.CloseConnection();
                return a;
            }
            else
            {
                dcc.CloseConnection();
                return a;
            }
        }


        public Account GetAccount(string AccountId)
        {
            string query = "SELECT * from AccountTable WHERE AccountId= '" + AccountId + "'";
            Account a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.DOB = sdr["DOB"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
            }
            dcc.CloseConnection();
            return a;
        }

        public bool Insert2(Account a)
        {
            try
            {
                string query = "INSERT into AccountTable VALUES ('" + a.AccountId + "', '" + a.Password + "', '" + a.Name + "', '" + a.DOB + "', '" + a.BloodGroup + "', '" + a.Gender + "', '" + a.Address + "', '" + a.AccountType + "')";
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

        public string GetAccountType2(string AccountId)
        {
            string query = "SELECT * from AccountTable WHERE AccountId= '" + AccountId + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            string AccountType = "";
            if (sdr.Read())
            {
                AccountType = sdr["AccountType"].ToString();
            }
            dcc.CloseConnection();
            return AccountType;
        }
        public Account GetAccountTypeShovon2(string AccountId)
        {
            string query = "SELECT * from AccountTable WHERE AccountId= '" + AccountId + "'";
            Account a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.DOB = sdr["DOB"].ToString(); ;

            }
            dcc.CloseConnection();
            return a;
        }
        public List<Account> GetAllAccounts2(string type)
        {
            string query = "SELECT * from AccountTable";
            List<Account> aList = new List<Account>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.DOB = sdr["DOB"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                if (a.AccountType == type)
                {
                    aList.Add(a);
                }
            }
            dcc.CloseConnection();
            return aList;
        }
        public List<Account> GetAllAccounts3(string type)
        {
            string query = "SELECT * from AccountTable";
            List<Account> aList = new List<Account>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.DOB = sdr["DOB"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                if (a.AccountType == type)
                {
                    
                }
                else
                {
                    aList.Add(a);
                }
            }
            dcc.CloseConnection();
            return aList;
        }
        public List<Account> SearchByStudentId2(string AccountId)
        {
            string query = "SELECT * from AccountTable where AccountId = '" + AccountId + "'";
            List<Account> aList = new List<Account>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.DOB = sdr["DOB"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                if (a.AccountType == "Student")
                {
                    aList.Add(a);
                }
            }
            dcc.CloseConnection();
            return aList;
        }
        public List<Account> SearchByStudentName2(string Name)
        {
            string query = "SELECT * from AccountTable where Name = '" + Name + "'";
            List<Account> aList = new List<Account>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.DOB = sdr["DOB"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                if (a.AccountType == "Student")
                {
                    aList.Add(a);
                }
            }
            dcc.CloseConnection();
            return aList;
        }
        public List<string> GetAccountIds2(string type)
        {
            string query = "SELECT * from AccountTable where AccountType = '" + type + "'";
            List<string> sList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.DOB = sdr["DOB"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                sList.Add(a.AccountId);
            }
            dcc.CloseConnection();
            return sList;
        }
        public List<string> GetAccountIdAndNames2(string type)
        {
            string query = "SELECT * from AccountTable where AccountType = '" + type + "'";
            List<string> sList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.DOB = sdr["DOB"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                sList.Add(a.AccountId + " " + a.Name);
            }
            dcc.CloseConnection();
            return sList;
        }
        public string UserLoginVerification2(Account a)
        {
            string query = "SELECT * from AccountTable WHERE AccountId= '" + a.AccountId + "' AND Password= '" + a.Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                //a.Name = sdr["AccountName"].ToString();
                //a.Gender = Convert.ToDouble(sdr["Salary"]);
                //a.Address = sdr["Designation"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                dcc.CloseConnection();
                return a.AccountType;
            }
            else
            {
                dcc.CloseConnection();
                return "false";
            }
        }
        public List<Account> SearchAccounts2(string text)
        {
            string query = "SELECT * from AccountTable WHERE AccountId LIKE '%" + text + "%' OR Name LIKE '%" + text + "%'";
            List<Account> aList = new List<Account>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.DOB = sdr["DOB"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                if (a.AccountType == "Student")
                {
                    aList.Add(a);
                }
            }
            dcc.CloseConnection();
            return aList;
        }
        public List<string> DoubleAccountIDRegistrationVerify()
        {
            string query = "SELECT * from AccountTable ";
            List<string> sList = new List<string>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Account a = new Account();
                a.AccountId = sdr["AccountId"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Gender = sdr["Gender"].ToString();
                a.DOB = sdr["DOB"].ToString();
                a.BloodGroup = sdr["BloodGroup"].ToString();
                a.Address = sdr["Address"].ToString();
                a.AccountType = sdr["AccountType"].ToString();
                sList.Add(a.AccountId);
            }
            dcc.CloseConnection();
            return sList;
        }
        }
    }


