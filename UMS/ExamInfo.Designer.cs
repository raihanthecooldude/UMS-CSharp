namespace UMS
{
    partial class ExamInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxDay = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxSlot = new System.Windows.Forms.GroupBox();
            this.radioButtonSlot4 = new System.Windows.Forms.RadioButton();
            this.radioButtonSlot3 = new System.Windows.Forms.RadioButton();
            this.radioButtonSlot2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSlot1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFacultyId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewExam = new System.Windows.Forms.DataGridView();
            this.examTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxSemesterName = new System.Windows.Forms.ComboBox();
            this.comboBoxCourseId = new System.Windows.Forms.ComboBox();
            this.courseRegistrationTableDataSet = new UMS.CourseRegistrationTableDataSet();
            this.courseRegistrationTableDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxDay.SuspendLayout();
            this.groupBoxSlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegistrationTableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegistrationTableDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add/Update Exam Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Semester Name";
            // 
            // groupBoxDay
            // 
            this.groupBoxDay.Controls.Add(this.radioButton4);
            this.groupBoxDay.Controls.Add(this.radioButton3);
            this.groupBoxDay.Controls.Add(this.radioButton6);
            this.groupBoxDay.Controls.Add(this.radioButton5);
            this.groupBoxDay.Controls.Add(this.radioButton2);
            this.groupBoxDay.Controls.Add(this.radioButton1);
            this.groupBoxDay.Location = new System.Drawing.Point(16, 324);
            this.groupBoxDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDay.Name = "groupBoxDay";
            this.groupBoxDay.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDay.Size = new System.Drawing.Size(112, 206);
            this.groupBoxDay.TabIndex = 5;
            this.groupBoxDay.TabStop = false;
            this.groupBoxDay.Text = "Day";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 116);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Four";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 86);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Three";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 176);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Six";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 146);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(63, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Five";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 56);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Two";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 26);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "One";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSlot
            // 
            this.groupBoxSlot.Controls.Add(this.radioButtonSlot4);
            this.groupBoxSlot.Controls.Add(this.radioButtonSlot3);
            this.groupBoxSlot.Controls.Add(this.radioButtonSlot2);
            this.groupBoxSlot.Controls.Add(this.radioButtonSlot1);
            this.groupBoxSlot.Location = new System.Drawing.Point(161, 324);
            this.groupBoxSlot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSlot.Name = "groupBoxSlot";
            this.groupBoxSlot.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSlot.Size = new System.Drawing.Size(112, 140);
            this.groupBoxSlot.TabIndex = 6;
            this.groupBoxSlot.TabStop = false;
            this.groupBoxSlot.Text = "Slot";
            // 
            // radioButtonSlot4
            // 
            this.radioButtonSlot4.AutoSize = true;
            this.radioButtonSlot4.Location = new System.Drawing.Point(7, 116);
            this.radioButtonSlot4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSlot4.Name = "radioButtonSlot4";
            this.radioButtonSlot4.Size = new System.Drawing.Size(67, 24);
            this.radioButtonSlot4.TabIndex = 3;
            this.radioButtonSlot4.TabStop = true;
            this.radioButtonSlot4.Text = "Four";
            this.radioButtonSlot4.UseVisualStyleBackColor = true;
            // 
            // radioButtonSlot3
            // 
            this.radioButtonSlot3.AutoSize = true;
            this.radioButtonSlot3.Location = new System.Drawing.Point(7, 86);
            this.radioButtonSlot3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSlot3.Name = "radioButtonSlot3";
            this.radioButtonSlot3.Size = new System.Drawing.Size(75, 24);
            this.radioButtonSlot3.TabIndex = 2;
            this.radioButtonSlot3.TabStop = true;
            this.radioButtonSlot3.Text = "Three";
            this.radioButtonSlot3.UseVisualStyleBackColor = true;
            // 
            // radioButtonSlot2
            // 
            this.radioButtonSlot2.AutoSize = true;
            this.radioButtonSlot2.Location = new System.Drawing.Point(6, 56);
            this.radioButtonSlot2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSlot2.Name = "radioButtonSlot2";
            this.radioButtonSlot2.Size = new System.Drawing.Size(63, 24);
            this.radioButtonSlot2.TabIndex = 1;
            this.radioButtonSlot2.TabStop = true;
            this.radioButtonSlot2.Text = "Two";
            this.radioButtonSlot2.UseVisualStyleBackColor = true;
            // 
            // radioButtonSlot1
            // 
            this.radioButtonSlot1.AutoSize = true;
            this.radioButtonSlot1.Checked = true;
            this.radioButtonSlot1.Location = new System.Drawing.Point(7, 26);
            this.radioButtonSlot1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSlot1.Name = "radioButtonSlot1";
            this.radioButtonSlot1.Size = new System.Drawing.Size(64, 24);
            this.radioButtonSlot1.TabIndex = 0;
            this.radioButtonSlot1.TabStop = true;
            this.radioButtonSlot1.Text = "One";
            this.radioButtonSlot1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assigned Faculty Id";
            // 
            // comboBoxFacultyId
            // 
            this.comboBoxFacultyId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultyId.FormattingEnabled = true;
            this.comboBoxFacultyId.Location = new System.Drawing.Point(304, 350);
            this.comboBoxFacultyId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFacultyId.Name = "comboBoxFacultyId";
            this.comboBoxFacultyId.Size = new System.Drawing.Size(180, 28);
            this.comboBoxFacultyId.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Room";
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(383, 185);
            this.textBoxRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(124, 26);
            this.textBoxRoom.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(23, 564);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 54);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddClicked);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(194, 564);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(108, 54);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.UpdateClicked);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(357, 564);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 54);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteClicked);
            // 
            // dataGridViewExam
            // 
            this.dataGridViewExam.AllowUserToAddRows = false;
            this.dataGridViewExam.AllowUserToDeleteRows = false;
            this.dataGridViewExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExam.Location = new System.Drawing.Point(521, 164);
            this.dataGridViewExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewExam.Name = "dataGridViewExam";
            this.dataGridViewExam.ReadOnly = true;
            this.dataGridViewExam.RowTemplate.Height = 28;
            this.dataGridViewExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExam.Size = new System.Drawing.Size(526, 454);
            this.dataGridViewExam.TabIndex = 17;
            this.dataGridViewExam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExamCellDoubleClicked);
            // 
            // examTableBindingSource1
            // 
            this.examTableBindingSource1.DataMember = "ExamTable";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(939, 84);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 54);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.RefreshClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "All Exam Informations";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(925, 11);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(122, 54);
            this.buttonLogOut.TabIndex = 20;
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
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackClicked);
            // 
            // comboBoxSemesterName
            // 
            this.comboBoxSemesterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemesterName.FormattingEnabled = true;
            this.comboBoxSemesterName.Location = new System.Drawing.Point(12, 185);
            this.comboBoxSemesterName.Name = "comboBoxSemesterName";
            this.comboBoxSemesterName.Size = new System.Drawing.Size(173, 28);
            this.comboBoxSemesterName.TabIndex = 22;
            this.comboBoxSemesterName.SelectedIndexChanged += new System.EventHandler(this.SemesterSelected);
            // 
            // comboBoxCourseId
            // 
            this.comboBoxCourseId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourseId.DropDownWidth = 300;
            this.comboBoxCourseId.FormattingEnabled = true;
            this.comboBoxCourseId.Location = new System.Drawing.Point(202, 185);
            this.comboBoxCourseId.Name = "comboBoxCourseId";
            this.comboBoxCourseId.Size = new System.Drawing.Size(162, 28);
            this.comboBoxCourseId.TabIndex = 23;
            // 
            // courseRegistrationTableDataSet
            // 
            this.courseRegistrationTableDataSet.DataSetName = "CourseRegistrationTableDataSet";
            this.courseRegistrationTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseRegistrationTableDataSetBindingSource
            // 
            this.courseRegistrationTableDataSetBindingSource.DataSource = this.courseRegistrationTableDataSet;
            this.courseRegistrationTableDataSetBindingSource.Position = 0;
            // 
            // ExamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1078, 512);
            this.Controls.Add(this.comboBoxCourseId);
            this.Controls.Add(this.comboBoxSemesterName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewExam);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFacultyId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxSlot);
            this.Controls.Add(this.groupBoxDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExamInfo";
            this.Text = "ExamInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.groupBoxDay.ResumeLayout(false);
            this.groupBoxDay.PerformLayout();
            this.groupBoxSlot.ResumeLayout(false);
            this.groupBoxSlot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegistrationTableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegistrationTableDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxDay;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxSlot;
        private System.Windows.Forms.RadioButton radioButtonSlot4;
        private System.Windows.Forms.RadioButton radioButtonSlot3;
        private System.Windows.Forms.RadioButton radioButtonSlot2;
        private System.Windows.Forms.RadioButton radioButtonSlot1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFacultyId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewExam;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource examTableBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn semesterNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn slotDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn assignedFacultyIdDataGridViewTextBoxColumn;
        //private ExamTableDataSet examTableDataSet;
        private System.Windows.Forms.BindingSource examTableBindingSource1;
        //private ExamTableDataSetTableAdapters.ExamTableTableAdapter examTableTableAdapter;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxSemesterName;
        private System.Windows.Forms.ComboBox comboBoxCourseId;
        private CourseRegistrationTableDataSet courseRegistrationTableDataSet;
        private System.Windows.Forms.BindingSource courseRegistrationTableDataSetBindingSource;
    }
}