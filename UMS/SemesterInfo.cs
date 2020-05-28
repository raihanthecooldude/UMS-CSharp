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
    public partial class SemesterInfo: Form
    {
        public SemesterInfo ()
        { 
            InitializeComponent();
            SemesterRepository sRepo = new SemesterRepository();
            this.dataGridViewSemesters.DataSource = sRepo.GetAllSemesters2();
        }

        private void AddClicked(object sender, EventArgs e)
        {
            if (this.textBoxSemesterName.Text != "")
            {
                char[] s = new char[4];
                s[0] = this.textBoxSemesterName.Text[0];
                s[1] = Char.ToUpper(this.textBoxSemesterName.Text[1]);
                s[2] = this.textBoxSemesterName.Text[this.textBoxSemesterName.Text.Length - 2];
                s[3] = this.textBoxSemesterName.Text[this.textBoxSemesterName.Text.Length - 1];
                string s1 = new string(s);

                Semester s2 = new Semester();
                s2.SemesterId = s1;
                s2.Name = this.textBoxSemesterName.Text;
                s2.RegistrationStatus = "Close";

                SemesterRepository sRepo = new SemesterRepository();

                if (sRepo.Insert2(s2))
                {
                    MessageBox.Show("One Semester Added", "Successful");
                    this.dataGridViewSemesters.DataSource = sRepo.GetAllSemesters2();
                    this.textBoxSemesterName.Text = "";
                }
                else
                {
                    MessageBox.Show("Operation Failed / This Name Already Exists", "Failed");
                }
            }
        }

        private void RemoveClicked(object sender, EventArgs e)
        {
            if (this.textBoxSemesterId.Text != "")
            {
                string s = this.textBoxSemesterId.Text;

                SemesterRepository sRepo = new SemesterRepository();

                if (sRepo.Delete2(s) != 0)
                {
                    MessageBox.Show("Semester Removed", "Successful");
                    this.dataGridViewSemesters.DataSource = sRepo.GetAllSemesters2();
                    this.textBoxSemesterId.Text = "";
                }
                else
                {
                    MessageBox.Show("Operation Failed / This Id Doesn't Exist", "Failed");
                }
            }
        }

        private void UpdateClicked(object sender, EventArgs e)
        {
            if (this.textBoxNewSemesterName.Text != "" && this.textBoxSemesterId2.Text != "")
            {
                char[] s = new char[4];
                s[0] = this.textBoxNewSemesterName.Text[0];
                s[1] = Char.ToUpper(this.textBoxNewSemesterName.Text[1]);
                s[2] = this.textBoxNewSemesterName.Text[this.textBoxNewSemesterName.Text.Length - 2];
                s[3] = this.textBoxNewSemesterName.Text[this.textBoxNewSemesterName.Text.Length - 1];
                string s1 = new string(s);

                Semester s2 = new Semester();
                s2.SemesterId = this.textBoxSemesterId2.Text;
                s2.Name = this.textBoxNewSemesterName.Text;

                SemesterRepository sRepo = new SemesterRepository();

                if (sRepo.Update2(s2, s1) != 0)
                {
                    MessageBox.Show("One Semester Updated", "Successful");
                    this.dataGridViewSemesters.DataSource = sRepo.GetAllSemesters2();
                    this.textBoxNewSemesterName.Text = "";
                    this.textBoxSemesterId2.Text = "";
                }
                else
                {
                    MessageBox.Show("Operation Failed / This Name Already Exists", "Failed");
                }
            }
        }

        private void RefreshClicked(object sender, EventArgs e)
        {
            SemesterRepository s = new SemesterRepository();
            this.dataGridViewSemesters.DataSource = s.GetAllSemesters2();
        }

        private void ChangeClicked(object sender, EventArgs e)
        {
            SemesterRepository sRepo = new SemesterRepository();

            if (sRepo.GetSemester2(this.textBoxSemesterId3.Text).RegistrationStatus == "Close")
            {
                if (sRepo.UpdateRegistrationStatus2(this.textBoxSemesterId3.Text, "Open") != 0)
                {
                    MessageBox.Show("Registration Opened", "Successful");
                    this.dataGridViewSemesters.DataSource = sRepo.GetAllSemesters2();
                    this.textBoxSemesterId3.Text = "";
                }
                else
                {
                    MessageBox.Show("Error", "Failed");
                }
            }
            else if (sRepo.GetSemester2(this.textBoxSemesterId3.Text).RegistrationStatus == "Open")
            {
                if (sRepo.UpdateRegistrationStatus2(this.textBoxSemesterId3.Text, "Close") != 0)
                {
                    MessageBox.Show("Registration Closed", "Successful");
                    this.dataGridViewSemesters.DataSource = sRepo.GetAllSemesters2();
                    this.textBoxSemesterId3.Text = "";
                }
                else
                {
                    MessageBox.Show("Error", "Failed");
                }
            }
            else
            {
                MessageBox.Show("Invalid Semester ID", "Failed");
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

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewSemestersDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxSemesterId.Text = this.dataGridViewSemesters.CurrentRow.Cells[0].Value.ToString();
            this.textBoxSemesterId2.Text = this.dataGridViewSemesters.CurrentRow.Cells[0].Value.ToString();
            this.textBoxSemesterId3.Text = this.dataGridViewSemesters.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
