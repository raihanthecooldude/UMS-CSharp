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
    public partial class ShowProfile : Form
    {
        private string uId;
        public ShowProfile(string userId)
        {
            InitializeComponent();

            uId = userId;
            AccountRepository ar = new AccountRepository();
            Account ac = ar.GetAccount(uId);

            textBoxId.Text = ac.AccountId;
            textBoxName.Text = ac.Name;
            textBoxGender.Text = ac.Gender;
            textBoxAddress.Text = ac.Address;
            textBoxAccountType.Text = ac.AccountType;
            textBoxDOB.Text = ac.DOB;
            textBoxBloodGroup.Text = ac.BloodGroup;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textBoxAccountType.Text == "Student") 
            {
                StudentHome sh = new StudentHome(textBoxId.Text, textBoxName.Text);
                sh.Show();
                this.Hide();
            }
            else if (textBoxAccountType.Text == "Faculty") 
            {
                FacultyHome fh = new FacultyHome(textBoxId.Text);
                fh.Show();
                this.Hide();
            }
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
