using Repository;
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

namespace UMS
{
    public partial class FacultyHome : Form
    {
        private string uId;

        public FacultyHome(string userId)
        {
            InitializeComponent();

            uId = userId;

            AccountRepository ar = new AccountRepository();
            Account ac = ar.GetAccount(userId);

            this.labelName.Text = "Welcome "+ac.Name;

            dataGridView1.Visible = false;

            SemesterRepository sr = new SemesterRepository();
            List<Semester> sList = new List<Semester>();
            sList=sr.GetAllSemesters();

            for (int i = 0; i < sList.Count(); i++) 
            {
                comboBoxSemester.Items.Add(sList[i].Name);
            }
            this.comboBoxSemester.Text = "Spring 17-18";
            this.Controls.Add(this.comboBoxSemester);

            CourseAssignRepository car = new CourseAssignRepository();
            List<CourseAssign> cList = new List<CourseAssign>();
            cList = car.GetAllSections(userId,this.comboBoxSemester.Text);

            DataTable table = new DataTable();
            table.Columns.Add(" Course Name ",typeof(string));
            table.Columns.Add(" Section ",typeof(string));
            table.Columns.Add("Schedule ",typeof(string));

            for (int i = 0; i < cList.Count; i++) 
            {
                CourseRepository cr=new CourseRepository();
                table.Rows.Add(cList[i].AssignedCourse, cList[i].Section, cr.GetOnlySchedule(comboBoxSemester.Text, cList[i].AssignedCourse, cList[i].Section));
            }
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SemesterRepository sr = new SemesterRepository();
            List<Semester> sList = new List<Semester>();
            sList = sr.GetAllSemesters();

            for (int i = 0; i < sList.Count(); i++)
            {
                comboBoxSemester.Items.Add(sList[i].Name);
            }
            this.Controls.Add(this.comboBoxSemester);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            CourseAssignRepository car = new CourseAssignRepository();
            List<CourseAssign> cList = new List<CourseAssign>();
            cList = car.GetAllSections(uId, this.comboBoxSemester.Text);

            DataTable table = new DataTable();
            table.Columns.Add(" Course Name ", typeof(string));
            table.Columns.Add(" Section ", typeof(string));

            for (int i = 0; i < cList.Count; i++)
            {
                table.Rows.Add(cList[i].AssignedCourse, cList[i].Section);
            }
            dataGridView1.DataSource = table;
        }

        private void buttonShowCourseStudent_Click(object sender, EventArgs e)
        {
            ShowCourseStudent scs = new ShowCourseStudent(uId);
            scs.Show();
            this.Hide();
        }

        private void buttonUploadNotice_Click(object sender, EventArgs e)
        {
            UploadNotice un = new UploadNotice(uId);
            un.Show();
            this.Hide();
        }

        private void buttonUploadGrade_Click(object sender, EventArgs e)
        {
            UploadGrade ug = new UploadGrade(uId);
            ug.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseAssignRepository car = new CourseAssignRepository();
            List<CourseAssign> cList = new List<CourseAssign>();
            cList = car.GetAllSections(uId, this.comboBoxSemester.Text);

            DataTable table = new DataTable();
            table.Columns.Add(" Course Name ", typeof(string));
            table.Columns.Add(" Section ", typeof(string));
            table.Columns.Add(" Schedule ", typeof(string));

            for (int i = 0; i < cList.Count; i++)
            {
                CourseRepository cr = new CourseRepository();
                table.Rows.Add(cList[i].AssignedCourse, cList[i].Section, cr.GetOnlySchedule(comboBoxSemester.Text, cList[i].AssignedCourse, cList[i].Section));
            }
            dataGridView1.DataSource = table;

            dataGridView1.Visible = true;
        }

        private void buttonApproveDrop_Click(object sender, EventArgs e)
        {
            ApproveDrop ad = new ApproveDrop(uId);
            ad.Show();
            this.Hide();
        }

        private void buttonApplyVacation_Click(object sender, EventArgs e)
        {
            ApplyVacation av = new ApplyVacation(uId);

            av.Show();
            this.Enabled = false;
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelName_Click(object sender, EventArgs e)
        {
            ShowProfile sp = new ShowProfile(uId);
            sp.Show();
            this.Hide();
        }

        private void buttonShowProfile_Click(object sender, EventArgs e)
        {
            ShowProfile sp = new ShowProfile(uId);
            sp.Show();
            this.Hide();
        }
    }
}
