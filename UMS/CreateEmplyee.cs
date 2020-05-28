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
    public partial class CreateEmplyee : Form
    {
         private string[] a=new string[5];
         private string[] u = new string[2];
       


        public CreateEmplyee()
        {
            InitializeComponent();
            u[0] = "M";
            u[1] = "F";
            this.gendercomboBox.DataSource = u;
            a[0] = "Admin Department";
            a[1] = "Account Department";
            a[2] = "Hr Department";
            a[3] = "Registraion Department";
            a[4] = "Faculty";
            this.comboBox1.DataSource = a;
        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HrDepartment a = new HrDepartment();
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

        private void Createbutton_Click(object sender, EventArgs e)
        {
            Account t = new Account();
            t.AccountId = this.idtextBox.Text;
            t.Password = this.passwordtextBox.Text;
            t.Gender = this.gendercomboBox.Text;
            t.Address = this.addresstextBox.Text;
            t.Name = this.nametextBox.Text;
            t.AccountType = this.comboBox1.Text;
            t.BloodGroup = this.bloodgrouptextBox.Text;
            t.DOB = this.dobtextBox.Text;


            AccountRepository aRepo = new AccountRepository();
            if (aRepo.DoubleAccountIDRegistrationVerify().Contains(this.idtextBox.Text))
            {
                MessageBox.Show("Account Exixists");
            }
            else
            {
                if (aRepo.Insert2(t))
                {
                    MessageBox.Show("Successful Creation");
                }
                else
                {
                    MessageBox.Show("Creation Failed", "Failed");
                }
 
            }           
         
            if (this.comboBox1.Text == "Faculty")
            {
                Teacher r = new Teacher();
                TeacherRepository tr = new TeacherRepository();
                r.AccountId = this.idtextBox.Text;
                r.WeekHour = 30;
                r.Status = "On Duty";
                r.Salary = 0;
                if (tr.Insert2(r))
                {
                    MessageBox.Show("Teacher Information Updated", "Successful");

                }
                else
                {
                    MessageBox.Show("Teacher Information Update Failed", "Failed");
                }
 
            }
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            AccountRepository cr = new AccountRepository();

            this.dataGridView.DataSource = cr.GetAllAccounts3("Student");
        }
    }
}
