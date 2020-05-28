namespace UMS
{
    partial class UploadGrade
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectSemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectStudent = new System.Windows.Forms.ComboBox();
            this.buttonUploadQuizMark = new System.Windows.Forms.Button();
            this.buttonUploadTermMark = new System.Windows.Forms.Button();
            this.buttonUploadQuiz = new System.Windows.Forms.Button();
            this.buttonUploadTerm = new System.Windows.Forms.Button();
            this.numericUpDownUploadQuizMark = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUploadTermMark = new System.Windows.Forms.NumericUpDown();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUploadQuizMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUploadTermMark)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(732, 26);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(46, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Semester : ";
            // 
            // comboBoxSelectSemester
            // 
            this.comboBoxSelectSemester.FormattingEnabled = true;
            this.comboBoxSelectSemester.Location = new System.Drawing.Point(440, 103);
            this.comboBoxSelectSemester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectSemester.Name = "comboBoxSelectSemester";
            this.comboBoxSelectSemester.Size = new System.Drawing.Size(275, 24);
            this.comboBoxSelectSemester.TabIndex = 2;
            this.comboBoxSelectSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectSemester_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Course : ";
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(440, 176);
            this.comboBoxSelectCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(275, 24);
            this.comboBoxSelectCourse.TabIndex = 4;
            this.comboBoxSelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCourse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Student : ";
            // 
            // comboBoxSelectStudent
            // 
            this.comboBoxSelectStudent.FormattingEnabled = true;
            this.comboBoxSelectStudent.Location = new System.Drawing.Point(440, 247);
            this.comboBoxSelectStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectStudent.Name = "comboBoxSelectStudent";
            this.comboBoxSelectStudent.Size = new System.Drawing.Size(275, 24);
            this.comboBoxSelectStudent.TabIndex = 6;
            this.comboBoxSelectStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectStudent_SelectedIndexChanged);
            // 
            // buttonUploadQuizMark
            // 
            this.buttonUploadQuizMark.Location = new System.Drawing.Point(168, 366);
            this.buttonUploadQuizMark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUploadQuizMark.Name = "buttonUploadQuizMark";
            this.buttonUploadQuizMark.Size = new System.Drawing.Size(239, 28);
            this.buttonUploadQuizMark.TabIndex = 7;
            this.buttonUploadQuizMark.Text = "Upload Quiz Mark";
            this.buttonUploadQuizMark.UseVisualStyleBackColor = true;
            this.buttonUploadQuizMark.Click += new System.EventHandler(this.buttonUploadQuizMark_Click);
            // 
            // buttonUploadTermMark
            // 
            this.buttonUploadTermMark.Location = new System.Drawing.Point(561, 366);
            this.buttonUploadTermMark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUploadTermMark.Name = "buttonUploadTermMark";
            this.buttonUploadTermMark.Size = new System.Drawing.Size(239, 28);
            this.buttonUploadTermMark.TabIndex = 8;
            this.buttonUploadTermMark.Text = "Upload Term Mark";
            this.buttonUploadTermMark.UseVisualStyleBackColor = true;
            this.buttonUploadTermMark.Click += new System.EventHandler(this.buttonUploadTermMark_Click);
            // 
            // buttonUploadQuiz
            // 
            this.buttonUploadQuiz.Location = new System.Drawing.Point(228, 490);
            this.buttonUploadQuiz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUploadQuiz.Name = "buttonUploadQuiz";
            this.buttonUploadQuiz.Size = new System.Drawing.Size(119, 28);
            this.buttonUploadQuiz.TabIndex = 11;
            this.buttonUploadQuiz.Text = "Upload";
            this.buttonUploadQuiz.UseVisualStyleBackColor = true;
            this.buttonUploadQuiz.Click += new System.EventHandler(this.buttonUploadQuiz_Click);
            // 
            // buttonUploadTerm
            // 
            this.buttonUploadTerm.Location = new System.Drawing.Point(633, 490);
            this.buttonUploadTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUploadTerm.Name = "buttonUploadTerm";
            this.buttonUploadTerm.Size = new System.Drawing.Size(119, 28);
            this.buttonUploadTerm.TabIndex = 12;
            this.buttonUploadTerm.Text = "Upload";
            this.buttonUploadTerm.UseVisualStyleBackColor = true;
            this.buttonUploadTerm.Click += new System.EventHandler(this.buttonUploadTerm_Click);
            // 
            // numericUpDownUploadQuizMark
            // 
            this.numericUpDownUploadQuizMark.Location = new System.Drawing.Point(168, 430);
            this.numericUpDownUploadQuizMark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownUploadQuizMark.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownUploadQuizMark.Name = "numericUpDownUploadQuizMark";
            this.numericUpDownUploadQuizMark.Size = new System.Drawing.Size(239, 22);
            this.numericUpDownUploadQuizMark.TabIndex = 13;
            // 
            // numericUpDownUploadTermMark
            // 
            this.numericUpDownUploadTermMark.Location = new System.Drawing.Point(561, 430);
            this.numericUpDownUploadTermMark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownUploadTermMark.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownUploadTermMark.Name = "numericUpDownUploadTermMark";
            this.numericUpDownUploadTermMark.Size = new System.Drawing.Size(239, 22);
            this.numericUpDownUploadTermMark.TabIndex = 14;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(733, 58);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(189, 28);
            this.buttonLogOut.TabIndex = 15;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(37, 26);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // UploadGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.numericUpDownUploadTermMark);
            this.Controls.Add(this.numericUpDownUploadQuizMark);
            this.Controls.Add(this.buttonUploadTerm);
            this.Controls.Add(this.buttonUploadQuiz);
            this.Controls.Add(this.buttonUploadTermMark);
            this.Controls.Add(this.buttonUploadQuizMark);
            this.Controls.Add(this.comboBoxSelectStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSelectSemester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UploadGrade";
            this.Text = "UploadGrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUploadQuizMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUploadTermMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectStudent;
        private System.Windows.Forms.Button buttonUploadQuizMark;
        private System.Windows.Forms.Button buttonUploadTermMark;
        private System.Windows.Forms.Button buttonUploadQuiz;
        private System.Windows.Forms.Button buttonUploadTerm;
        private System.Windows.Forms.NumericUpDown numericUpDownUploadQuizMark;
        private System.Windows.Forms.NumericUpDown numericUpDownUploadTermMark;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
    }
}