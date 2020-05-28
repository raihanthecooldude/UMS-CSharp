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
    public partial class UploadNotice : Form
    {
        private string uId;
        public UploadNotice(string userId)
        {
            InitializeComponent();
            uId = userId;

            uId = userId;
            AccountRepository ar = new AccountRepository();
            Account ac = ar.GetAccount(uId);
            labelUserName.Text = "Welcome " + ac.Name;


            SemesterRepository sr = new SemesterRepository();
            List<Semester> sList = new List<Semester>();
            sList = sr.GetAllSemesters();

            for (int i = 0; i < sList.Count(); i++)
            {
                comboBoxSelectSemester.Items.Add(sList[i].Name);
            }
            this.comboBoxSelectSemester.Text = "Spring 17-18";
        }

        private void comboBoxSelectSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectCourse.Items.Clear();
            comboBoxSelectCourse.Text = "";
            buttonUploadNotice.Enabled = false;

            CourseAssignRepository car = new CourseAssignRepository();
            List<CourseAssign> cList = new List<CourseAssign>();
            cList = car.GetAllSections(uId, this.comboBoxSelectSemester.Text);

            for (int i = 0; i < cList.Count; i++)
            {
                this.comboBoxSelectCourse.Items.Add(cList[i].AssignedCourse + " " + cList[i].Section);
            }
        }

        private void comboBoxSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUploadNotice.Enabled = true;
        }

        private void buttonUploadNotice_Click(object sender, EventArgs e)
        {
            if (textBoxNotice.Text == "") 
            {
                MessageBox.Show("Notice Box can not be empty");
            }
            else if (textBoxNotice.Text != "") 
            {
                string fullName = comboBoxSelectCourse.Text;
                string nameCourse = fullName.Remove(fullName.Length - 2, 2);
                string nameSection = comboBoxSelectCourse.Text;
                nameSection = "" + nameSection[fullName.Length - 1];

                CourseRepository cr = new CourseRepository();
                Course co = cr.GetCourseId(nameCourse,comboBoxSelectSemester.Text,nameSection);

                Notice no = new Notice();

                no.CourseId = co.CourseId;
                no.Semester = comboBoxSelectSemester.Text;
                no.Section = nameSection;
                no.Noticee = textBoxNotice.Text;
                no.Date = DateTime.Now.ToString();

                //labelUserName.Text = no.CourseId + " " + no.Semester + " " + no.Section + " " + no.Noticee + " " + " " + no.Date;

                NoticeRepository nr=new NoticeRepository();
                if (nr.Insert(no))
                {
                    MessageBox.Show("Notice Updated Successfully");
                }
                else 
                {
                    MessageBox.Show("OOPS ! Something went wrong");
                }

            }
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

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
