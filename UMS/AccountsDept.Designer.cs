namespace UMS
{
    partial class AccountsDept
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
            this.buttonManageTeacherSalary = new System.Windows.Forms.Button();
            this.buttonHandleScholarship = new System.Windows.Forms.Button();
            this.buttonValidPayment = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageTeacherSalary
            // 
            this.buttonManageTeacherSalary.Location = new System.Drawing.Point(147, 126);
            this.buttonManageTeacherSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManageTeacherSalary.Name = "buttonManageTeacherSalary";
            this.buttonManageTeacherSalary.Size = new System.Drawing.Size(153, 52);
            this.buttonManageTeacherSalary.TabIndex = 0;
            this.buttonManageTeacherSalary.Text = "Manage Teacher Salary";
            this.buttonManageTeacherSalary.UseVisualStyleBackColor = true;
            this.buttonManageTeacherSalary.Click += new System.EventHandler(this.ManageTeacherSalaryClicked);
            // 
            // buttonHandleScholarship
            // 
            this.buttonHandleScholarship.Location = new System.Drawing.Point(147, 216);
            this.buttonHandleScholarship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHandleScholarship.Name = "buttonHandleScholarship";
            this.buttonHandleScholarship.Size = new System.Drawing.Size(153, 52);
            this.buttonHandleScholarship.TabIndex = 1;
            this.buttonHandleScholarship.Text = "Handle Scholarship";
            this.buttonHandleScholarship.UseVisualStyleBackColor = true;
            this.buttonHandleScholarship.Click += new System.EventHandler(this.HandleScholarshipClicked);
            // 
            // buttonValidPayment
            // 
            this.buttonValidPayment.Location = new System.Drawing.Point(147, 303);
            this.buttonValidPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonValidPayment.Name = "buttonValidPayment";
            this.buttonValidPayment.Size = new System.Drawing.Size(153, 52);
            this.buttonValidPayment.TabIndex = 2;
            this.buttonValidPayment.Text = "Valid Payment";
            this.buttonValidPayment.UseVisualStyleBackColor = true;
            this.buttonValidPayment.Click += new System.EventHandler(this.ValidPayment);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(353, 10);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(108, 43);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // AccountsDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 423);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonValidPayment);
            this.Controls.Add(this.buttonHandleScholarship);
            this.Controls.Add(this.buttonManageTeacherSalary);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountsDept";
            this.Text = "AccountsDept";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageTeacherSalary;
        private System.Windows.Forms.Button buttonHandleScholarship;
        private System.Windows.Forms.Button buttonValidPayment;
        private System.Windows.Forms.Button buttonLogOut;
    }
}