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
    public partial class ValidPayment : Form
    {
        public ValidPayment()
        {
            InitializeComponent();
            StudentBalanceRepository sRepo = new StudentBalanceRepository();
            this.comboBoxAccountId.DataSource = sRepo.GetAccountIdsInvalid2();
        }

        private void ValidClicked(object sender, EventArgs e)
        {
            StudentBalance s = new StudentBalance();
            s.AccountId = this.comboBoxAccountId.Text;
            s.Balance = 0;
            StudentBalanceRepository sRepo = new StudentBalanceRepository();
            if (sRepo.UpdateInvalide2(s))
            {
                MessageBox.Show("Validation Updated", "Successful");
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
