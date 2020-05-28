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
    public partial class EditCourseInfo : Form
    {
        public EditCourseInfo()
        {
            InitializeComponent();
            CourseRepository cRepo = new CourseRepository();
            this.dataGridViewCourse.DataSource = cRepo.GetAllCourses2();
            SemesterRepository sRepo = new SemesterRepository();
            this.comboBoxSemester.DataSource = sRepo.GetAllSemesterNames2();
            this.radioButtonTheory.Checked = true;
        }

        private void InsertClicked(object sender, EventArgs e)
        {
            Course c = new Course();
            Random r = new Random();
            SemesterRepository sRepo = new SemesterRepository();
            int x;

            if (this.textBoxName.Text != "" && this.comboBoxSemester.Text != "" && this.textBoxSection.Text != "" && this.comboBoxSchedule.Text != "")
            {
                if (sRepo.CheckSemester2(this.comboBoxSemester.Text))
                {
                    x = r.Next(1000, 4999);

                    if (this.radioButtonCSE.Checked)
                    {
                        c.CourseId = "CSE" + x.ToString();
                        c.Department = "CSE";
                    }
                    else if (this.radioButtonEEE.Checked)
                    {
                        c.CourseId = "EEE" + x.ToString();
                        c.Department = "EEE";
                    }
                    else
                    {
                        c.CourseId = "BBA" + x.ToString();
                        c.Department = "BBA";
                    }
                    this.labelId.Text = c.CourseId;
                    c.Name = this.textBoxName.Text.ToUpper();
                    c.Semester = this.comboBoxSemester.Text.ToUpper();
                    c.Section = this.textBoxSection.Text.ToUpper();

                    if (this.radioButton20.Checked)
                    {
                        c.MaxStudent = 20;
                    }
                    else if (this.radioButton30.Checked)
                    {
                        c.MaxStudent = 30;
                    }
                    else
                    {
                        c.MaxStudent = 40;
                    }
                    c.CurrentStudent = 0;

                    if (this.radioButton1Credit.Checked)
                    {
                        c.Credit = 1;
                    }
                    else
                    {
                        c.Credit = 3;
                    }
                    c.Schedule = this.comboBoxSchedule.Text.ToUpper();

                    CourseRepository cRepo = new CourseRepository();

                    if (cRepo.Insert2(c))
                    {
                        MessageBox.Show("One Course Added", "Successful");
                        this.dataGridViewCourse.DataSource = cRepo.GetAllCourses2();
                    }
                    else
                    {
                        MessageBox.Show("Fill up all the fields", "Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Invalide Semester Name", "Failed");
                }
            }
        }

        private void UpdateClicked(object sender, EventArgs e)
        {
            Course c = new Course();
            Random r = new Random();
            SemesterRepository sRepo = new SemesterRepository();
            int x;
            string NewCourseId;

            if (this.textBoxName.Text != "" && this.comboBoxSemester.Text != "" && this.textBoxSection.Text != "" && this.comboBoxSchedule.Text != "")
            {
                if (sRepo.CheckSemester2(this.comboBoxSemester.Text))
                {
                    x = r.Next(1000, 4999);

                    if (this.radioButtonCSE.Checked)
                    {
                        NewCourseId = "CSE" + x.ToString();
                        c.Department = "CSE";
                    }
                    else if (this.radioButtonEEE.Checked)
                    {
                        NewCourseId = "EEE" + x.ToString();
                        c.Department = "EEE";
                    }
                    else
                    {
                        NewCourseId = "BBA" + x.ToString();
                        c.Department = "BBA";
                    }
                    c.CourseId = this.labelId.Text;
                    c.Name = this.textBoxName.Text.ToUpper();
                    c.Semester = this.comboBoxSemester.Text.ToUpper();
                    c.Section = this.textBoxSection.Text.ToUpper();

                    if (this.radioButton20.Checked)
                    {
                        c.MaxStudent = 20;
                    }
                    else if (this.radioButton30.Checked)
                    {
                        c.MaxStudent = 30;
                    }
                    else
                    {
                        c.MaxStudent = 40;
                    }
                    c.CurrentStudent = 0;

                    if (this.radioButton1Credit.Checked)
                    {
                        c.Credit = 1;
                    }
                    else
                    {
                        c.Credit = 3;
                    }
                    c.Schedule = this.comboBoxSchedule.Text.ToUpper();

                    CourseRepository cRepo = new CourseRepository();

                    if (cRepo.Update2(c, NewCourseId))
                    {
                        MessageBox.Show("One Course Updated", "Successful");
                        this.dataGridViewCourse.DataSource = cRepo.GetAllCourses2();
                    }
                    else
                    {
                        MessageBox.Show("Fill up all the fields", "Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Invalide Semester Name", "Failed");
                }
            }
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            CourseRepository cRepo = new CourseRepository();

            if (cRepo.Delete2(this.labelId.Text))
            {
                MessageBox.Show("Course Has Been Deleted", "Successful");
                this.dataGridViewCourse.DataSource = cRepo.GetAllCourses2();
            }
            else
            {
                MessageBox.Show("Invalide Course Id", "Failed");
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

        private void CourseTypeCheckedChanged(object sender, EventArgs e)
        {
            string[] theory = new string[12];
            theory[0] = "Sun 08:00 AM - Tue 08:00 AM";
            theory[1] = "Sun 09:30 AM - Tue 09:30 AM";
            theory[2] = "Sun 11:00 AM - Tue 11:00 PM";
            theory[3] = "Sun 12:30 PM - Tue 12:30 PM";
            theory[4] = "Sun 02:00 PM - Tue 02:00 PM";
            theory[5] = "Sun 03:30 PM - Tue 03:30 PM";
            theory[6] = "Mon 08:00 AM - Wed 08:00 AM";
            theory[7] = "Mon 09:30 AM - Wed 09:30 AM";
            theory[8] = "Mon 11:00 AM - Wed 11:00 AM";
            theory[9] = "Mon 12:30 PM - Wed 12:30 PM";
            theory[10] = "Mon 02:00 PM - Wed 02:00 PM";
            theory[11] = "Mon 03:30 PM - Wed 03:30 PM";

            string[] theorylab = new string[8];
            theorylab[0] = "Sun 08:00 AM -- Tue 08:00 AM";
            theorylab[1] = "Sun 10:00 AM -- Tue 11:00 AM";
            theorylab[2] = "Sun 12:00 PM -- Tue 02:00 PM";
            theorylab[3] = "Sun 02:00 AM -- Thu 08:00 AM";
            theorylab[4] = "Mon 08:00 AM -- Wed 08:00 AM";
            theorylab[5] = "Mon 10:00 AM -- Wed 11:00 AM";
            theorylab[6] = "Mon 12:00 AM -- Wed 02:00 PM";
            theorylab[7] = "Mon 02:00 AM -- Wed 11:00 AM";

            string[] lab = new string[12];
            lab[0] = "Sun 08:00 AM";
            lab[1] = "Sun 11:00 AM";
            lab[2] = "Sun 02:00 PM";
            lab[3] = "Mon 08:00 AM";
            lab[4] = "Mon 11:00 AM";
            lab[5] = "Mon 02:00 PM";
            lab[6] = "Tue 08:00 AM";
            lab[7] = "Tue 11:00 AM";
            lab[8] = "Tue 02:00 PM";
            lab[9] = "Wed 08:00 AM";
            lab[10] = "Wed 11:00 AM";
            lab[11] = "Wed 02:00 PM";

            if (this.radioButtonTheory.Checked)
            {
                this.comboBoxSchedule.DataSource = theory;
            }
            else if (this.radioButtonTheoryAndLab.Checked)
            {
                this.comboBoxSchedule.DataSource = theorylab;
            }
            else
            {
                this.comboBoxSchedule.DataSource = lab;
            }
        }

        private void dataGridViewCourseCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            this.labelId.Text = this.dataGridViewCourse.CurrentRow.Cells[0].Value.ToString();
            this.textBoxName.Text = this.dataGridViewCourse.CurrentRow.Cells[1].Value.ToString();
            this.comboBoxSemester.SelectedIndex = this.comboBoxSemester.FindString(this.dataGridViewCourse.CurrentRow.Cells[2].Value.ToString());

            if (this.radioButtonCSE.Text == this.dataGridViewCourse.CurrentRow.Cells[3].Value.ToString())
            {
                this.radioButtonCSE.Checked = true;
            }
            else if (this.radioButtonEEE.Text == this.dataGridViewCourse.CurrentRow.Cells[3].Value.ToString())
            {
                this.radioButtonEEE.Checked = true;
            }
            else
            {
                this.radioButtonBBA.Checked = true;
            }

            this.textBoxSection.Text = this.dataGridViewCourse.CurrentRow.Cells[4].Value.ToString();

            if (this.radioButton20.Text == this.dataGridViewCourse.CurrentRow.Cells[5].Value.ToString())
            {
                this.radioButton20.Checked = true;
            }
            else if (this.radioButton30.Text == this.dataGridViewCourse.CurrentRow.Cells[5].Value.ToString())
            {
                this.radioButton30.Checked = true;
            }
            else
            {
                this.radioButton40.Checked = true;
            }

            if (this.radioButton1Credit.Text == this.dataGridViewCourse.CurrentRow.Cells[7].Value.ToString())
            {
                this.radioButton1Credit.Checked = true;
            }
            else
            {
                this.radioButton3Credits.Checked = true;
            }

            int x = this.dataGridViewCourse.CurrentRow.Cells[8].Value.ToString().Length;

            if (x == 27)
            {
                this.radioButtonTheory.Checked = true;
            }
            else if (x == 28)
            {
                this.radioButtonTheoryAndLab.Checked = true;
            }
            else
            {
                this.radioButtonLab.Checked = true;
            }

            this.comboBoxSchedule.SelectedIndex = this.comboBoxSchedule.FindString(this.dataGridViewCourse.CurrentRow.Cells[8].Value.ToString());
            
        }
    }
}
