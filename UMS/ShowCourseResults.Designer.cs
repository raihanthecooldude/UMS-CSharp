namespace UMS
{
    partial class ShowCourseResults
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
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.BackLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ResultGridView = new System.Windows.Forms.DataGridView();
            this.SelectSemesterLabel = new System.Windows.Forms.Label();
            this.SemesterComboBox = new System.Windows.Forms.ComboBox();
            this.GPALabel = new System.Windows.Forms.Label();
            this.CGPALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.Location = new System.Drawing.Point(63, 9);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(100, 23);
            this.LogOutLabel.TabIndex = 8;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // BackLabel
            // 
            this.BackLabel.Location = new System.Drawing.Point(5, 9);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(67, 23);
            this.BackLabel.TabIndex = 7;
            this.BackLabel.Text = "Back";
            this.BackLabel.Click += new System.EventHandler(this.BackClicked);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(604, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(251, 32);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ResultGridView
            // 
            this.ResultGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGridView.Location = new System.Drawing.Point(16, 151);
            this.ResultGridView.Name = "ResultGridView";
            this.ResultGridView.RowTemplate.Height = 24;
            this.ResultGridView.Size = new System.Drawing.Size(839, 178);
            this.ResultGridView.TabIndex = 10;
            // 
            // SelectSemesterLabel
            // 
            this.SelectSemesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSemesterLabel.Location = new System.Drawing.Point(12, 61);
            this.SelectSemesterLabel.Name = "SelectSemesterLabel";
            this.SelectSemesterLabel.Size = new System.Drawing.Size(177, 46);
            this.SelectSemesterLabel.TabIndex = 12;
            this.SelectSemesterLabel.Text = "Select Semester: ";
            // 
            // SemesterComboBox
            // 
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Location = new System.Drawing.Point(182, 61);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(157, 24);
            this.SemesterComboBox.TabIndex = 11;
            this.SemesterComboBox.Text = "Semester";
            this.SemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.SemesterComboBox_SelectedIndexChanged);
            // 
            // GPALabel
            // 
            this.GPALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPALabel.Location = new System.Drawing.Point(12, 362);
            this.GPALabel.Name = "GPALabel";
            this.GPALabel.Size = new System.Drawing.Size(569, 45);
            this.GPALabel.TabIndex = 13;
            this.GPALabel.Text = "This Semester\'s GPA: ";
            // 
            // CGPALabel
            // 
            this.CGPALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CGPALabel.Location = new System.Drawing.Point(16, 435);
            this.CGPALabel.Name = "CGPALabel";
            this.CGPALabel.Size = new System.Drawing.Size(839, 45);
            this.CGPALabel.TabIndex = 14;
            this.CGPALabel.Text = "Total CGPA: ";
            // 
            // ShowCourseResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 606);
            this.Controls.Add(this.SemesterComboBox);
            this.Controls.Add(this.CGPALabel);
            this.Controls.Add(this.GPALabel);
            this.Controls.Add(this.SelectSemesterLabel);
            this.Controls.Add(this.ResultGridView);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.BackLabel);
            this.Name = "ShowCourseResults";
            this.Text = "GradeResult";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.ResultGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView ResultGridView;
        private System.Windows.Forms.Label SelectSemesterLabel;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.Label GPALabel;
        private System.Windows.Forms.Label CGPALabel;
    }
}