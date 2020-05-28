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
    public partial class ShowCourseResults : Form
    {
        public string ID, User;
        private bool b;
        
        public ShowCourseResults(string ID, string User, bool b)
        {
            InitializeComponent();
            this.b = b;
            this.ID = ID;
            this.NameLabel.Visible = b;
            this.User = User;
            this.NameLabel.Text = "Welcome " + User;
            SemesterRepository sr = new SemesterRepository();
            this.SemesterComboBox.DataSource = sr.GetAllSemesterName();
        }

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = SemesterComboBox.Text;
            double count = 0, gpa, cgcount=0, cgpa;
            int i, n = 0, cgn=0;

            CourseResultsRepository gr = new CourseResultsRepository();
            List<CourseResults> gList = new List<CourseResults>();
            List<CourseResults> cgList = new List<CourseResults>();

            cgList = gr.GetAllResult(ID);
            for (i = 0; i < cgList.Count; i++)
            {
                if (cgList[i].Status == "Active")
                {
                    cgcount += cgList[i].Grade;
                    cgn++;
                }
            }


            gList = gr.GetAllResult(semester, ID);
            DataTable gTable = new DataTable();
            gTable.Columns.Add("Subject", typeof(string));
            gTable.Columns.Add("Section", typeof(string));
            gTable.Columns.Add("Quiz", typeof(double));
            gTable.Columns.Add("Final", typeof(double));
            gTable.Columns.Add("Final Mark", typeof(double));
            gTable.Columns.Add("Grade", typeof(double));
            gTable.Columns.Add("Status", typeof(string));

            for (i = 0; i < gList.Count; i++)
            {
                gTable.Rows.Add(gList[i].CourseName, gList[i].Section, gList[i].Quiz, gList[i].Term, gList[i].FinalMark, gList[i].Grade, gList[i].Status);

                if (gList[i].Status == "Active")
                {
                    count += gList[i].Grade;
                    n++;
                }
            }
            gpa = count / n;
            if (n == 0)
            {
                this.GPALabel.Text = "This Semester's GPA: None";
            }
            else
            {
                this.GPALabel.Text = "This Semester's GPA: " + string.Format("{0:0.00}", gpa);
                //this.GPALabel.Text = "This Semester's GPA: " + gpa;
            }

            cgpa = cgcount / cgn;
            if (cgn == 0)
            {
                this.CGPALabel.Text = "Total CGPA: None";
            }
            else
            {
                this.CGPALabel.Text = "Total CGPA: " + string.Format("{0:0.00}", cgpa);
                //this.CGPALabel.Text = "This Semester's GPA: " + cgpa;
            }
            ResultGridView.DataSource = gTable;
            ResultGridView.ReadOnly = true;
        }



        private void BackClicked(object sender, EventArgs e)
        {
            if (b == true)
            {
                StudentHome sh = new StudentHome(ID, User);
                sh.Show();
                this.Hide();
            }
            else
            {
                CheckScholarship cgs = new CheckScholarship();
                cgs.Show();
                this.Hide();
            }
        }

        private void LogOutClicked(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
