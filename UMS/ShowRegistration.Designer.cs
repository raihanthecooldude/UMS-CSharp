namespace UMS
{
    partial class ShowRegistration
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.BackLabel = new System.Windows.Forms.Label();
            this.SemesterComboBox = new System.Windows.Forms.ComboBox();
            this.SelectSemesterLabel = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.SelectCourseLabel = new System.Windows.Forms.Label();
            this.DoneRegistrationBtn = new System.Windows.Forms.Button();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(604, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(251, 32);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.Location = new System.Drawing.Point(63, 9);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(100, 23);
            this.LogOutLabel.TabIndex = 14;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // BackLabel
            // 
            this.BackLabel.Location = new System.Drawing.Point(5, 9);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(67, 23);
            this.BackLabel.TabIndex = 13;
            this.BackLabel.Text = "Back";
            this.BackLabel.Click += new System.EventHandler(this.BackClicked);
            // 
            // SemesterComboBox
            // 
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Location = new System.Drawing.Point(174, 77);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(157, 24);
            this.SemesterComboBox.TabIndex = 16;
            this.SemesterComboBox.Text = "Semester";
            this.SemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.SemesterComboBox_SelectedIndexChanged);
            // 
            // SelectSemesterLabel
            // 
            this.SelectSemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSemesterLabel.Location = new System.Drawing.Point(4, 77);
            this.SelectSemesterLabel.Name = "SelectSemesterLabel";
            this.SelectSemesterLabel.Size = new System.Drawing.Size(177, 46);
            this.SelectSemesterLabel.TabIndex = 17;
            this.SelectSemesterLabel.Text = "Select Semester: ";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(174, 151);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(157, 24);
            this.CourseComboBox.TabIndex = 18;
            this.CourseComboBox.Text = "Course";
            this.CourseComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseComboBox_SelectedIndexChanged);
            // 
            // SelectCourseLabel
            // 
            this.SelectCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCourseLabel.Location = new System.Drawing.Point(4, 151);
            this.SelectCourseLabel.Name = "SelectCourseLabel";
            this.SelectCourseLabel.Size = new System.Drawing.Size(177, 46);
            this.SelectCourseLabel.TabIndex = 21;
            this.SelectCourseLabel.Text = "Select Course: ";
            // 
            // DoneRegistrationBtn
            // 
            this.DoneRegistrationBtn.Location = new System.Drawing.Point(174, 313);
            this.DoneRegistrationBtn.Name = "DoneRegistrationBtn";
            this.DoneRegistrationBtn.Size = new System.Drawing.Size(157, 33);
            this.DoneRegistrationBtn.TabIndex = 24;
            this.DoneRegistrationBtn.Text = "Done";
            this.DoneRegistrationBtn.UseVisualStyleBackColor = true;
            this.DoneRegistrationBtn.Click += new System.EventHandler(this.DoneRegistrationClicked);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.BackColor = System.Drawing.Color.White;
            this.RegistrationLabel.Location = new System.Drawing.Point(504, 77);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(312, 390);
            this.RegistrationLabel.TabIndex = 25;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Location = new System.Drawing.Point(507, 497);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(157, 33);
            this.DownloadBtn.TabIndex = 26;
            this.DownloadBtn.Text = "Download";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadClicked);
            // 
            // ShowRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 606);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.DoneRegistrationBtn);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.SelectCourseLabel);
            this.Controls.Add(this.SemesterComboBox);
            this.Controls.Add(this.SelectSemesterLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.BackLabel);
            this.Name = "ShowRegistration";
            this.Text = "ShowRegistration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.Label SelectSemesterLabel;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label SelectCourseLabel;
        private System.Windows.Forms.Button DoneRegistrationBtn;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Button DownloadBtn;
    }
}