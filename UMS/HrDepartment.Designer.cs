namespace UMS
{
    partial class HrDepartment
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
            this.createemployeebutton = new System.Windows.Forms.Button();
            this.updateteacherbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createemployeebutton
            // 
            this.createemployeebutton.Location = new System.Drawing.Point(105, 106);
            this.createemployeebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createemployeebutton.Name = "createemployeebutton";
            this.createemployeebutton.Size = new System.Drawing.Size(309, 84);
            this.createemployeebutton.TabIndex = 0;
            this.createemployeebutton.Text = "Create Emplyee";
            this.createemployeebutton.UseVisualStyleBackColor = true;
            this.createemployeebutton.Click += new System.EventHandler(this.createemployeebutton_Click);
            // 
            // updateteacherbutton
            // 
            this.updateteacherbutton.Location = new System.Drawing.Point(105, 233);
            this.updateteacherbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateteacherbutton.Name = "updateteacherbutton";
            this.updateteacherbutton.Size = new System.Drawing.Size(309, 84);
            this.updateteacherbutton.TabIndex = 1;
            this.updateteacherbutton.Text = "Update Teacher Info";
            this.updateteacherbutton.UseVisualStyleBackColor = true;
            this.updateteacherbutton.Click += new System.EventHandler(this.updateteacherbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(453, 26);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(97, 28);
            this.exitbutton.TabIndex = 9;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(368, 26);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(97, 28);
            this.logoutbutton.TabIndex = 8;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(284, 26);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(97, 28);
            this.backbutton.TabIndex = 7;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // HrDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 395);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.updateteacherbutton);
            this.Controls.Add(this.createemployeebutton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HrDepartment";
            this.Text = "HrDepartment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createemployeebutton;
        private System.Windows.Forms.Button updateteacherbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button backbutton;
    }
}