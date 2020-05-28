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
    public partial class ManageTeacherSalary : Form
    {
        public ManageTeacherSalary()
        {
            InitializeComponent();
            AccountRepository aRepo = new AccountRepository();
            this.comboBoxAccountId.DataSource = aRepo.GetAccountIds2("Faculty");

            TeacherRepository tRepo = new TeacherRepository();
            this.dataGridViewTeacherSalaryList.DataSource = tRepo.GetAllTeacherInfo2();
        }

        private void SetClicked(object sender, EventArgs e)
        {
            TeacherRepository tRepo = new TeacherRepository();

            try
            {
                if (tRepo.Update2(this.comboBoxAccountId.Text, Convert.ToDouble(this.textBoxSalary.Text)) && this.textBoxSalary.Text != "")
                {
                    MessageBox.Show("Salary Set To " + this.textBoxSalary.Text, "Successful");
                }
                else
                {
                    MessageBox.Show("Error", "Failed");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Salary", "Failed");
            }
        }

        private void RefreshClicked(object sender, EventArgs e)
        {
            TeacherRepository tRepo = new TeacherRepository();
            this.dataGridViewTeacherSalaryList.DataSource = tRepo.GetAllTeacherInfo2();
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
