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
    public partial class ShowCourseStudent : Form
    {
        private string uId;
        public ShowCourseStudent(string userId)
        {
            InitializeComponent();

            uId = userId;
            AccountRepository ar = new AccountRepository();
            Account ac = ar.GetAccount(uId);
            labelUserName.Text = "Welcome "+ac.Name;

            dataGridView1.Visible = false;

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
            dataGridView1.DataSource = null;
            dataGridView1.Visible = false;

            CourseAssignRepository car = new CourseAssignRepository();
            List<CourseAssign> cList = new List<CourseAssign>();
            cList = car.GetAllSections(uId, this.comboBoxSelectSemester.Text);

            for (int i = 0; i < cList.Count; i++) 
            {
                this.comboBoxSelectCourse.Items.Add(cList[i].AssignedCourse+" "+cList[i].Section);
            }
        }

        private void comboBoxSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

            string fullName = comboBoxSelectCourse.Text;
            string nameCourse =fullName.Remove(fullName.Length - 2, 2);
            string nameSection = comboBoxSelectCourse.Text;
            nameSection = ""+nameSection[fullName.Length - 1];
            //labelUserName.Text = nameCourse+"  "+ nameSection;

            CourseRegistrationRepository crr = new CourseRegistrationRepository();
            List<CourseRegistration> cList = new List<CourseRegistration>();
            cList = crr.GetAllStudents(comboBoxSelectSemester.Text,nameCourse,nameSection);
            //List<CourseRegistration>mList=new List<CourseRegistration>();
            //for (int i = 0; i < cList.Count; i++)
            //{
            //    mList.Add(cList[i]);
            //}

            DataTable table = new DataTable();
            table.Columns.Add("Student Id", typeof(string));
            table.Columns.Add("Student Name", typeof(string));

            List<string> cTempList = new List<string>(cList.Count);
            for (int i = 0; i < cList.Count; i++)
            {
                cTempList.Add(cList[i].AccountId);
            }
            //Account ac = new Account();
            for (int i = 0; i < cList.Count; i++)
            {
                cTempList.Remove(cList[i].AccountId);
                if (!cTempList.Contains(cList[i].AccountId))
                {
                    AccountRepository ar = new AccountRepository();
                    Account ac = ar.GetAccount(cList[i].AccountId);
                    //ac = new ar.GetAccount(cList[i].AccountId);
                    table.Rows.Add(cList[i].AccountId, ac.Name);
                }
            }

            //for (int i = 0; i < cList.Count; i++)
            //{
            //    mList.Remove(cList[i]);
            //    if (!mList.Contains(cList[i]))
            //    {
            //        //AccountRepository ar = new AccountRepository();
            //        ////Account ac = new Account();
            //        //Account ac = new ar.GetAccount(cList[i].AccountId);
            //        table.Rows.Add(cList[i].AccountId, cList[i].);
            //    }
            //}

            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
            dataGridView1.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FacultyHome fh = new FacultyHome(uId);
            fh.Visible = true;
            this.Visible = false;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
