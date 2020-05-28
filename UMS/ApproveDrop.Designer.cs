namespace UMS
{
    partial class ApproveDrop
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSelectStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.buttonApproveDrop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(16, 15);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(728, 44);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(195, 28);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(724, 11);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(46, 17);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Course : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Student :";
            // 
            // comboBoxSelectStudent
            // 
            this.comboBoxSelectStudent.FormattingEnabled = true;
            this.comboBoxSelectStudent.Location = new System.Drawing.Point(372, 229);
            this.comboBoxSelectStudent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSelectStudent.Name = "comboBoxSelectStudent";
            this.comboBoxSelectStudent.Size = new System.Drawing.Size(321, 24);
            this.comboBoxSelectStudent.TabIndex = 6;
            this.comboBoxSelectStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectStudent_SelectedIndexChanged);
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(372, 160);
            this.comboBoxSelectCourse.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(321, 24);
            this.comboBoxSelectCourse.TabIndex = 7;
            this.comboBoxSelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCourse_SelectedIndexChanged);
            // 
            // buttonApproveDrop
            // 
            this.buttonApproveDrop.Location = new System.Drawing.Point(263, 321);
            this.buttonApproveDrop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApproveDrop.Name = "buttonApproveDrop";
            this.buttonApproveDrop.Size = new System.Drawing.Size(432, 28);
            this.buttonApproveDrop.TabIndex = 8;
            this.buttonApproveDrop.Text = "Approve Drop";
            this.buttonApproveDrop.UseVisualStyleBackColor = true;
            this.buttonApproveDrop.Click += new System.EventHandler(this.buttonApproveDrop_Click);
            // 
            // ApproveDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 543);
            this.Controls.Add(this.buttonApproveDrop);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.comboBoxSelectStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApproveDrop";
            this.Text = "ApproveDrop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelectStudent;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.Button buttonApproveDrop;
    }
}