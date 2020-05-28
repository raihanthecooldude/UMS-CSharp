using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS
{
    public partial class RegistrationDept : Form
    {
        public RegistrationDept()
        {
            InitializeComponent();
        }

        private void ViewStudentInfoClicked(object sender, EventArgs e)
        {
            StudentInfo s = new StudentInfo();
            s.Show();
            this.Hide();
        }

        private void EditSemesterClicked(object sender, EventArgs e)
        {
            SemesterInfo s = new SemesterInfo();
            s.Show();
            this.Hide();
        }

        private void EditCourseClicked(object sender, EventArgs e)
        {
            EditCourseInfo c = new EditCourseInfo();
            c.Show();
            this.Hide();
        }

        private void AssignCourseClicked(object sender, EventArgs e)
        {
            AssignCourseInfo s = new AssignCourseInfo();
            s.Show();
            this.Hide();
        }

        private void EditExamClicked(object sender, EventArgs e)
        {
            ExamInfo ex = new ExamInfo();
            ex.Show();
            this.Hide();
        }

        private void CheckScholarshipClicked(object sender, EventArgs e)
        {
            CheckScholarship c = new CheckScholarship();
            c.Show();
            this.Hide();
        }

        private void LogOutClicked(object sender, EventArgs e)
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
