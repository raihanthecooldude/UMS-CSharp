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
    public partial class UploadGrade : Form
    {
        private string uId;
        public UploadGrade(string userId)
        {
            InitializeComponent();

            uId = userId;
            AccountRepository ar = new AccountRepository();
            Account ac = ar.GetAccount(uId);
            labelUserName.Text = "Welcome " + ac.Name;


            buttonUploadQuizMark.Visible = false;
            buttonUploadTermMark.Visible = false;
            numericUpDownUploadQuizMark.Visible = false;
            numericUpDownUploadTermMark.Visible = false;
            buttonUploadQuiz.Visible = false;
            buttonUploadTerm.Visible = false;
            


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
            comboBoxSelectStudent.Items.Clear();
            comboBoxSelectStudent.Text = "";


            buttonUploadQuizMark.Visible = false;
            buttonUploadTermMark.Visible = false;
            numericUpDownUploadQuizMark.Visible = false;
            numericUpDownUploadTermMark.Visible = false;
            buttonUploadQuiz.Visible = false;
            buttonUploadTerm.Visible = false;

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
            comboBoxSelectStudent.Items.Clear();
            comboBoxSelectStudent.Text = "";


            buttonUploadQuizMark.Visible = false;
            buttonUploadTermMark.Visible = false;
            numericUpDownUploadQuizMark.Visible = false;
            numericUpDownUploadTermMark.Visible = false;
            buttonUploadQuiz.Visible = false;
            buttonUploadTerm.Visible = false;

            string fullName = comboBoxSelectCourse.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = comboBoxSelectCourse.Text;
            nameSection = "" + nameSection[fullName.Length - 1];
            //labelUserName.Text = nameCourse+"  "+ nameSection;

            CourseRegistrationRepository crr = new CourseRegistrationRepository();
            List<CourseRegistration> cList = new List<CourseRegistration>();
            cList = crr.GetAllStudents(comboBoxSelectSemester.Text, nameCourse, nameSection);
            List<string> cTempList = new List<string>(cList.Count);
            for (int i = 0; i < cList.Count; i++) 
            {
                cTempList.Add(cList[i].AccountId);
            }
            for (int i = 0; i < cList.Count; i++)
            {
                cTempList.Remove(cList[i].AccountId);
                if (!cTempList.Contains(cList[i].AccountId))
                {
                    AccountRepository ar = new AccountRepository();
                    Account ac = ar.GetAccount(cList[i].AccountId);
                    comboBoxSelectStudent.Items.Add(ac.AccountId + "  " + ac.Name);
                }
            }
        }

        private void comboBoxSelectStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUploadQuizMark.Visible = true;
            buttonUploadTermMark.Visible = true;
        }

        private void buttonUploadQuizMark_Click(object sender, EventArgs e)
        {
            numericUpDownUploadQuizMark.Visible = true;
            buttonUploadQuiz.Visible = true;

            numericUpDownUploadTermMark.Visible = false;
            buttonUploadTerm.Visible = false;
        }

        private void buttonUploadTermMark_Click(object sender, EventArgs e)
        {
            numericUpDownUploadTermMark.Visible = true;
            buttonUploadTerm.Visible = true;

            numericUpDownUploadQuizMark.Visible = false;
            buttonUploadQuiz.Visible = false;
        }

        private void buttonUploadQuiz_Click(object sender, EventArgs e)
        {
            string fullName = comboBoxSelectCourse.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = comboBoxSelectCourse.Text;
            nameSection = "" + nameSection[fullName.Length - 1];

            string selectedId = comboBoxSelectStudent.Text;
            selectedId = selectedId.Substring(0, selectedId.IndexOf(" ")).Trim();

            CourseResults cr = new CourseResults();
            cr.CourseName = nameCourse;
            cr.Section = nameSection;
            cr.Semester = comboBoxSelectSemester.Text;
            cr.AccountId = selectedId;
            cr.Quiz = (double)numericUpDownUploadQuizMark.Value;
            cr.Term = 0;
            cr.FinalMark = 0;
            cr.Grade = 0;
            cr.Status = "Active";

            CourseResultsRepository crr = new CourseResultsRepository();
            if (crr.UpdateQuizMark(cr))
            {
                MessageBox.Show("Quiz Mark uploaded Successfully");
            }
            else 
            {
                MessageBox.Show("OOPS !!! Something went wr");
            }
        }

        private void buttonUploadTerm_Click(object sender, EventArgs e)
        {   
            string fullName = comboBoxSelectCourse.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            string nameSection = comboBoxSelectCourse.Text;
            nameSection = "" + nameSection[fullName.Length - 1];

            string selectedId = comboBoxSelectStudent.Text;
            selectedId = selectedId.Substring(0, selectedId.IndexOf(" ")).Trim();

            CourseResults cr = new CourseResults();
            CourseResultsRepository crr = new CourseResultsRepository();
            cr.CourseName = nameCourse;
            cr.Section = nameSection;
            cr.Semester = comboBoxSelectSemester.Text;
            cr.AccountId = selectedId;
            cr.Quiz = 0;
            cr.Term = (double)numericUpDownUploadTermMark.Value;
            cr.FinalMark = 0;
            cr.Grade = 0;
            cr.Status = "Active";

            double term = cr.Term;
            double quiz = crr.GetQuizMark(cr);
            cr.FinalMark = quiz + term;

            if (cr.FinalMark >= 80) 
            {
                cr.Grade = 4.00;
            }
            if (cr.FinalMark >= 70 && cr.FinalMark <= 79) 
            {
                cr.Grade = 3.75;
            }
            if (cr.FinalMark >= 60 && cr.FinalMark <= 69) 
            {
                cr.Grade = 3.5;
            }
            if (cr.FinalMark >= 50 && cr.FinalMark <= 59)
            {
                cr.Grade = 3.25;
            }
            if (cr.FinalMark >= 40 && cr.FinalMark <= 49)
            {
                cr.Grade = 3.0;
            }
            if (cr.FinalMark >= 30 && cr.FinalMark <= 39)
            {
                cr.Grade = 2.75;
            }
            if (cr.FinalMark < 30) 
            {
                cr.Grade = 0;
            }
            if (crr.UpdateTermMark(cr))
            {
                MessageBox.Show("Term Mark uploaded Successfully");
            }
            if (!crr.UpdateTermMark(cr))
            {
                MessageBox.Show("OOPS !!! Something went wrong");
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FacultyHome fh = new FacultyHome(uId);
            fh.Show();
            this.Hide();
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
