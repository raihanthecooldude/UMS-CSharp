namespace UMS
{
    partial class FacultyHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShowCourseStudent = new System.Windows.Forms.Button();
            this.buttonUploadNotice = new System.Windows.Forms.Button();
            this.buttonUploadGrade = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonApproveDrop = new System.Windows.Forms.Button();
            this.buttonApplyVacation = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonShowProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Semester";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(335, 76);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemester.TabIndex = 1;
            this.comboBoxSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemester_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 228);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonShowCourseStudent
            // 
            this.buttonShowCourseStudent.Location = new System.Drawing.Point(22, 121);
            this.buttonShowCourseStudent.Name = "buttonShowCourseStudent";
            this.buttonShowCourseStudent.Size = new System.Drawing.Size(165, 34);
            this.buttonShowCourseStudent.TabIndex = 5;
            this.buttonShowCourseStudent.Text = "Show Course Student";
            this.buttonShowCourseStudent.UseVisualStyleBackColor = true;
            this.buttonShowCourseStudent.Click += new System.EventHandler(this.buttonShowCourseStudent_Click);
            // 
            // buttonUploadNotice
            // 
            this.buttonUploadNotice.Location = new System.Drawing.Point(22, 177);
            this.buttonUploadNotice.Name = "buttonUploadNotice";
            this.buttonUploadNotice.Size = new System.Drawing.Size(165, 34);
            this.buttonUploadNotice.TabIndex = 6;
            this.buttonUploadNotice.Text = "Upload Notice";
            this.buttonUploadNotice.UseVisualStyleBackColor = true;
            this.buttonUploadNotice.Click += new System.EventHandler(this.buttonUploadNotice_Click);
            // 
            // buttonUploadGrade
            // 
            this.buttonUploadGrade.Location = new System.Drawing.Point(22, 232);
            this.buttonUploadGrade.Name = "buttonUploadGrade";
            this.buttonUploadGrade.Size = new System.Drawing.Size(165, 34);
            this.buttonUploadGrade.TabIndex = 7;
            this.buttonUploadGrade.Text = "Upload Grade";
            this.buttonUploadGrade.UseVisualStyleBackColor = true;
            this.buttonUploadGrade.Click += new System.EventHandler(this.buttonUploadGrade_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(560, 37);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(132, 23);
            this.buttonLogOut.TabIndex = 8;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonApproveDrop
            // 
            this.buttonApproveDrop.Location = new System.Drawing.Point(22, 290);
            this.buttonApproveDrop.Name = "buttonApproveDrop";
            this.buttonApproveDrop.Size = new System.Drawing.Size(165, 34);
            this.buttonApproveDrop.TabIndex = 9;
            this.buttonApproveDrop.Text = "Approve Drop";
            this.buttonApproveDrop.UseVisualStyleBackColor = true;
            this.buttonApproveDrop.Click += new System.EventHandler(this.buttonApproveDrop_Click);
            // 
            // buttonApplyVacation
            // 
            this.buttonApplyVacation.Location = new System.Drawing.Point(22, 344);
            this.buttonApplyVacation.Name = "buttonApplyVacation";
            this.buttonApplyVacation.Size = new System.Drawing.Size(165, 34);
            this.buttonApplyVacation.TabIndex = 10;
            this.buttonApplyVacation.Text = "Apply Vacation";
            this.buttonApplyVacation.UseVisualStyleBackColor = true;
            this.buttonApplyVacation.Click += new System.EventHandler(this.buttonApplyVacation_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(562, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "label1";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // buttonShowProfile
            // 
            this.buttonShowProfile.Location = new System.Drawing.Point(22, 68);
            this.buttonShowProfile.Name = "buttonShowProfile";
            this.buttonShowProfile.Size = new System.Drawing.Size(165, 34);
            this.buttonShowProfile.TabIndex = 12;
            this.buttonShowProfile.Text = "Show Profile";
            this.buttonShowProfile.UseVisualStyleBackColor = true;
            this.buttonShowProfile.Click += new System.EventHandler(this.buttonShowProfile_Click);
            // 
            // FacultyHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.buttonShowProfile);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonApplyVacation);
            this.Controls.Add(this.buttonApproveDrop);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonUploadGrade);
            this.Controls.Add(this.buttonUploadNotice);
            this.Controls.Add(this.buttonShowCourseStudent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FacultyHome";
            this.Text = "FacultyHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShowCourseStudent;
        private System.Windows.Forms.Button buttonUploadNotice;
        private System.Windows.Forms.Button buttonUploadGrade;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonApproveDrop;
        private System.Windows.Forms.Button buttonApplyVacation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonShowProfile;
    }
}