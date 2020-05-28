namespace UMS
{
    partial class EditCourseInfo
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
            this.labelInsertCourse = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSemesterName = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSection = new System.Windows.Forms.TextBox();
            this.groupBoxCredit = new System.Windows.Forms.GroupBox();
            this.radioButton3Credits = new System.Windows.Forms.RadioButton();
            this.radioButton1Credit = new System.Windows.Forms.RadioButton();
            this.groupBoxMaximumStudent = new System.Windows.Forms.GroupBox();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.groupBoxDepartment = new System.Windows.Forms.GroupBox();
            this.radioButtonBBA = new System.Windows.Forms.RadioButton();
            this.radioButtonEEE = new System.Windows.Forms.RadioButton();
            this.radioButtonCSE = new System.Windows.Forms.RadioButton();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelUpdateCourse = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelAllCourses = new System.Windows.Forms.Label();
            this.courseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.groupBoxCourseType = new System.Windows.Forms.GroupBox();
            this.radioButtonLab = new System.Windows.Forms.RadioButton();
            this.radioButtonTheoryAndLab = new System.Windows.Forms.RadioButton();
            this.radioButtonTheory = new System.Windows.Forms.RadioButton();
            this.comboBoxSchedule = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.groupBoxCredit.SuspendLayout();
            this.groupBoxMaximumStudent.SuspendLayout();
            this.groupBoxDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseTableBindingSource)).BeginInit();
            this.groupBoxCourseType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInsertCourse
            // 
            this.labelInsertCourse.AutoSize = true;
            this.labelInsertCourse.Location = new System.Drawing.Point(12, 104);
            this.labelInsertCourse.Name = "labelInsertCourse";
            this.labelInsertCourse.Size = new System.Drawing.Size(105, 20);
            this.labelInsertCourse.TabIndex = 0;
            this.labelInsertCourse.Text = "Insert Course";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 141);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelSemesterName
            // 
            this.labelSemesterName.AutoSize = true;
            this.labelSemesterName.Location = new System.Drawing.Point(241, 141);
            this.labelSemesterName.Name = "labelSemesterName";
            this.labelSemesterName.Size = new System.Drawing.Size(78, 20);
            this.labelSemesterName.TabIndex = 2;
            this.labelSemesterName.Text = "Semester";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(438, 141);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(63, 20);
            this.labelSection.TabIndex = 3;
            this.labelSection.Text = "Section";
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Location = new System.Drawing.Point(183, 225);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(76, 20);
            this.labelSchedule.TabIndex = 4;
            this.labelSchedule.Text = "Schedule";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 177);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(212, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSection
            // 
            this.textBoxSection.Location = new System.Drawing.Point(442, 177);
            this.textBoxSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.Size = new System.Drawing.Size(140, 26);
            this.textBoxSection.TabIndex = 7;
            // 
            // groupBoxCredit
            // 
            this.groupBoxCredit.Controls.Add(this.radioButton3Credits);
            this.groupBoxCredit.Controls.Add(this.radioButton1Credit);
            this.groupBoxCredit.Location = new System.Drawing.Point(16, 346);
            this.groupBoxCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCredit.Name = "groupBoxCredit";
            this.groupBoxCredit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCredit.Size = new System.Drawing.Size(126, 89);
            this.groupBoxCredit.TabIndex = 13;
            this.groupBoxCredit.TabStop = false;
            this.groupBoxCredit.Text = "Credit";
            // 
            // radioButton3Credits
            // 
            this.radioButton3Credits.AutoSize = true;
            this.radioButton3Credits.Checked = true;
            this.radioButton3Credits.Location = new System.Drawing.Point(7, 61);
            this.radioButton3Credits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3Credits.Name = "radioButton3Credits";
            this.radioButton3Credits.Size = new System.Drawing.Size(97, 24);
            this.radioButton3Credits.TabIndex = 1;
            this.radioButton3Credits.TabStop = true;
            this.radioButton3Credits.Text = "3 Credits";
            this.radioButton3Credits.UseVisualStyleBackColor = true;
            // 
            // radioButton1Credit
            // 
            this.radioButton1Credit.AutoSize = true;
            this.radioButton1Credit.Location = new System.Drawing.Point(7, 26);
            this.radioButton1Credit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1Credit.Name = "radioButton1Credit";
            this.radioButton1Credit.Size = new System.Drawing.Size(89, 24);
            this.radioButton1Credit.TabIndex = 0;
            this.radioButton1Credit.Text = "1 Credit";
            this.radioButton1Credit.UseVisualStyleBackColor = true;
            // 
            // groupBoxMaximumStudent
            // 
            this.groupBoxMaximumStudent.Controls.Add(this.radioButton40);
            this.groupBoxMaximumStudent.Controls.Add(this.radioButton30);
            this.groupBoxMaximumStudent.Controls.Add(this.radioButton20);
            this.groupBoxMaximumStudent.Location = new System.Drawing.Point(150, 346);
            this.groupBoxMaximumStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMaximumStudent.Name = "groupBoxMaximumStudent";
            this.groupBoxMaximumStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMaximumStudent.Size = new System.Drawing.Size(161, 114);
            this.groupBoxMaximumStudent.TabIndex = 14;
            this.groupBoxMaximumStudent.TabStop = false;
            this.groupBoxMaximumStudent.Text = "Maximum Student";
            // 
            // radioButton40
            // 
            this.radioButton40.AutoSize = true;
            this.radioButton40.Checked = true;
            this.radioButton40.Location = new System.Drawing.Point(7, 81);
            this.radioButton40.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.Size = new System.Drawing.Size(52, 24);
            this.radioButton40.TabIndex = 2;
            this.radioButton40.TabStop = true;
            this.radioButton40.Text = "40";
            this.radioButton40.UseVisualStyleBackColor = true;
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.Location = new System.Drawing.Point(7, 54);
            this.radioButton30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(52, 24);
            this.radioButton30.TabIndex = 1;
            this.radioButton30.Text = "30";
            this.radioButton30.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(7, 28);
            this.radioButton20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(52, 24);
            this.radioButton20.TabIndex = 0;
            this.radioButton20.Text = "20";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // groupBoxDepartment
            // 
            this.groupBoxDepartment.Controls.Add(this.radioButtonBBA);
            this.groupBoxDepartment.Controls.Add(this.radioButtonEEE);
            this.groupBoxDepartment.Controls.Add(this.radioButtonCSE);
            this.groupBoxDepartment.Location = new System.Drawing.Point(442, 227);
            this.groupBoxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDepartment.Name = "groupBoxDepartment";
            this.groupBoxDepartment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDepartment.Size = new System.Drawing.Size(161, 114);
            this.groupBoxDepartment.TabIndex = 15;
            this.groupBoxDepartment.TabStop = false;
            this.groupBoxDepartment.Text = "Department";
            // 
            // radioButtonBBA
            // 
            this.radioButtonBBA.AutoSize = true;
            this.radioButtonBBA.Location = new System.Drawing.Point(7, 81);
            this.radioButtonBBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBBA.Name = "radioButtonBBA";
            this.radioButtonBBA.Size = new System.Drawing.Size(67, 24);
            this.radioButtonBBA.TabIndex = 2;
            this.radioButtonBBA.Text = "BBA";
            this.radioButtonBBA.UseVisualStyleBackColor = true;
            // 
            // radioButtonEEE
            // 
            this.radioButtonEEE.AutoSize = true;
            this.radioButtonEEE.Location = new System.Drawing.Point(7, 54);
            this.radioButtonEEE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonEEE.Name = "radioButtonEEE";
            this.radioButtonEEE.Size = new System.Drawing.Size(67, 24);
            this.radioButtonEEE.TabIndex = 1;
            this.radioButtonEEE.Text = "EEE";
            this.radioButtonEEE.UseVisualStyleBackColor = true;
            // 
            // radioButtonCSE
            // 
            this.radioButtonCSE.AutoSize = true;
            this.radioButtonCSE.Checked = true;
            this.radioButtonCSE.Location = new System.Drawing.Point(7, 28);
            this.radioButtonCSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCSE.Name = "radioButtonCSE";
            this.radioButtonCSE.Size = new System.Drawing.Size(67, 24);
            this.radioButtonCSE.TabIndex = 0;
            this.radioButtonCSE.TabStop = true;
            this.radioButtonCSE.Text = "CSE";
            this.radioButtonCSE.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(21, 467);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(163, 72);
            this.buttonInsert.TabIndex = 16;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.InsertClicked);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(245, 467);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(163, 72);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.UpdateClicked);
            // 
            // labelUpdateCourse
            // 
            this.labelUpdateCourse.AutoSize = true;
            this.labelUpdateCourse.Location = new System.Drawing.Point(19, 489);
            this.labelUpdateCourse.Name = "labelUpdateCourse";
            this.labelUpdateCourse.Size = new System.Drawing.Size(0, 20);
            this.labelUpdateCourse.TabIndex = 17;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(440, 467);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(163, 72);
            this.buttonDelete.TabIndex = 36;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteClicked);
            // 
            // labelAllCourses
            // 
            this.labelAllCourses.AutoSize = true;
            this.labelAllCourses.Location = new System.Drawing.Point(610, 104);
            this.labelAllCourses.Name = "labelAllCourses";
            this.labelAllCourses.Size = new System.Drawing.Size(89, 20);
            this.labelAllCourses.TabIndex = 37;
            this.labelAllCourses.Text = "All Courses";
            // 
            // courseTableBindingSource
            // 
            this.courseTableBindingSource.DataMember = "CourseTable";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1294, 11);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(122, 54);
            this.buttonLogOut.TabIndex = 40;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 54);
            this.buttonBack.TabIndex = 41;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackClicked);
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(245, 177);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(180, 28);
            this.comboBoxSemester.TabIndex = 42;
            // 
            // groupBoxCourseType
            // 
            this.groupBoxCourseType.Controls.Add(this.radioButtonLab);
            this.groupBoxCourseType.Controls.Add(this.radioButtonTheoryAndLab);
            this.groupBoxCourseType.Controls.Add(this.radioButtonTheory);
            this.groupBoxCourseType.Location = new System.Drawing.Point(16, 225);
            this.groupBoxCourseType.Name = "groupBoxCourseType";
            this.groupBoxCourseType.Size = new System.Drawing.Size(165, 116);
            this.groupBoxCourseType.TabIndex = 43;
            this.groupBoxCourseType.TabStop = false;
            this.groupBoxCourseType.Text = "Course Type";
            // 
            // radioButtonLab
            // 
            this.radioButtonLab.AutoSize = true;
            this.radioButtonLab.Location = new System.Drawing.Point(7, 86);
            this.radioButtonLab.Name = "radioButtonLab";
            this.radioButtonLab.Size = new System.Drawing.Size(61, 24);
            this.radioButtonLab.TabIndex = 2;
            this.radioButtonLab.TabStop = true;
            this.radioButtonLab.Text = "Lab";
            this.radioButtonLab.UseVisualStyleBackColor = true;
            this.radioButtonLab.CheckedChanged += new System.EventHandler(this.CourseTypeCheckedChanged);
            // 
            // radioButtonTheoryAndLab
            // 
            this.radioButtonTheoryAndLab.AutoSize = true;
            this.radioButtonTheoryAndLab.Location = new System.Drawing.Point(7, 56);
            this.radioButtonTheoryAndLab.Name = "radioButtonTheoryAndLab";
            this.radioButtonTheoryAndLab.Size = new System.Drawing.Size(146, 24);
            this.radioButtonTheoryAndLab.TabIndex = 1;
            this.radioButtonTheoryAndLab.TabStop = true;
            this.radioButtonTheoryAndLab.Text = "Theory And Lab";
            this.radioButtonTheoryAndLab.UseVisualStyleBackColor = true;
            this.radioButtonTheoryAndLab.CheckedChanged += new System.EventHandler(this.CourseTypeCheckedChanged);
            // 
            // radioButtonTheory
            // 
            this.radioButtonTheory.AutoSize = true;
            this.radioButtonTheory.Location = new System.Drawing.Point(7, 26);
            this.radioButtonTheory.Name = "radioButtonTheory";
            this.radioButtonTheory.Size = new System.Drawing.Size(82, 24);
            this.radioButtonTheory.TabIndex = 0;
            this.radioButtonTheory.Text = "Theory";
            this.radioButtonTheory.UseVisualStyleBackColor = true;
            this.radioButtonTheory.CheckedChanged += new System.EventHandler(this.CourseTypeCheckedChanged);
            // 
            // comboBoxSchedule
            // 
            this.comboBoxSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSchedule.DropDownWidth = 300;
            this.comboBoxSchedule.FormattingEnabled = true;
            this.comboBoxSchedule.Location = new System.Drawing.Point(187, 261);
            this.comboBoxSchedule.Name = "comboBoxSchedule";
            this.comboBoxSchedule.Size = new System.Drawing.Size(227, 28);
            this.comboBoxSchedule.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Course Id";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(332, 382);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 20);
            this.labelId.TabIndex = 46;
            this.labelId.Text = "Id";
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.AllowUserToAddRows = false;
            this.dataGridViewCourse.AllowUserToDeleteRows = false;
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Location = new System.Drawing.Point(614, 141);
            this.dataGridViewCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.ReadOnly = true;
            this.dataGridViewCourse.RowTemplate.Height = 28;
            this.dataGridViewCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCourse.Size = new System.Drawing.Size(797, 398);
            this.dataGridViewCourse.TabIndex = 38;
            this.dataGridViewCourse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourseCellDoubleClicked);
            // 
            // EditCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1428, 544);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSchedule);
            this.Controls.Add(this.groupBoxCourseType);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.labelAllCourses);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelUpdateCourse);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.groupBoxDepartment);
            this.Controls.Add(this.groupBoxMaximumStudent);
            this.Controls.Add(this.groupBoxCredit);
            this.Controls.Add(this.textBoxSection);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.labelSemesterName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelInsertCourse);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditCourseInfo";
            this.Text = "Course Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.groupBoxCredit.ResumeLayout(false);
            this.groupBoxCredit.PerformLayout();
            this.groupBoxMaximumStudent.ResumeLayout(false);
            this.groupBoxMaximumStudent.PerformLayout();
            this.groupBoxDepartment.ResumeLayout(false);
            this.groupBoxDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseTableBindingSource)).EndInit();
            this.groupBoxCourseType.ResumeLayout(false);
            this.groupBoxCourseType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInsertCourse;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSemesterName;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSection;
        private System.Windows.Forms.GroupBox groupBoxCredit;
        private System.Windows.Forms.RadioButton radioButton3Credits;
        private System.Windows.Forms.RadioButton radioButton1Credit;
        private System.Windows.Forms.GroupBox groupBoxMaximumStudent;
        private System.Windows.Forms.RadioButton radioButton40;
        private System.Windows.Forms.RadioButton radioButton30;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.GroupBox groupBoxDepartment;
        private System.Windows.Forms.RadioButton radioButtonBBA;
        private System.Windows.Forms.RadioButton radioButtonEEE;
        private System.Windows.Forms.RadioButton radioButtonCSE;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelUpdateCourse;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelAllCourses;
        //private UMSDatabaseDataSet uMSDatabaseDataSet;
        private System.Windows.Forms.BindingSource courseTableBindingSource;
        //private UMSDatabaseDataSetTableAdapters.CourseTableTableAdapter courseTableTableAdapter;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.GroupBox groupBoxCourseType;
        private System.Windows.Forms.RadioButton radioButtonLab;
        private System.Windows.Forms.RadioButton radioButtonTheoryAndLab;
        private System.Windows.Forms.RadioButton radioButtonTheory;
        private System.Windows.Forms.ComboBox comboBoxSchedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
    }
}