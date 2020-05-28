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
    public partial class ApplyVacation : Form
    {
        private string uId;
        public ApplyVacation(string userId)
        {
            InitializeComponent();
            uId = userId;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            TeacherRepository tr = new TeacherRepository();
            if (tr.UpdateStatusNadim(uId))
            {
                MessageBox.Show("Vacation Applied");
                this.Hide();
                FacultyHome cs = new FacultyHome(uId);
                cs.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyHome cs = new FacultyHome(uId);
            cs.Show();
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FacultyHome cs = new FacultyHome(uId);
            cs.Show();
        }
    }
}
