using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;
using Repository;

namespace Repository
{
    public class ChatRepository
    {
        public bool SendMsg(string ID,string id, string msg, string User)
        {
            try
            {
                string query = "INSERT INTO ChatTable (AccountId, Msg) VALUES ('" + id + "', '" + User + " : " + msg + "')";
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

        public List<Chat> GetMsg(string id)
        {
            string query = "SELECT * from ChatTable WHERE AccountId= '" + id + "'";
            List<Chat> cList = new List<Chat>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Chat ch = new Chat();
                //ch.AccountId = sdr["AccountId"].ToString();
                ch.Msg = sdr["Msg"].ToString();
                cList.Add(ch);
            }
            dcc.CloseConnection();
            return cList;
        }
    }
}
