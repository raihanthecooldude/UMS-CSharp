namespace UMS
{
    partial class StudentHome
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
            this.CoursesBtn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.ResultBtn = new System.Windows.Forms.Button();
            this.OfferedCoursesBtn = new System.Windows.Forms.Button();
            this.SemesterComboBox = new System.Windows.Forms.ComboBox();
            this.Course1Btn = new System.Windows.Forms.Button();
            this.Course2Btn = new System.Windows.Forms.Button();
            this.Course3Btn = new System.Windows.Forms.Button();
            this.Course5Btn = new System.Windows.Forms.Button();
            this.Course6Btn = new System.Windows.Forms.Button();
            this.Course4Btn = new System.Windows.Forms.Button();
            this.ChatBtn = new System.Windows.Forms.Button();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoursesBtn
            // 
            this.CoursesBtn.Location = new System.Drawing.Point(31, 120);
            this.CoursesBtn.Name = "CoursesBtn";
            this.CoursesBtn.Size = new System.Drawing.Size(139, 34);
            this.CoursesBtn.TabIndex = 2;
            this.CoursesBtn.Text = "Courses";
            this.CoursesBtn.UseVisualStyleBackColor = true;
            this.CoursesBtn.Click += new System.EventHandler(this.CourseBtnClicked);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(605, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(251, 32);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.Location = new System.Drawing.Point(12, 11);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(100, 23);
            this.LogOutLabel.TabIndex = 7;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // ResultBtn
            // 
            this.ResultBtn.Location = new System.Drawing.Point(31, 175);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(139, 34);
            this.ResultBtn.TabIndex = 8;
            this.ResultBtn.Text = "Results";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultsClicked);
            // 
            // OfferedCoursesBtn
            // 
            this.OfferedCoursesBtn.Location = new System.Drawing.Point(31, 230);
            this.OfferedCoursesBtn.Name = "OfferedCoursesBtn";
            this.OfferedCoursesBtn.Size = new System.Drawing.Size(139, 34);
            this.OfferedCoursesBtn.TabIndex = 9;
            this.OfferedCoursesBtn.Text = "Offered Courses";
            this.OfferedCoursesBtn.UseVisualStyleBackColor = true;
            this.OfferedCoursesBtn.Click += new System.EventHandler(this.OfferedCoursesClicked);
            // 
            // SemesterComboBox
            // 
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Location = new System.Drawing.Point(668, 84);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(157, 24);
            this.SemesterComboBox.TabIndex = 12;
            this.SemesterComboBox.Text = "Semester";
            this.SemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.SemesterComboBox_SelectedIndexChanged);
            // 
            // Course1Btn
            // 
            this.Course1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Course1Btn.Location = new System.Drawing.Point(308, 175);
            this.Course1Btn.Name = "Course1Btn";
            this.Course1Btn.Size = new System.Drawing.Size(233, 67);
            this.Course1Btn.TabIndex = 13;
            this.Course1Btn.UseVisualStyleBackColor = true;
            this.Course1Btn.Click += new System.EventHandler(this.Course1Clicked);
            // 
            // Course2Btn
            // 
            this.Course2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Course2Btn.Location = new System.Drawing.Point(592, 175);
            this.Course2Btn.Name = "Course2Btn";
            this.Course2Btn.Size = new System.Drawing.Size(233, 67);
            this.Course2Btn.TabIndex = 14;
            this.Course2Btn.UseVisualStyleBackColor = true;
            this.Course2Btn.Click += new System.EventHandler(this.Course2Clicked);
            // 
            // Course3Btn
            // 
            this.Course3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Course3Btn.Location = new System.Drawing.Point(308, 314);
            this.Course3Btn.Name = "Course3Btn";
            this.Course3Btn.Size = new System.Drawing.Size(233, 67);
            this.Course3Btn.TabIndex = 15;
            this.Course3Btn.UseVisualStyleBackColor = true;
            this.Course3Btn.Click += new System.EventHandler(this.Course3Clicked);
            // 
            // Course5Btn
            // 
            this.Course5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Course5Btn.Location = new System.Drawing.Point(308, 456);
            this.Course5Btn.Name = "Course5Btn";
            this.Course5Btn.Size = new System.Drawing.Size(233, 67);
            this.Course5Btn.TabIndex = 16;
            this.Course5Btn.UseVisualStyleBackColor = true;
            this.Course5Btn.Click += new System.EventHandler(this.Course5Clicked);
            // 
            // Course6Btn
            // 
            this.Course6Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Course6Btn.Location = new System.Drawing.Point(592, 456);
            this.Course6Btn.Name = "Course6Btn";
            this.Course6Btn.Size = new System.Drawing.Size(233, 67);
            this.Course6Btn.TabIndex = 17;
            this.Course6Btn.UseVisualStyleBackColor = true;
            this.Course6Btn.Click += new System.EventHandler(this.Course6Clicked);
            // 
            // Course4Btn
            // 
            this.Course4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Course4Btn.Location = new System.Drawing.Point(592, 314);
            this.Course4Btn.Name = "Course4Btn";
            this.Course4Btn.Size = new System.Drawing.Size(233, 67);
            this.Course4Btn.TabIndex = 18;
            this.Course4Btn.UseVisualStyleBackColor = true;
            this.Course4Btn.Click += new System.EventHandler(this.Course4Clicked);
            // 
            // ChatBtn
            // 
            this.ChatBtn.Location = new System.Drawing.Point(31, 285);
            this.ChatBtn.Name = "ChatBtn";
            this.ChatBtn.Size = new System.Drawing.Size(139, 34);
            this.ChatBtn.TabIndex = 19;
            this.ChatBtn.Text = "Chat";
            this.ChatBtn.UseVisualStyleBackColor = true;
            this.ChatBtn.Click += new System.EventHandler(this.ChatClicked);
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Location = new System.Drawing.Point(31, 341);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(139, 34);
            this.RegistrationBtn.TabIndex = 20;
            this.RegistrationBtn.Text = "Registration";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationClicked);
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 606);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.ChatBtn);
            this.Controls.Add(this.Course4Btn);
            this.Controls.Add(this.Course6Btn);
            this.Controls.Add(this.Course5Btn);
            this.Controls.Add(this.Course3Btn);
            this.Controls.Add(this.Course2Btn);
            this.Controls.Add(this.Course1Btn);
            this.Controls.Add(this.SemesterComboBox);
            this.Controls.Add(this.OfferedCoursesBtn);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CoursesBtn);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CoursesBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.Button OfferedCoursesBtn;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.Button Course1Btn;
        private System.Windows.Forms.Button Course2Btn;
        private System.Windows.Forms.Button Course3Btn;
        private System.Windows.Forms.Button Course5Btn;
        private System.Windows.Forms.Button Course6Btn;
        private System.Windows.Forms.Button Course4Btn;
        private System.Windows.Forms.Button ChatBtn;
        private System.Windows.Forms.Button RegistrationBtn;
    }
}