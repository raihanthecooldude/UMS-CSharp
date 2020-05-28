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
    public partial class AdmissionDeptHome : Form
    {
        public AdmissionDeptHome()
        {
            InitializeComponent();
        }

        private void buttonCreateStudentAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentCreation i = new StudentCreation();
            i.Show();
        }

        private void CreateStudentAccountbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentCreation i = new StudentCreation();
            i.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a=new Login();
            a.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a=new Login();
            a.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdmissionDeptHome_Load(object sender, EventArgs e)
        {

        }

        private void courselectionbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseSelect c = new CourseSelect();
            c.Show();
        }

        private void genaratepdfbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRoutine c = new CreateRoutine();
            c.Show();
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
