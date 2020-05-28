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
    public partial class CheckScholarship : Form
    {
        public CheckScholarship()
        {
            InitializeComponent();
            AccountRepository aRepo = new AccountRepository();
            this.comboBoxAccountId.DataSource = aRepo.GetAccountIds2("Student");
        }

        private void EligibleClicked(object sender, EventArgs e)
        {
            StudentBalanceRepository sRepo = new StudentBalanceRepository();
            StudentBalance s = new StudentBalance();
            s.AccountId = this.comboBoxAccountId.Text;
            s.Scholarship = "Eligible For Scholarship";
            if (sRepo.UpdateScholarshipEligible2(s))
            {
                MessageBox.Show("Scholarship Is Eligible Now", "Successful");
            }
            else
            {
                MessageBox.Show("Error", "Failed");
            }
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

        //private void CloseClicked(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ResultClicked(object sender, EventArgs e)
        {
            ShowCourseResults s = new ShowCourseResults(this.comboBoxAccountId.Text, "", false);
            s.Show();
            this.Hide();
        }
    }
}
