namespace UMS
{
    partial class RegistrationDept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStudentInfo = new System.Windows.Forms.Button();
            this.buttonEditSemester = new System.Windows.Forms.Button();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.buttonAssignCourse = new System.Windows.Forms.Button();
            this.buttonEditExam = new System.Windows.Forms.Button();
            this.buttonCheckScholarship = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStudentInfo
            // 
            this.buttonStudentInfo.Location = new System.Drawing.Point(196, 94);
            this.buttonStudentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudentInfo.Name = "buttonStudentInfo";
            this.buttonStudentInfo.Size = new System.Drawing.Size(156, 49);
            this.buttonStudentInfo.TabIndex = 0;
            this.buttonStudentInfo.Text = "View Student Info";
            this.buttonStudentInfo.UseVisualStyleBackColor = true;
            this.buttonStudentInfo.Click += new System.EventHandler(this.ViewStudentInfoClicked);
            // 
            // buttonEditSemester
            // 
            this.buttonEditSemester.Location = new System.Drawing.Point(196, 158);
            this.buttonEditSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditSemester.Name = "buttonEditSemester";
            this.buttonEditSemester.Size = new System.Drawing.Size(156, 51);
            this.buttonEditSemester.TabIndex = 1;
            this.buttonEditSemester.Text = "Edit Semester";
            this.buttonEditSemester.UseVisualStyleBackColor = true;
            this.buttonEditSemester.Click += new System.EventHandler(this.EditSemesterClicked);
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.Location = new System.Drawing.Point(196, 226);
            this.buttonEditCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(156, 51);
            this.buttonEditCourse.TabIndex = 2;
            this.buttonEditCourse.Text = "Edit Course";
            this.buttonEditCourse.UseVisualStyleBackColor = true;
            this.buttonEditCourse.Click += new System.EventHandler(this.EditCourseClicked);
            // 
            // buttonAssignCourse
            // 
            this.buttonAssignCourse.Location = new System.Drawing.Point(196, 294);
            this.buttonAssignCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAssignCourse.Name = "buttonAssignCourse";
            this.buttonAssignCourse.Size = new System.Drawing.Size(156, 51);
            this.buttonAssignCourse.TabIndex = 3;
            this.buttonAssignCourse.Text = "Assign Course";
            this.buttonAssignCourse.UseVisualStyleBackColor = true;
            this.buttonAssignCourse.Click += new System.EventHandler(this.AssignCourseClicked);
            // 
            // buttonEditExam
            // 
            this.buttonEditExam.Location = new System.Drawing.Point(196, 362);
            this.buttonEditExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditExam.Name = "buttonEditExam";
            this.buttonEditExam.Size = new System.Drawing.Size(156, 51);
            this.buttonEditExam.TabIndex = 4;
            this.buttonEditExam.Text = "Edit Exam";
            this.buttonEditExam.UseVisualStyleBackColor = true;
            this.buttonEditExam.Click += new System.EventHandler(this.EditExamClicked);
            // 
            // buttonCheckScholarship
            // 
            this.buttonCheckScholarship.Location = new System.Drawing.Point(196, 436);
            this.buttonCheckScholarship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCheckScholarship.Name = "buttonCheckScholarship";
            this.buttonCheckScholarship.Size = new System.Drawing.Size(156, 51);
            this.buttonCheckScholarship.TabIndex = 5;
            this.buttonCheckScholarship.Text = "Check Scholarship";
            this.buttonCheckScholarship.UseVisualStyleBackColor = true;
            this.buttonCheckScholarship.Click += new System.EventHandler(this.CheckScholarshipClicked);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(413, 10);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(108, 43);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // RegistrationDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(556, 449);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonCheckScholarship);
            this.Controls.Add(this.buttonEditExam);
            this.Controls.Add(this.buttonAssignCourse);
            this.Controls.Add(this.buttonEditCourse);
            this.Controls.Add(this.buttonEditSemester);
            this.Controls.Add(this.buttonStudentInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrationDept";
            this.Text = "RegistrationDept";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudentInfo;
        private System.Windows.Forms.Button buttonEditSemester;
        private System.Windows.Forms.Button buttonEditCourse;
        private System.Windows.Forms.Button buttonAssignCourse;
        private System.Windows.Forms.Button buttonEditExam;
        private System.Windows.Forms.Button buttonCheckScholarship;
        private System.Windows.Forms.Button buttonLogOut;
    }
}