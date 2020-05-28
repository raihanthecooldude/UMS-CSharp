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
using System.Data.SqlClient;
using Repository;

namespace UMS
{
    public partial class HandleScholarship : Form
    {
        public HandleScholarship()
        {
            InitializeComponent();
            StudentBalanceRepository sRepo = new StudentBalanceRepository();
            this.comboBoxAccountId.DataSource = sRepo.GetAccountIdsScholarshipApprove2();
        }

        private void ApproveClicked(object sender, EventArgs e)
        {
            StudentBalanceRepository sRepo = new StudentBalanceRepository();
            StudentBalance s = new StudentBalance();

            s.AccountId = this.comboBoxAccountId.Text;
            s.Scholarship = this.textBoxScholarshipPercentage.Text;

            if (sRepo.UpdateScholarshipPercentage2(s))
            {
                MessageBox.Show("Scholarship Updated", "Successful");
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
            AccountsDept a = new AccountsDept();
            a.Show();
            this.Hide();
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
