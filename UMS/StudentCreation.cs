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
    public partial class StudentCreation : Form
    {
        private string[] a = new string[2];
       
        public StudentCreation()
        {
            InitializeComponent();
            a[0] = "M";
            a[1] = "F";
            this.gendercomboBox.DataSource = a;
        }

        private void createbutton_MouseClick(object sender, MouseEventArgs e)
        {
            Account t = new Account();
            t.AccountId = this.idtextBox.Text;
            t.Password = this.passsettextBox.Text;
            t.Gender = this.gendercomboBox.Text;
            t.Address = this.addresstextBox.Text;
            t.Name = this.nametextBox.Text;
            t.AccountType = "Student";
            t.BloodGroup = this.bloodgrouptextbox.Text;
            t.DOB = this.dobtextbox.Text;
            StudentBalance q = new StudentBalance();
            q.AccountId = this.idtextBox.Text;
            q.Semester = "none";
            q.Scholarship = "none";
            q.Balance = 0;
            q.Validation = "invalid";


            AccountRepository aRepo = new AccountRepository();
            StudentBalanceRepository sRepo=new StudentBalanceRepository();
            if (aRepo.DoubleAccountIDRegistrationVerify().Contains(this.idtextBox.Text))
            {
                MessageBox.Show("Account Exixists");
            }
            else
            {
                if (aRepo.Insert2(t))
                {
                    if (sRepo.Insert2(q))
                    {
                        MessageBox.Show("Successful Creation");
                    }
                }
                else
                {
                    MessageBox.Show("Creation Failed ", "Failed");
                }
 
            }
            
         


        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdmissionDeptHome a = new AdmissionDeptHome();
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

        private void createbutton_Click(object sender, EventArgs e)
        {

        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            AccountRepository cr = new AccountRepository();

            this.dataGridView.DataSource = cr.GetAllAccounts2("Student");
        }
    }
}
