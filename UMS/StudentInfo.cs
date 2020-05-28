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
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
            AccountRepository aRepo = new AccountRepository();
            this.dataGridViewStudentInfo.DataSource = aRepo.GetAllAccounts2("Student");
            this.dataGridViewStudentInfo.Columns[1].Visible = false;
        }

        private void SearchButtonClicked(object sender, EventArgs e)
        {
            AccountRepository a = new AccountRepository();
            this.dataGridViewStudentInfo.DataSource = a.SearchAccounts2(this.textBoxSearch.Text);
            this.dataGridViewStudentInfo.Columns[1].Visible = false;
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

        private void ShowAllClicked(object sender, EventArgs e)
        {
            AccountRepository aRepo = new AccountRepository();
            this.dataGridViewStudentInfo.DataSource = aRepo.GetAllAccounts2("Student");
            this.dataGridViewStudentInfo.Columns[1].Visible = false;
        }
        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
