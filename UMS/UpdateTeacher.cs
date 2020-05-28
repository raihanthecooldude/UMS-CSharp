using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using ClassLibrary;

namespace UMS
{
    public partial class UpdateTeacher : Form
    {
        string s;
        private string[] a = new string[3];
        public UpdateTeacher()
        {
            InitializeComponent();
            a[0] = "Vacation Applied";
            a[1] = "On Leave";
            a[2] = "On Duty";
            
            this.statuscomboBox.DataSource = a;
        }

      //  private void insertbutton_Click(object sender, EventArgs e)
        //{
         //   Teacher a = new Teacher();
         //   a.Accountid = this.idtextBox.Text;
          //  a.Weekhour = Convert.ToInt16(this.weekhourtextBox.Text);
          //  a.Status = this.statuscomboBox.Text;
           // a.Salary = float.Parse(this.salarytextBox.Text);
           // string g = this.idtextBox.Text;
           // AccountRepository ar = new AccountRepository();
           // TeacherRepository tr = new TeacherRepository();
           // try
           // {
            //    s = ar.GetAccountType(a.Accountid).AccountType;
          //  }
           // catch (Exception ex)
           // {
          //      MessageBox.Show("Invalid");
          //  }
           // if (s == "Teacher")
            //{
               // if (tr.Insert(a))
             //  {
              //     MessageBox.Show("Successful");

               // }
              //  else
              //  {
               //     MessageBox.Show("Error");
               // }
           // }
           // else
           // {
            //    MessageBox.Show("Not A Teacher");
           // }
       // }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            Teacher a = new Teacher();
            a.AccountId = this.idtextBox.Text;
            a.WeekHour = Convert.ToInt16(this.weekhourtextBox.Text);
            a.Status = this.statuscomboBox.Text;
            
            string g = this.idtextBox.Text;
            AccountRepository ar = new AccountRepository();
            TeacherRepository tr = new TeacherRepository();
            try
            {
                s = ar.GetAccountTypeShovon2(a.AccountId).AccountType;
            }
            catch
            {
                MessageBox.Show("Invalid");
            }
            if (s == "Faculty")
            {
                if (tr.UpdateStatusShovon(a.AccountId,a.Status,a.WeekHour))
                {
                    MessageBox.Show("Successful");

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Not A Faculty");
            }
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

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            TeacherRepository cr = new TeacherRepository();

            this.dataGridView1.DataSource = cr.GetAllTeacherInfo2();
        }

    }
}
