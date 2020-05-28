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
using Repository;

namespace UMS
{
    public partial class AssignCourseInfo : Form
    {
        public AssignCourseInfo()
        {
            InitializeComponent();

            AccountRepository aRepo = new AccountRepository();
            this.comboBoxAccount.DataSource = aRepo.GetAccountIdAndNames2("Faculty");

            //CourseRepository cRepo = new CourseRepository();
            //this.comboBoxAssignedCourse.DataSource = cRepo.GetCourseNames2();
            //this.comboBoxSection.DataSource = cRepo.GetALLSections2();

            SemesterRepository sRepo = new SemesterRepository();
            this.comboBoxSemesterName.DataSource = sRepo.GetAllSemesterNames2();

            CourseAssignRepository asRepo = new CourseAssignRepository();
            this.dataGridViewAssignedCourses.DataSource = asRepo.GetAllAssignedCourses2();
        }

        private void AssignClicked(object sender, EventArgs e)
        {
            CourseAssign s = new CourseAssign();
            string[] acc = this.comboBoxAccount.Text.Split(' ');
            s.AccountId = acc[0];
            s.AssignedCourse = this.comboBoxAssignedCourse.Text;
            s.Section = this.comboBoxSection.Text;
            s.Semester = this.comboBoxSemesterName.Text;
            Course c = new Course();
            c.Name = this.comboBoxAssignedCourse.Text;
            c.Section = this.comboBoxSection.Text;
            c.Semester = this.comboBoxSemesterName.Text;

            CourseAssignRepository aRepo = new CourseAssignRepository();
            CourseRepository cRepo = new CourseRepository();
            if (cRepo.CheckCourse2(c))
            {
                if (aRepo.CheckAssignedCourse2(s))
                {
                    if (aRepo.Insert2(s))
                    {
                        MessageBox.Show("One Course Assigned", "Successful");
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed", "Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Already Exists", "Failed");
                }
            }
            else
            {
                MessageBox.Show("Invalid Course", "Failed");
            }
        }
        private void RefreshClicked(object sender, EventArgs e)
        {
            CourseAssignRepository aRepo = new CourseAssignRepository();
            this.dataGridViewAssignedCourses.DataSource = aRepo.GetAllAssignedCourses2();
        }

        private void LogOutClicked(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void BackClicked(object sender, EventArgs e)
        {
            RegistrationDept r = new RegistrationDept();
            r.Show();
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

        private void SemesterSelected(object sender, EventArgs e)
        {
            CourseRepository cRepo = new CourseRepository();
            this.comboBoxAssignedCourse.DataSource = cRepo.GetCourseNamesBySemester2(this.comboBoxSemesterName.Text);
        }

        private void AssignedCourseSelected(object sender, EventArgs e)
        {
            CourseRepository cRepo = new CourseRepository();
            this.comboBoxSection.DataSource = cRepo.GetALLSectionsByCourseNameAndSemester2(this.comboBoxAssignedCourse.Text, this.comboBoxSemesterName.Text);
        }
    }
}
