namespace UMS
{
    partial class CourseInfo
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
            this.CourseInfoGridView = new System.Windows.Forms.DataGridView();
            this.courseRegistrationTableDataSet = new UMS.CourseRegistrationTableDataSet();
            this.courseRegTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseRegTableTableAdapter = new UMS.CourseRegistrationTableDataSetTableAdapters.CourseRegTableTableAdapter();
            this.SemesterComboBox = new System.Windows.Forms.ComboBox();
            this.SelectSemesterLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BackLabel = new System.Windows.Forms.Label();
            this.LogOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CourseInfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegistrationTableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseInfoGridView
            // 
            this.CourseInfoGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CourseInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseInfoGridView.Location = new System.Drawing.Point(257, 117);
            this.CourseInfoGridView.Name = "CourseInfoGridView";
            this.CourseInfoGridView.RowTemplate.Height = 24;
            this.CourseInfoGridView.Size = new System.Drawing.Size(569, 328);
            this.CourseInfoGridView.TabIndex = 0;
            // 
            // courseRegistrationTableDataSet
            // 
            this.courseRegistrationTableDataSet.DataSetName = "CourseRegistrationTableDataSet";
            this.courseRegistrationTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseRegTableBindingSource
            // 
            this.courseRegTableBindingSource.DataMember = "CourseRegTable";
            this.courseRegTableBindingSource.DataSource = this.courseRegistrationTableDataSet;
            // 
            // courseRegTableTableAdapter
            // 
            this.courseRegTableTableAdapter.ClearBeforeFill = true;
            // 
            // SemesterComboBox
            // 
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Location = new System.Drawing.Point(12, 166);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(157, 24);
            this.SemesterComboBox.TabIndex = 1;
            this.SemesterComboBox.Text = "Semester";
            this.SemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.SemesterComboBox_SelectedIndexChanged);
            // 
            // SelectSemesterLabel
            // 
            this.SelectSemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSemesterLabel.Location = new System.Drawing.Point(9, 117);
            this.SelectSemesterLabel.Name = "SelectSemesterLabel";
            this.SelectSemesterLabel.Size = new System.Drawing.Size(171, 46);
            this.SelectSemesterLabel.TabIndex = 2;
            this.SelectSemesterLabel.Text = "Select Semester: ";
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(604, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(251, 32);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BackLabel
            // 
            this.BackLabel.Location = new System.Drawing.Point(9, 9);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(67, 23);
            this.BackLabel.TabIndex = 5;
            this.BackLabel.Text = "Back";
            this.BackLabel.Click += new System.EventHandler(this.BackClicked);
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.Location = new System.Drawing.Point(67, 9);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(100, 23);
            this.LogOutLabel.TabIndex = 6;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 606);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SelectSemesterLabel);
            this.Controls.Add(this.SemesterComboBox);
            this.Controls.Add(this.CourseInfoGridView);
            this.Name = "CourseInfo";
            this.Text = "CourseInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.CourseInfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegistrationTableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CourseInfoGridView;
        private CourseRegistrationTableDataSet courseRegistrationTableDataSet;
        private System.Windows.Forms.BindingSource courseRegTableBindingSource;
        private CourseRegistrationTableDataSetTableAdapters.CourseRegTableTableAdapter courseRegTableTableAdapter;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.Label SelectSemesterLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.Label LogOutLabel;

    }
}