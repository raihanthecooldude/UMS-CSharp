using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Data.SqlClient;
using Repository;

namespace UMS
{
    public partial class OfferedCourses : Form
    {
        private string ID, User;
        public OfferedCourses(string ID, string User)
        {
            InitializeComponent();
            this.ID = ID;
            this.User = User;
            this.NameLabel.Text = "Welcome " + User;
            SemesterRepository sr = new SemesterRepository();
            this.SemesterComboBox.DataSource = sr.GetAllSemesterName();
        }

        private void BackClicked(object sender, EventArgs e)
        {
            StudentHome sh = new StudentHome(ID, User);
            sh.Show();
            this.Hide();
        }

        private void LogOutClicked(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = SemesterComboBox.Text;
            int i;

            CourseRepository cr = new CourseRepository();
            List<Course> cList = new List<Course>();

            cList = cr.GetAllCourses(semester, ID);
            DataTable cTable = new DataTable();
            cTable.Columns.Add("Department", typeof(string));
            cTable.Columns.Add("Course ID", typeof(string));
            cTable.Columns.Add("Course Name", typeof(string));
            cTable.Columns.Add("Section", typeof(string));
            cTable.Columns.Add("Maximum Student", typeof(int));
            cTable.Columns.Add("Current Student", typeof(int));
            cTable.Columns.Add("Credit", typeof(double));
            cTable.Columns.Add("Schedule", typeof(string));

            for (i = 0; i < cList.Count; i++)
            {
                cTable.Rows.Add(cList[i].Department, cList[i].CourseId, cList[i].Name, cList[i].Section, cList[i].MaxStudent, cList[i].CurrentStudent, cList[i].Credit, cList[i].Schedule);
            }

            OfferedCoursesGridView.DataSource = cTable;
            OfferedCoursesGridView.ReadOnly = true;
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
