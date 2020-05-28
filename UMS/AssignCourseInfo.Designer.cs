namespace UMS
{
    partial class AssignCourseInfo
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
            this.components = new System.ComponentModel.Container();
            this.labelSelectTeacherAccountId = new System.Windows.Forms.Label();
            this.labelSelectCourseToAssign = new System.Windows.Forms.Label();
            this.labelSelectSemester = new System.Windows.Forms.Label();
            this.labelSelectSection = new System.Windows.Forms.Label();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.comboBoxAssignedCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxSemesterName = new System.Windows.Forms.ComboBox();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.AssignedCourses = new System.Windows.Forms.Label();
            this.dataGridViewAssignedCourses = new System.Windows.Forms.DataGridView();
            this.assignCourseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignCourseTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectTeacherAccountId
            // 
            this.labelSelectTeacherAccountId.AutoSize = true;
            this.labelSelectTeacherAccountId.Location = new System.Drawing.Point(12, 108);
            this.labelSelectTeacherAccountId.Name = "labelSelectTeacherAccountId";
            this.labelSelectTeacherAccountId.Size = new System.Drawing.Size(179, 20);
            this.labelSelectTeacherAccountId.TabIndex = 0;
            this.labelSelectTeacherAccountId.Text = "Select Teacher Account";
            // 
            // labelSelectCourseToAssign
            // 
            this.labelSelectCourseToAssign.AutoSize = true;
            this.labelSelectCourseToAssign.Location = new System.Drawing.Point(12, 292);
            this.labelSelectCourseToAssign.Name = "labelSelectCourseToAssign";
            this.labelSelectCourseToAssign.Size = new System.Drawing.Size(183, 20);
            this.labelSelectCourseToAssign.TabIndex = 1;
            this.labelSelectCourseToAssign.Text = "Select Course To Assign";
            // 
            // labelSelectSemester
            // 
            this.labelSelectSemester.AutoSize = true;
            this.labelSelectSemester.Location = new System.Drawing.Point(302, 108);
            this.labelSelectSemester.Name = "labelSelectSemester";
            this.labelSelectSemester.Size = new System.Drawing.Size(127, 20);
            this.labelSelectSemester.TabIndex = 2;
            this.labelSelectSemester.Text = "Select Semester";
            // 
            // labelSelectSection
            // 
            this.labelSelectSection.AutoSize = true;
            this.labelSelectSection.Location = new System.Drawing.Point(302, 292);
            this.labelSelectSection.Name = "labelSelectSection";
            this.labelSelectSection.Size = new System.Drawing.Size(112, 20);
            this.labelSelectSection.TabIndex = 3;
            this.labelSelectSection.Text = "Select Section";
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(15, 147);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(266, 28);
            this.comboBoxAccount.TabIndex = 4;
            // 
            // comboBoxAssignedCourse
            // 
            this.comboBoxAssignedCourse.FormattingEnabled = true;
            this.comboBoxAssignedCourse.Location = new System.Drawing.Point(16, 331);
            this.comboBoxAssignedCourse.Name = "comboBoxAssignedCourse";
            this.comboBoxAssignedCourse.Size = new System.Drawing.Size(265, 28);
            this.comboBoxAssignedCourse.TabIndex = 5;
            this.comboBoxAssignedCourse.SelectedIndexChanged += new System.EventHandler(this.AssignedCourseSelected);
            // 
            // comboBoxSemesterName
            // 
            this.comboBoxSemesterName.FormattingEnabled = true;
            this.comboBoxSemesterName.Location = new System.Drawing.Point(302, 145);
            this.comboBoxSemesterName.Name = "comboBoxSemesterName";
            this.comboBoxSemesterName.Size = new System.Drawing.Size(197, 28);
            this.comboBoxSemesterName.TabIndex = 6;
            this.comboBoxSemesterName.SelectedIndexChanged += new System.EventHandler(this.SemesterSelected);
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(306, 329);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(193, 28);
            this.comboBoxSection.TabIndex = 7;
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(222, 469);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(129, 49);
            this.buttonAssign.TabIndex = 8;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.AssignClicked);
            // 
            // AssignedCourses
            // 
            this.AssignedCourses.AutoSize = true;
            this.AssignedCourses.Location = new System.Drawing.Point(522, 108);
            this.AssignedCourses.Name = "AssignedCourses";
            this.AssignedCourses.Size = new System.Drawing.Size(138, 20);
            this.AssignedCourses.TabIndex = 9;
            this.AssignedCourses.Text = "Assigned Courses";
            // 
            // dataGridViewAssignedCourses
            // 
            this.dataGridViewAssignedCourses.AllowUserToAddRows = false;
            this.dataGridViewAssignedCourses.AllowUserToDeleteRows = false;
            this.dataGridViewAssignedCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedCourses.Location = new System.Drawing.Point(526, 174);
            this.dataGridViewAssignedCourses.Name = "dataGridViewAssignedCourses";
            this.dataGridViewAssignedCourses.ReadOnly = true;
            this.dataGridViewAssignedCourses.RowTemplate.Height = 28;
            this.dataGridViewAssignedCourses.Size = new System.Drawing.Size(534, 344);
            this.dataGridViewAssignedCourses.TabIndex = 10;
            // 
            // assignCourseTableBindingSource
            // 
            this.assignCourseTableBindingSource.DataMember = "AssignCourseTable";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(931, 108);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(129, 49);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.RefreshClicked);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(932, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(122, 54);
            this.buttonLogOut.TabIndex = 12;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 54);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackClicked);
            // 
            // AssignCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewAssignedCourses);
            this.Controls.Add(this.AssignedCourses);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.comboBoxSemesterName);
            this.Controls.Add(this.comboBoxAssignedCourse);
            this.Controls.Add(this.comboBoxAccount);
            this.Controls.Add(this.labelSelectSection);
            this.Controls.Add(this.labelSelectSemester);
            this.Controls.Add(this.labelSelectCourseToAssign);
            this.Controls.Add(this.labelSelectTeacherAccountId);
            this.Name = "AssignCourseInfo";
            this.Text = "Assign Course Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignCourseTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectTeacherAccountId;
        private System.Windows.Forms.Label labelSelectCourseToAssign;
        private System.Windows.Forms.Label labelSelectSemester;
        private System.Windows.Forms.Label labelSelectSection;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.ComboBox comboBoxAssignedCourse;
        private System.Windows.Forms.ComboBox comboBoxSemesterName;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Label AssignedCourses;
        private System.Windows.Forms.DataGridView dataGridViewAssignedCourses;
        //private UMSDatabaseDataSet1 uMSDatabaseDataSet1;
        private System.Windows.Forms.BindingSource assignCourseTableBindingSource;
        //private UMSDatabaseDataSet1TableAdapters.AssignCourseTableTableAdapter assignCourseTableTableAdapter;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
    }
}