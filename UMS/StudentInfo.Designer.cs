namespace UMS
{
    partial class StudentInfo
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
            this.dataGridViewStudentInfo = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonShowAllStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentInfo
            // 
            this.dataGridViewStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentInfo.Location = new System.Drawing.Point(12, 99);
            this.dataGridViewStudentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewStudentInfo.Name = "dataGridViewStudentInfo";
            this.dataGridViewStudentInfo.ReadOnly = true;
            this.dataGridViewStudentInfo.RowTemplate.Height = 28;
            this.dataGridViewStudentInfo.Size = new System.Drawing.Size(1054, 399);
            this.dataGridViewStudentInfo.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(587, 507);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(319, 26);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(925, 502);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(141, 31);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.SearchButtonClicked);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(944, 11);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(122, 54);
            this.buttonLogOut.TabIndex = 5;
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
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackClicked);
            // 
            // buttonShowAllStudents
            // 
            this.buttonShowAllStudents.Location = new System.Drawing.Point(12, 502);
            this.buttonShowAllStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAllStudents.Name = "buttonShowAllStudents";
            this.buttonShowAllStudents.Size = new System.Drawing.Size(141, 31);
            this.buttonShowAllStudents.TabIndex = 15;
            this.buttonShowAllStudents.Text = "Show All";
            this.buttonShowAllStudents.UseVisualStyleBackColor = true;
            this.buttonShowAllStudents.Click += new System.EventHandler(this.ShowAllClicked);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.buttonShowAllStudents);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewStudentInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentInfo";
            this.Text = "Student Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentInfo;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonShowAllStudents;
    }
}