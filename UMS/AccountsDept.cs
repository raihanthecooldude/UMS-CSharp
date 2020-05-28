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
    public partial class AccountsDept : Form
    {
        public AccountsDept()
        {
            InitializeComponent();
        }

        private void ManageTeacherSalaryClicked(object sender, EventArgs e)
        {
            ManageTeacherSalary m = new ManageTeacherSalary();
            m.Show();
            this.Hide();
        }

        private void HandleScholarshipClicked(object sender, EventArgs e)
        {
            HandleScholarship h = new HandleScholarship();
            h.Show();
            this.Hide();
        }

        private void ValidPayment(object sender, EventArgs e)
        {
            ValidPayment v = new ValidPayment();
            v.Show();
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
