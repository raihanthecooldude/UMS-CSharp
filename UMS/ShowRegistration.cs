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
using System.Data.SqlClient;
using Repository;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace UMS
{
    public partial class ShowRegistration : Form
    {
        private string ID, User;
        public ShowRegistration(string ID, string User)
        {
            InitializeComponent();
            this.ID = ID;
            this.User = User;
            this.NameLabel.Text = "Welcome " + User;
            SemesterRepository sr = new SemesterRepository();
            this.SemesterComboBox.DataSource = sr.GetAllSemesterName();

            this.RegistrationLabel.Text = "Name: "+User.ToString()+"\nID: "+ID.ToString() + "\n\n";
        }

        private void BackClicked(object sender, EventArgs e)
        {

            this.CourseComboBox.Visible = true;
            this.SelectCourseLabel.Visible = true;
            this.DoneRegistrationBtn.Visible = true;
            StudentHome sh = new StudentHome(ID, User);
            sh.Show();
            this.Hide();
        }

        private void LogOutClicked(object sender, EventArgs e)
        {

            this.CourseComboBox.Visible = true;
            this.SelectCourseLabel.Visible = true;
            this.DoneRegistrationBtn.Visible = true;
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private string semester, course, section="";

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseComboBox.Items.Clear();
            CourseComboBox.Text = "";


            semester = this.SemesterComboBox.Text;
            SemesterRepository smr = new SemesterRepository();
            if (smr.CheckIsRegistrationOpen(semester))
            {
                this.CourseComboBox.Visible = true;
                this.SelectCourseLabel.Visible = true;
                this.DoneRegistrationBtn.Visible = true;
                CourseRepository cr = new CourseRepository();
                List<Course> cList = cr.GetAllCourses(semester, ID);
                for (int i = 0; i < cList.Count; i++)
                {
                    this.CourseComboBox.Items.Add(cList[i].Name + " " + cList[i].Section);
                }
            }
            else
            {
                this.CourseComboBox.Visible = false;
                this.SelectCourseLabel.Visible = false;
                this.DoneRegistrationBtn.Visible = false;
                MessageBox.Show("Registration for this semester is Closed", "Error");
            }


            
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            course = this.CourseComboBox.Text;
        }

        private void DoneRegistrationClicked(object sender, EventArgs e)
        {

            string fullName = CourseComboBox.Text;
            string nameCourse = fullName.Remove(fullName.Length - 2, 2);
            course = nameCourse;
            section = CourseComboBox.Text;
            section = "" + section[fullName.Length - 1];

            List<Course> cList = new List<Course>();
            CourseRepository cvr = new CourseRepository();
            cList = cvr.GetCourseIdStudent(course, semester, section);

            string courseId="";
            int maxStudent=0, currentStudent=0;
            for (int i = 0; i < cList.Count(); i++)
            {
                courseId = cList[i].CourseId;
                maxStudent = cList[i].MaxStudent;
                currentStudent = cList[i].CurrentStudent;
            }

            CourseRegistrationRepository cdr = new CourseRegistrationRepository();
            CourseResultsRepository xdr = new CourseResultsRepository();
            bool yo = xdr.DoReg(ID, courseId, semester, section, course);
            if (cdr.DoRegistration(ID, courseId, semester, section, course))
            {
                MessageBox.Show("Registration for this subject is Done", "Done");
            }
            else
            {
                MessageBox.Show("Registration for this subject is not Possible", "Error");
            }

            this.RegistrationLabel.Text += semester + ": " + course + " " + section + "\n";
        }

        private void DownloadClicked(object sender, EventArgs e)
        {
            string YOLO = this.RegistrationLabel.Text.ToString();
            FileStream fs = new FileStream("Registration" + ID.ToString() + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            Paragraph p = new Paragraph(YOLO);
            p.Alignment = Element.ALIGN_LEFT;
            doc.Add(p);
            doc.Close();
            MessageBox.Show("PDF of your Registration has been generated.", "Done");
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
