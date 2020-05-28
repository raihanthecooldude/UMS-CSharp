namespace UMS
{
    partial class OfferedCourses
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
            this.OfferedCoursesGridView = new System.Windows.Forms.DataGridView();
            this.OfferedCoursesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OfferedCoursesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(605, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(251, 32);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.Location = new System.Drawing.Point(64, 9);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(100, 23);
            this.LogOutLabel.TabIndex = 11;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // BackLabel
            // 
            this.BackLabel.Location = new System.Drawing.Point(6, 9);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(67, 23);
            this.BackLabel.TabIndex = 10;
            this.BackLabel.Text = "Back";
            this.BackLabel.Click += new System.EventHandler(this.BackClicked);
            // 
            // SemesterComboBox
            // 
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Location = new System.Drawing.Point(175, 56);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(157, 24);
            this.SemesterComboBox.TabIndex = 13;
            this.SemesterComboBox.Text = "Semester";
            this.SemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.SemesterComboBox_SelectedIndexChanged);
            // 
            // SelectSemesterLabel
            // 
            this.SelectSemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSemesterLabel.Location = new System.Drawing.Point(5, 56);
            this.SelectSemesterLabel.Name = "SelectSemesterLabel";
            this.SelectSemesterLabel.Size = new System.Drawing.Size(177, 46);
            this.SelectSemesterLabel.TabIndex = 14;
            this.SelectSemesterLabel.Text = "Select Semester: ";
            // 
            // OfferedCoursesGridView
            // 
            this.OfferedCoursesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OfferedCoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfferedCoursesGridView.Location = new System.Drawing.Point(9, 165);
            this.OfferedCoursesGridView.Name = "OfferedCoursesGridView";
            this.OfferedCoursesGridView.RowTemplate.Height = 24;
            this.OfferedCoursesGridView.Size = new System.Drawing.Size(839, 338);
            this.OfferedCoursesGridView.TabIndex = 15;
            // 
            // OfferedCoursesLabel
            // 
            this.OfferedCoursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfferedCoursesLabel.Location = new System.Drawing.Point(5, 116);
            this.OfferedCoursesLabel.Name = "OfferedCoursesLabel";
            this.OfferedCoursesLabel.Size = new System.Drawing.Size(356, 46);
            this.OfferedCoursesLabel.TabIndex = 16;
            this.OfferedCoursesLabel.Text = "This Semester\'s Offered Courses: ";
            // 
            // OfferedCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 626);
            this.Controls.Add(this.OfferedCoursesLabel);
            this.Controls.Add(this.OfferedCoursesGridView);
            this.Controls.Add(this.SemesterComboBox);
            this.Controls.Add(this.SelectSemesterLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.BackLabel);
            this.Name = "OfferedCourses";
            this.Text = "OfferedCourses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.OfferedCoursesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.Label SelectSemesterLabel;
        private System.Windows.Forms.DataGridView OfferedCoursesGridView;
        private System.Windows.Forms.Label OfferedCoursesLabel;
    }
}