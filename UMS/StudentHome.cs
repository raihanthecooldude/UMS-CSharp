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
    public partial class StudentHome : Form
    {
        private string ID, User;
        private string semester;
        public StudentHome(string ID, string User)
        {
            InitializeComponent();
            this.ID = ID;
            this.User = User;
            this.NameLabel.Text = "Welcome " + User;
            SemesterRepository sr = new SemesterRepository();
            this.SemesterComboBox.DataSource = sr.GetAllSemesterName();

            AllCourseFalse();
        }

        public void AllCourseFalse()
        {
            this.Course1Btn.Visible = false;
            this.Course2Btn.Visible = false;
            this.Course3Btn.Visible = false;
            this.Course4Btn.Visible = false;
            this.Course5Btn.Visible = false;
            this.Course6Btn.Visible = false;
        }

        private void CourseClicked(object sender, EventArgs e)
        {
            CourseInfo ci = new CourseInfo(ID, User);
            ci.Show();
            this.Hide();
        }

        private void LogOutClicked(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void ResultsClicked(object sender, EventArgs e)
        {
            ShowCourseResults gr = new ShowCourseResults(ID, User, true);
            gr.Show();
            this.Hide();
        }

        private void OfferedCoursesClicked(object sender, EventArgs e)
        {
            OfferedCourses oc = new OfferedCourses(ID, User);
            oc.Show();
            this.Hide();
        }

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            semester = SemesterComboBox.Text;

            CourseRegistrationRepository gr = new CourseRegistrationRepository();
            List<CourseRegistration> gList = new List<CourseRegistration>();

            gList = gr.GetAllCourseInfo(semester, ID);
            AllCourseFalse();
            if (gList.Count == 6)
            {
                this.Course1Btn.Visible = true;
                this.Course1Btn.Text = gList[0].CourseName+" "+gList[0].Section;

                this.Course2Btn.Visible = true;
                this.Course2Btn.Text = gList[1].CourseName + " " + gList[1].Section;

                this.Course3Btn.Visible = true;
                this.Course3Btn.Text = gList[2].CourseName + " " + gList[2].Section;

                this.Course4Btn.Visible = true;
                this.Course4Btn.Text = gList[3].CourseName + " " + gList[3].Section;

                this.Course5Btn.Visible = true;
                this.Course5Btn.Text = gList[4].CourseName + " " + gList[4].Section;

                this.Course6Btn.Visible = true;
                this.Course6Btn.Text = gList[5].CourseName + " " + gList[5].Section;
            }
            else if (gList.Count == 5)
            {
                this.Course1Btn.Visible = true;
                this.Course1Btn.Text = gList[0].CourseName + " " + gList[0].Section;

                this.Course2Btn.Visible = true;
                this.Course2Btn.Text = gList[1].CourseName + " " + gList[1].Section;

                this.Course3Btn.Visible = true;
                this.Course3Btn.Text = gList[2].CourseName + " " + gList[2].Section;

                this.Course4Btn.Visible = true;
                this.Course4Btn.Text = gList[3].CourseName + " " + gList[3].Section;

                this.Course5Btn.Visible = true;
                this.Course5Btn.Text = gList[4].CourseName + " " + gList[4].Section;
            }
            else if (gList.Count == 4)
            {
                this.Course1Btn.Visible = true;
                this.Course1Btn.Text = gList[0].CourseName + " " + gList[0].Section;

                this.Course2Btn.Visible = true;
                this.Course2Btn.Text = gList[1].CourseName + " " + gList[1].Section;

                this.Course3Btn.Visible = true;
                this.Course3Btn.Text = gList[2].CourseName + " " + gList[2].Section;

                this.Course4Btn.Visible = true;
                this.Course4Btn.Text = gList[3].CourseName + " " + gList[3].Section;
            }
            else if (gList.Count == 3)
            {
                this.Course1Btn.Visible = true;
                this.Course1Btn.Text = gList[0].CourseName + " " + gList[0].Section;

                this.Course2Btn.Visible = true;
                this.Course2Btn.Text = gList[1].CourseName + " " + gList[1].Section;

                this.Course3Btn.Visible = true;
                this.Course3Btn.Text = gList[2].CourseName + " " + gList[2].Section;
            }
            else if (gList.Count == 2)
            {
                this.Course1Btn.Visible = true;
                this.Course1Btn.Text = gList[0].CourseName + " " + gList[0].Section;

                this.Course2Btn.Visible = true;
                this.Course2Btn.Text = gList[1].CourseName + " " + gList[1].Section;
            }
            else if (gList.Count == 1)
            {
                this.Course1Btn.Visible = true;
                this.Course1Btn.Text = gList[0].CourseName + " " + gList[0].Section;
            }
        }

        private void Course1Clicked(object sender, EventArgs e)
        {
            //string courseName = this.Course1Btn.Text;

            string fullName = this.Course1Btn.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = this.Course1Btn.Text;
            nameSection = "" + nameSection[fullName.Length - 1];

            StudentNotes sn = new StudentNotes(ID, User, semester, nameCourse, nameSection);
            sn.Show();
            this.Hide();
        }

        private void Course2Clicked(object sender, EventArgs e)
        {
            string courseName = this.Course2Btn.Text;

            string fullName = this.Course1Btn.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = this.Course1Btn.Text;
            nameSection = "" + nameSection[fullName.Length - 1];

            StudentNotes sn = new StudentNotes(ID, User, semester, nameCourse, nameSection);
            sn.Show();
            this.Hide();
        }

        private void Course3Clicked(object sender, EventArgs e)
        {
            string courseName = this.Course3Btn.Text;

            string fullName = this.Course1Btn.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = this.Course1Btn.Text;
            nameSection = "" + nameSection[fullName.Length - 1];

            StudentNotes sn = new StudentNotes(ID, User, semester, nameCourse, nameSection);
            sn.Show();
            this.Hide();
        }

        private void Course4Clicked(object sender, EventArgs e)
        {
            string courseName = this.Course4Btn.Text;

            string fullName = this.Course1Btn.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = this.Course1Btn.Text;
            nameSection = "" + nameSection[fullName.Length - 1];

            StudentNotes sn = new StudentNotes(ID, User, semester, nameCourse, nameSection);
            sn.Show();
            this.Hide();
        }

        private void Course5Clicked(object sender, EventArgs e)
        {
            string courseName = this.Course5Btn.Text;

            string fullName = this.Course1Btn.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = this.Course1Btn.Text;
            nameSection = "" + nameSection[fullName.Length - 1];

            StudentNotes sn = new StudentNotes(ID, User, semester, nameCourse, nameSection);
            sn.Show();
            this.Hide();
        }

        private void Course6Clicked(object sender, EventArgs e)
        {
            string courseName = this.Course6Btn.Text;

            string fullName = this.Course1Btn.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = this.Course1Btn.Text;
            nameSection = "" + nameSection[fullName.Length - 1];

            StudentNotes sn = new StudentNotes(ID, User, semester, nameCourse, nameSection);
            sn.Show();
            this.Hide();
        }

        private void ChatClicked(object sender, EventArgs e)
        {
            Chatting ch = new Chatting(ID, User);
            ch.Show();
            this.Hide();
        }

        private void RegistrationClicked(object sender, EventArgs e)
        {
            ShowRegistration sr = new ShowRegistration(ID, User);
            sr.Show();
            this.Hide();
        }

        //private void FormClosingClicked(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

        private void CourseBtnClicked(object sender, EventArgs e)
        {
            CourseInfo csr = new CourseInfo(ID, User);
            csr.Show();
            this.Hide();
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
