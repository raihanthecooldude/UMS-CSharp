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
    public partial class Login : Form
    {
        private string ID, User;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            Account user = new Account();
            user.AccountId = this.textBoxId.Text;
            user.Password = this.textBoxPassword.Text;
            ID = user.AccountId;
            

            AccountRepository aRepo = new AccountRepository();
            if (aRepo.UserLoginVerification(user).AccountType == "Admin Admission Department")
            {
                AdmissionDeptHome h1 = new AdmissionDeptHome();
                h1.Show();
                this.Hide();
            }
            else if(aRepo.UserLoginVerification(user).AccountType == "Student")
            {
                User = aRepo.UserLoginVerification(user).Name;
                StudentHome s1=new StudentHome(ID, User);
                s1.Show();
                this.Hide();
            }
            else if (aRepo.UserLoginVerification(user).AccountType == "Admin Registration Department")
            {
                User = aRepo.UserLoginVerification(user).Name;
                RegistrationDept s1 = new RegistrationDept();
                s1.Show();
                this.Hide();
            }
            else if (aRepo.UserLoginVerification(user).AccountType == "Admin Accounts Department")
            {
                User = aRepo.UserLoginVerification(user).Name;
                AccountsDept s1 = new AccountsDept();
                s1.Show();
                this.Hide();
            }
            else if (aRepo.UserLoginVerification(user).AccountType == "Admin HR Department")
            {
                User = aRepo.UserLoginVerification(user).Name;
                HrDepartment s1 = new HrDepartment();
                s1.Show();
                this.Hide();
            }
            else if (aRepo.UserLoginVerification(user).AccountType == "Faculty")
            {
                FacultyHome f1 = new FacultyHome(ID);
                f1.Show();
                this.Hide();
            }
            else if (aRepo.UserLoginVerification(user).AccountType == "False")
            {
                MessageBox.Show("Invalid ID or Password", "Login Failed");
            }
            else
            {
                MessageBox.Show("Invalid ID or Password", "Login Failed");
            }
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
