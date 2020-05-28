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
    public class NoteRepository
    {
        public List<Note> GetAllNotes(string semester, string courseName)
        {
            string query = "SELECT * from NoteTable WHERE Semester= '" + semester + "' AND CourseName= '" + courseName + "'";
            List<Note> nList = new List<Note>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                Note n = new Note();
                n.CourseName = sdr["CourseName"].ToString();
                n.NotePath = sdr["NotePath"].ToString();
                n.Semester = sdr["Semester"].ToString();
                n.Section = sdr["Section"].ToString();
                nList.Add(n);
            }
            dcc.CloseConnection();
            return nList;
        }
    }
}
