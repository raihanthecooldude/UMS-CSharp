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
    public partial class ExamInfo : Form
    {
        public ExamInfo()
        {
            InitializeComponent();

            SemesterRepository sRepo = new SemesterRepository();
            this.comboBoxSemesterName.DataSource = sRepo.GetAllSemesterNames2();

            CourseRepository cRepo = new CourseRepository();
            this.comboBoxCourseId.DataSource = cRepo.GetCourseIdNameSectionsBySemester2(this.comboBoxSemesterName.Text);

            AccountRepository aRepo = new AccountRepository();
            this.comboBoxFacultyId.DataSource = aRepo.GetAccountIdAndNames2("Faculty");

            ExamRepository eRepo = new ExamRepository();
            this.dataGridViewExam.DataSource = eRepo.GetAllExams2();
        }

        private void AddClicked(object sender, EventArgs e)
        {
            Exam ex = new Exam();
            Course c = new Course();
            string[] acc = this.comboBoxFacultyId.Text.Split(' ');
            string[] acc2 = this.comboBoxCourseId.Text.Split(' '); 
            ex.CourseId = acc2[0];
            c.CourseId = acc2[0];
            ex.Semester = this.comboBoxSemesterName.Text;
            c.Semester = this.comboBoxSemesterName.Text;
            ex.Room = this.textBoxRoom.Text;

            if (this.radioButton1.Checked)
            {
                ex.Day = this.radioButton1.Text;
            }
            else if (this.radioButton2.Checked)
            {
                ex.Day = this.radioButton2.Text;
            }
            else if (this.radioButton3.Checked)
            {
                ex.Day = this.radioButton3.Text;
            }
            else if (this.radioButton4.Checked)
            {
                ex.Day = this.radioButton4.Text;
            }
            else if (this.radioButton5.Checked)
            {
                ex.Day = this.radioButton5.Text;
            }
            else
            {
                ex.Day = this.radioButton6.Text;
            }

            if (this.radioButtonSlot1.Checked)
            {
                ex.Slot = this.radioButtonSlot1.Text;
            }
            else if (this.radioButtonSlot2.Checked)
            {
                ex.Slot = this.radioButtonSlot2.Text;
            }
            else if (this.radioButtonSlot3.Checked)
            {
                ex.Slot = this.radioButtonSlot3.Text;
            }
            else 
            {
                ex.Slot = this.radioButtonSlot4.Text;
            }

            ex.AssignedFacultyId = acc[0];

            ExamRepository eRepo = new ExamRepository();
            CourseRepository cRepo = new CourseRepository();

            if (eRepo.CheckExamCourseId2(ex.CourseId) == false)
            {
                if (cRepo.CheckCourseIdAndSemesterName2(c))
                {
                    if (ex.Room != "" && eRepo.Insert2(ex))
                    {
                        MessageBox.Show("One Exam Added", "Successful");
                        this.dataGridViewExam.DataSource = eRepo.GetAllExams2();
                    }
                    else
                    {
                        MessageBox.Show("Fill All The Fields", "Failed");
                    }
                }
                else
                {
                    MessageBox.Show("There Is No Such Course In This Semester", "Failed");
                }
            }
            else
            {
                MessageBox.Show("Exam For This Course ID Already Exists", "Failed");
            }
        }

        private void UpdateClicked(object sender, EventArgs e)
        {
            Exam ex = new Exam();
            Course c = new Course();
            string[] acc = this.comboBoxFacultyId.Text.Split(' ');
            string[] acc2 = this.comboBoxCourseId.Text.Split(' ');
            ex.CourseId = acc2[0];
            c.CourseId = acc2[0];
            ex.Semester = this.comboBoxSemesterName.Text;
            c.Semester = this.comboBoxSemesterName.Text;
            ex.Room = this.textBoxRoom.Text;

            if (this.radioButton1.Checked)
            {
                ex.Day = this.radioButton1.Text;
            }
            else if (this.radioButton2.Checked)
            {
                ex.Day = this.radioButton2.Text;
            }
            else if (this.radioButton3.Checked)
            {
                ex.Day = this.radioButton3.Text;
            }
            else if (this.radioButton4.Checked)
            {
                ex.Day = this.radioButton4.Text;
            }
            else if (this.radioButton5.Checked)
            {
                ex.Day = this.radioButton5.Text;
            }
            else
            {
                ex.Day = this.radioButton6.Text;
            }

            if (this.radioButtonSlot1.Checked)
            {
                ex.Slot = this.radioButtonSlot1.Text;
            }
            else if (this.radioButtonSlot2.Checked)
            {
                ex.Slot = this.radioButtonSlot2.Text;
            }
            else if (this.radioButtonSlot3.Checked)
            {
                ex.Slot = this.radioButtonSlot3.Text;
            }
            else
            {
                ex.Slot = this.radioButtonSlot4.Text;
            }

            ex.AssignedFacultyId = acc[0];

            ExamRepository eRepo = new ExamRepository();
            CourseRepository cRepo = new CourseRepository();

            if (eRepo.CheckExamCourseId2(ex.CourseId))
            {
                if (cRepo.CheckCourseIdAndSemesterName2(c))
                {
                    if (ex.Room != "" && eRepo.Update2(ex))
                    {
                        MessageBox.Show("One Exam Updated", "Successful");
                        this.dataGridViewExam.DataSource = eRepo.GetAllExams2();
                    }
                    else
                    {
                        MessageBox.Show("Fill All The Fields", "Failed");
                    }
                }
                else
                {
                    MessageBox.Show("There Is No Such Course In This Semester", "Failed");
                }
            }
            else
            {
                MessageBox.Show("Exam For This Course ID Doesn't Exists", "Failed");
            }
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            ExamRepository eRepo = new ExamRepository();

            string[] acc2 = this.comboBoxCourseId.Text.Split(' '); 
            if (eRepo.Delete2(acc2[0]) != 0)
            {
                MessageBox.Show("One Exam Deleted", "Successful");
                this.dataGridViewExam.DataSource = eRepo.GetAllExams2();
            }
            else
            {
                MessageBox.Show("Exam For This Course ID Doesn't Exists", "Failed");
            }
        }

        private void RefreshClicked(object sender, EventArgs e)
        {
            ExamRepository eRepo = new ExamRepository();
            this.dataGridViewExam.DataSource = eRepo.GetAllExams2();
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

        private void SemesterSelected(object sender, EventArgs e)
        {
            CourseRepository cRepo = new CourseRepository();
            this.comboBoxCourseId.DataSource = cRepo.GetCourseIdNameSectionsBySemester2(this.comboBoxSemesterName.Text);
        }

        private void dataGridViewExamCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            SemesterRepository sRepo = new SemesterRepository();
            this.comboBoxSemesterName.DataSource = sRepo.GetAllSemesterNames2();

            CourseRepository cRepo = new CourseRepository();
            this.comboBoxCourseId.DataSource = cRepo.GetCourseIdNameSectionsBySemester2(this.comboBoxSemesterName.Text);

            AccountRepository aRepo = new AccountRepository();
            this.comboBoxFacultyId.DataSource = aRepo.GetAccountIdAndNames2("Faculty");

            this.comboBoxSemesterName.SelectedIndex = this.comboBoxSemesterName.FindString(this.dataGridViewExam.CurrentRow.Cells[1].Value.ToString());
            this.comboBoxCourseId.SelectedIndex = this.comboBoxCourseId.FindString(this.dataGridViewExam.CurrentRow.Cells[0].Value.ToString());
            this.textBoxRoom.Text = this.dataGridViewExam.CurrentRow.Cells[4].Value.ToString();
            this.comboBoxFacultyId.SelectedIndex = this.comboBoxFacultyId.FindString(this.dataGridViewExam.CurrentRow.Cells[5].Value.ToString());

            if (this.radioButton1.Text == this.dataGridViewExam.CurrentRow.Cells[2].Value.ToString())
            {
                this.radioButton1.Checked = true;
            }
            else if (this.radioButton2.Text == this.dataGridViewExam.CurrentRow.Cells[2].Value.ToString())
            {
                this.radioButton2.Checked = true;
            }
            else if (this.radioButton3.Text == this.dataGridViewExam.CurrentRow.Cells[2].Value.ToString())
            {
                this.radioButton3.Checked = true;
            }
            else if (this.radioButton4.Text == this.dataGridViewExam.CurrentRow.Cells[2].Value.ToString())
            {
                this.radioButton4.Checked = true;
            }
            else if (this.radioButton5.Text == this.dataGridViewExam.CurrentRow.Cells[2].Value.ToString())
            {
                this.radioButton5.Checked = true;
            }
            else
            {
                this.radioButton6.Checked = true;
            }

            if (this.radioButtonSlot1.Text == this.dataGridViewExam.CurrentRow.Cells[3].Value.ToString())
            {
                this.radioButtonSlot1.Checked = true;
            }
            else if (this.radioButtonSlot2.Text == this.dataGridViewExam.CurrentRow.Cells[3].Value.ToString())
            {
                this.radioButtonSlot2.Checked = true;
            }
            else if (this.radioButtonSlot3.Text == this.dataGridViewExam.CurrentRow.Cells[3].Value.ToString())
            {
                this.radioButtonSlot3.Checked = true;
            }
            else
            {
                this.radioButtonSlot4.Checked = true;
            }
        }
    }
}
