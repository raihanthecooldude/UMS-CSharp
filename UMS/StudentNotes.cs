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

namespace UMS
{
    public partial class StudentNotes : Form
    {
        private string ID, User;
        private string semester, courseName, section;
        public StudentNotes(string ID, string User, string semester, string courseName, string sectionName)
        {
            InitializeComponent();
            this.ID = ID;
            this.User = User;
            this.semester = semester;
            this.courseName = courseName;
            this.section = sectionName;
            this.NameLabel.Text = "Welcome " + User;
            this.SubjectLabel.Text = "Course: " + courseName;
            this.SubjectLabel.Visible = false;

            //NoteRepository nr = new NoteRepository();
            //List<Note> nList = new List<Note>();

            //nList = nr.GetAllNotes(semester, ID);
            //DataTable nTable = new DataTable();
            //nTable.Columns.Add("Notes", typeof(FileDialog));

            //string path = Application.StartupPath;

            //for (int i = 0; i < nList.Count; i++)
            //{
            //    nTable.Rows.Add(path + nList[i].NotePath);

            //}

            NoticeRepository nc = new NoticeRepository();
            List<Notice> ncList = new List<Notice>();

            CourseRepository cr = new CourseRepository();
            Course cs = new Course();
            cs = cr.GetCourseId(courseName, semester, section);

            ncList = nc.GetAllNotice(semester, cs.CourseId, section);
            DataTable ncTable = new DataTable();
            ncTable.Columns.Add("Date", typeof(string));
            ncTable.Columns.Add("Notice", typeof(string));

            for (int i = 0; i < ncList.Count; i++)
            {
                ncTable.Rows.Add(ncList[i].Date, ncList[i].Noticee);
            }

            NotesGridView.DataSource = ncTable;
            NotesGridView.ReadOnly = true;
        }

        private void BackCLicked(object sender, EventArgs e)
        {
            StudentHome sh = new StudentHome(ID, User);
            sh.Show();
            this.Hide();
        }

        private void LogOutClicked(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void DropClicked(object sender, EventArgs e)
        {
            CourseRegistrationRepository cor = new CourseRegistrationRepository();
            if (cor.DropCourse(ID, semester, courseName))
            {
                MessageBox.Show("Dropping for this subject is Applied", "Done");
            }
            else
            {
                MessageBox.Show("Dropping this subject is not possible", "Error");
            }
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
