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
    public partial class HrDepartment : Form
    {
        public HrDepartment()
        {
            InitializeComponent();
        }

        private void updateteacherbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateTeacher u = new UpdateTeacher();
            u.Show();
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createemployeebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateEmplyee h = new CreateEmplyee();
            h.Show();
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
