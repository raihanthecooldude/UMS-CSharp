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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace UMS
{
    public partial class CreateRoutine : Form
    {
        public CreateRoutine()
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
        private void createpdfbutton_Click(object sender, EventArgs e)
        {
            
            CourseRegistrationRepository r = new CourseRegistrationRepository();
            AccountRepository ar = new AccountRepository();
            if (r.RoutineVerification2(this.accountidtextBox.Text, this.semestertextBox.Text))
            {
                List<Course> aList = r.GetAllCourse2(this.accountidtextBox.Text, this.semestertextBox.Text);
                string q = this.accountidtextBox.Text + this.semestertextBox.Text + ".pdf";
                FileStream fs = new FileStream(q, FileMode.Create, FileAccess.Write, FileShare.None);
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                Paragraph p = new Paragraph(this.accountidtextBox.Text);
                p.Alignment = Element.ALIGN_CENTER;
                doc.Add(p);
                Paragraph s = new Paragraph(this.semestertextBox.Text);
                s.Alignment = Element.ALIGN_CENTER;
                doc.Add(s);
                Paragraph n = new Paragraph(ar.GetAccountTypeShovon2(this.accountidtextBox.Text).Name);
                n.Alignment = Element.ALIGN_RIGHT;
                doc.Add(n);
                foreach (Course c in aList)
                {
                    Paragraph c1 = new Paragraph(c.Name + "    " + c.Schedule);
                    doc.Add(c1);

                }
                MessageBox.Show("Routine Created");

                doc.Close();
            }
            else
            {
                MessageBox.Show("Student Is Not Registered For This Semester");
 
            }
           
        }

        private void CloseClicked(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseRegistrationRepository r = new CourseRegistrationRepository();
            AccountRepository ar = new AccountRepository();
            StudentBalanceRepository sr=new StudentBalanceRepository();
            if (r.RoutineVerification2(this.accountidtextBox.Text, this.semestertextBox.Text))
            {
                List<Course> aList = r.GetAllCourse2(this.accountidtextBox.Text, this.semestertextBox.Text);
                string q = this.accountidtextBox.Text + this.semestertextBox.Text + "payment.pdf";
                FileStream fs = new FileStream(q, FileMode.Create, FileAccess.Write, FileShare.None);
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                Paragraph p = new Paragraph(this.accountidtextBox.Text);
                p.Alignment = Element.ALIGN_CENTER;
                doc.Add(p);
                Paragraph s = new Paragraph(this.semestertextBox.Text);
                s.Alignment = Element.ALIGN_CENTER;
                doc.Add(s);
                Paragraph n = new Paragraph(ar.GetAccountTypeShovon2(this.accountidtextBox.Text).Name);
                n.Alignment = Element.ALIGN_RIGHT;
                doc.Add(n);
                foreach (Course c in aList)
                {
                    Paragraph c1 = new Paragraph(c.Name + "    " + c.Schedule);
                    doc.Add(c1);

                }
                Paragraph p1 = new Paragraph("Pay:"+sr.GetBalance(this.accountidtextBox.Text).ToString()+"Taka");
                 doc.Add(p1);


                MessageBox.Show("Payment Created");

                doc.Close();
            }
            else
            {
                MessageBox.Show("Student Is Not Registered For This Semester");
 
            }
           
        }
        }

    }


