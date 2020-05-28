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
    public partial class CourseInfo : Form
    {
        private string ID, User;
        public CourseInfo(string ID, string User)
        {
            InitializeComponent();
            this.ID = ID;
            this.User = User;
            this.NameLabel.Text = "Welcome " + User;
            SemesterRepository sr = new SemesterRepository();
            this.SemesterComboBox.DataSource = sr.GetAllSemesterName();
        }

        //private void CourseInfo_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'courseRegistrationTableDataSet.CourseRegTable' table. You can move, or remove it, as needed.
        //    this.courseRegTableTableAdapter.Fill(this.courseRegistrationTableDataSet.CourseRegTable);

        //}

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = SemesterComboBox.Text;

            CourseRegistrationRepository crr = new CourseRegistrationRepository();
            List<CourseRegistration> cList = new List<CourseRegistration>();
            cList = crr.GetAllCourseInfo(semester, ID);

            DataTable cTable = new DataTable();
            cTable.Columns.Add("Course ID", typeof(string));
            cTable.Columns.Add("Course Name", typeof(string));
            cTable.Columns.Add("Section", typeof(string));
            cTable.Columns.Add("Status", typeof(string));

            for (int i = 0; i < cList.Count; i++)
            {
                cTable.Rows.Add(cList[i].CourseId, cList[i].CourseName, cList[i].Section, cList[i].Status);
            }

            CourseInfoGridView.DataSource = cTable;
            CourseInfoGridView.ReadOnly = true;
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

        //private void CloseClicked(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
