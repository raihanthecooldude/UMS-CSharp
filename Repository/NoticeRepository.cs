using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Data.SqlClient;

namespace Repository
{
    public class NoticeRepository
    {
        public bool Insert(Notice a)
        {
            try
            {
                string query = "INSERT into NoticeTable VALUES ('"+a.CourseId+"','"+ a.Section +"','"+ a.Semester+"','"+a.Noticee+"','"+ a.Date +"')";
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

        public List<Notice> GetAllNotice(string semester, string courseId, string section)
        {
            string query = "SELECT * from NoticeTable WHERE Semester= '" + semester + "' AND CourseId= '" + courseId + "' AND Section= '" + section + "'";
            List<Notice> cList = new List<Notice>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Notice c = new Notice();
                c.CourseId = sdr["CourseId"].ToString();
                c.Semester = sdr["Semester"].ToString();
                c.Section = sdr["Section"].ToString();
                c.Noticee = sdr["Notice"].ToString();
                c.Date = sdr["Date"].ToString();
                cList.Add(c);
            }
            dcc.CloseConnection();
            return cList;
        }
    }
}
