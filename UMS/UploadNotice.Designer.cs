namespace UMS
{
    partial class UploadNotice
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
            this.labelSelectSemester = new System.Windows.Forms.Label();
            this.comboBoxSelectSemester = new System.Windows.Forms.ComboBox();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.textBoxNotice = new System.Windows.Forms.TextBox();
            this.buttonUploadNotice = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(743, 27);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(46, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "label1";
            // 
            // labelSelectSemester
            // 
            this.labelSelectSemester.AutoSize = true;
            this.labelSelectSemester.Location = new System.Drawing.Point(299, 130);
            this.labelSelectSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectSemester.Name = "labelSelectSemester";
            this.labelSelectSemester.Size = new System.Drawing.Size(119, 17);
            this.labelSelectSemester.TabIndex = 1;
            this.labelSelectSemester.Text = "Select Semester :";
            // 
            // comboBoxSelectSemester
            // 
            this.comboBoxSelectSemester.FormattingEnabled = true;
            this.comboBoxSelectSemester.Location = new System.Drawing.Point(459, 127);
            this.comboBoxSelectSemester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectSemester.Name = "comboBoxSelectSemester";
            this.comboBoxSelectSemester.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSelectSemester.TabIndex = 2;
            this.comboBoxSelectSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectSemester_SelectedIndexChanged);
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Location = new System.Drawing.Point(305, 192);
            this.labelSelectCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(108, 17);
            this.labelSelectCourse.TabIndex = 3;
            this.labelSelectCourse.Text = "Select Course : ";
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(459, 182);
            this.comboBoxSelectCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSelectCourse.TabIndex = 4;
            this.comboBoxSelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCourse_SelectedIndexChanged);
            // 
            // textBoxNotice
            // 
            this.textBoxNotice.Location = new System.Drawing.Point(219, 279);
            this.textBoxNotice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNotice.Multiline = true;
            this.textBoxNotice.Name = "textBoxNotice";
            this.textBoxNotice.Size = new System.Drawing.Size(540, 152);
            this.textBoxNotice.TabIndex = 5;
            // 
            // buttonUploadNotice
            // 
            this.buttonUploadNotice.Location = new System.Drawing.Point(791, 342);
            this.buttonUploadNotice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUploadNotice.Name = "buttonUploadNotice";
            this.buttonUploadNotice.Size = new System.Drawing.Size(100, 28);
            this.buttonUploadNotice.TabIndex = 6;
            this.buttonUploadNotice.Text = "Upload Notice";
            this.buttonUploadNotice.UseVisualStyleBackColor = true;
            this.buttonUploadNotice.Click += new System.EventHandler(this.buttonUploadNotice_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(747, 52);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(176, 28);
            this.buttonLogOut.TabIndex = 7;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(33, 15);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // UploadNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonUploadNotice);
            this.Controls.Add(this.textBoxNotice);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.comboBoxSelectSemester);
            this.Controls.Add(this.labelSelectSemester);
            this.Controls.Add(this.labelUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UploadNotice";
            this.Text = "Upload";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelSelectSemester;
        private System.Windows.Forms.ComboBox comboBoxSelectSemester;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.TextBox textBoxNotice;
        private System.Windows.Forms.Button buttonUploadNotice;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
    }
}