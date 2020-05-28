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
    public partial class CourseSelect : Form
    {
        string s;
        public CourseSelect()
        {
            InitializeComponent();        
        }

        private void CourseSelect_Load(object sender, EventArgs e)
        {

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
            CourseRegistration c = new CourseRegistration();
            CourseRepository cRepo = new CourseRepository();
            CourseRegistrationRepository d = new CourseRegistrationRepository();
            CourseResultsRepository rr = new CourseResultsRepository();
            c.CourseId = this.courseidtextBox.Text;
            c.CourseName = d.GetCourse2(this.courseidtextBox.Text).CourseName;
            
            c.Section = d.GetCourse2(this.courseidtextBox.Text).Section;
            c.Semester = d.GetCourse2(this.courseidtextBox.Text).Semester;
            c.AccountId = this.accountidtextBox.Text;
            c.Status = "Confirmed";
            CourseRegistrationRepository cr = new CourseRegistrationRepository();
            CourseRepository r=new CourseRepository ();
            AccountRepository ar = new AccountRepository();
            StudentBalanceRepository sRepo = new StudentBalanceRepository();
            StudentBalance sb = new StudentBalance();
            sb.AccountId = this.accountidtextBox.Text;
            
            try
            {
                s = ar.GetAccountTypeShovon2(c.AccountId).AccountType;
            }
            catch
            {
 
            }

            if (cr.CourseVerification2(c.CourseId) == this.courseidtextBox.Text && s == "Student" && cRepo.GetCourse2(this.courseidtextBox.Text).MaxStudent != cRepo.GetCourse2(this.courseidtextBox.Text).CurrentStudent)
            {
                if (cr.DoubleIDRegistrationVerify( this.accountidtextBox.Text,this.courseidtextBox.Text).Contains(this.accountidtextBox.Text))
                {
                    MessageBox.Show("Student Already In the Course ");
                }
                else
                {
                      if (cr.Insert2(c) && rr.DoReg(c.AccountId,c.CourseId,c.Semester,c.Section,c.CourseName)&&sRepo.UpdateStudentBalance(sb))
                {
                    if (r.Increase2(c.CourseId))
                    {
                        MessageBox.Show("Successful");
                    }
                    else
                    {
                        MessageBox.Show("Error Current Student Not Increased");

                    }
                }
                else
                {
                    MessageBox.Show("Error Inserting");

                }
                }
              
 
            }
            else
            {
                MessageBox.Show("Error Course Or Student Verification");

            }
            
           
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void courseidtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            CourseRegistrationRepository cr = new CourseRegistrationRepository();
             CourseRepository cRepo = new CourseRepository();
             if (cr.CourseVerification2(this.courseidtextBox.Text) == this.courseidtextBox.Text)
             {
                 this.semestertextBox.Text = cRepo.GetCourse2(this.courseidtextBox.Text).Semester;
                 this.sectiontextBox.Text = cRepo.GetCourse2(this.courseidtextBox.Text).Section;
                 this.coursetextBox.Text = cRepo.GetCourse2(this.courseidtextBox.Text).Name;
             }
             else
             {
                 MessageBox.Show("No Course Found");
             }
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            CourseRegistrationRepository cr = new CourseRegistrationRepository();

            this.dataGridView.DataSource = cr.GetAllCourses2();
        }

        private void coursetextBox_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
