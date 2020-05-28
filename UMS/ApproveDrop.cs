using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using ClassLibrary;

namespace UMS
{
    public partial class ApproveDrop : Form
    {
        private string uId;
        public ApproveDrop(string userId)
        {
            InitializeComponent();

            uId = userId;
            AccountRepository ar = new AccountRepository();
            Account ac = ar.GetAccount(userId);
            labelUserName.Text = "Welcome "+ac.Name;

            CourseAssignRepository car = new CourseAssignRepository();
            List<CourseAssign> caList = car.GetAllSections(uId,"Spring 17-18");
            for (int i = 0; i < caList.Count; i++) 
            {
                comboBoxSelectCourse.Items.Add(caList[i].AssignedCourse+" "+caList[i].Section);
            }

            buttonApproveDrop.Enabled = false;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FacultyHome fh = new FacultyHome(uId);
            fh.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void comboBoxSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonApproveDrop.Enabled = false;
            string fullName = comboBoxSelectCourse.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = comboBoxSelectCourse.Text;
            nameSection = "" + nameSection[fullName.Length - 1];
            //labelUserName.Text = nameCourse+"  "+ nameSection;

            CourseResultsRepository crr = new CourseResultsRepository();
            List<CourseResults> cList = new List<CourseResults>();
            cList = crr.GetAllDroppedStudent("Spring 17-18", nameCourse, nameSection);

            for (int i = 0; i < cList.Count; i++)
            {
                if (cList[i].Status == "Apply Drop")
                {
                    comboBoxSelectStudent.Items.Add(cList[i].AccountId);
                }
            }
        }

        private void comboBoxSelectStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonApproveDrop.Enabled = true;
        }

        private void buttonApproveDrop_Click(object sender, EventArgs e)
        {
            string fullName = comboBoxSelectCourse.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = comboBoxSelectCourse.Text;
            nameSection = "" + nameSection[fullName.Length - 1];

            CourseResults cr = new CourseResults();
            cr.CourseName = nameCourse;
            cr.Semester = "Spring 17-18";
            cr.Section = nameSection;
            cr.AccountId = comboBoxSelectStudent.Text;
            cr.Quiz = 0;
            cr.Term = 0;
            cr.FinalMark = 0;
            cr.Grade = 0;
            cr.Status = "Drop";

            CourseResultsRepository crr = new CourseResultsRepository();
            if (crr.UpdateStatus(cr))
            {
                MessageBox.Show("Student ID dropped from the course");
            }
            else 
            {
                MessageBox.Show("OOPS!!! Something went wrong");
            }
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
