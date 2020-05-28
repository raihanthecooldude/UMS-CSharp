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
    public partial class Chatting : Form
    {
        public string ID, User;
        public Chatting(string ID, string User)
        {
            InitializeComponent();
            this.ID = ID;
            this.User = User;
            this.NameLabel.Text = "Welcome " + User;
            SemesterRepository sr = new SemesterRepository();
            this.SemesterComboBox.DataSource = sr.GetAllSemesterName();

            GetMsgBox(ID);
        }

        private void BackClicked(object sender, EventArgs e)
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

        private string semester, course, section;

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            semester = this.SemesterComboBox.Text;
            CourseRegistrationRepository cr = new CourseRegistrationRepository();
            this.CourseComboBox.DataSource = cr.GetOnlyCourses(semester, ID);
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            course = this.CourseComboBox.Text;
            CourseRegistrationRepository cr = new CourseRegistrationRepository();
            this.SectionComboBox.DataSource = cr.GetOnlySection(semester, ID, course);
        }

        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            section = this.SectionComboBox.Text;
            CourseRegistrationRepository cr = new CourseRegistrationRepository();
            this.IDComboBox.DataSource = cr.GetOnlyID(semester, ID, course, section);
        }

        private void ClearMsgClicked(object sender, EventArgs e)
        {
            this.InboxLabel.Text = "";
        }

        private void SendMsgClicked(object sender, EventArgs e)
        {
            string msg = this.OutboxTextBox.Text;
            string id = this.IDComboBox.Text;

            ChatRepository cr = new ChatRepository();
            if (cr.SendMsg(ID, id, msg, User))
            {
                MessageBox.Show("Message Sent", "Done");
            }
            else
            {
                MessageBox.Show("Message cannot be sent", "Error");
            }
        }

        public void GetMsgBox(string id)
        {
            List<Chat> chList = new List<Chat>();
            ChatRepository cr = new ChatRepository();
            chList = cr.GetMsg(id);
            for (int i = 0; i < chList.Count; i++)
            {
                this.InboxLabel.Text += chList[i].Msg.ToString() + "\n";
            }
        }

        //private void CloseClicked(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
