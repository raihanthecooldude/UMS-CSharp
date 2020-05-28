namespace UMS
{
    partial class AdmissionDeptHome
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
            this.CreateStudentAccountbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.genaratepdfbutton = new System.Windows.Forms.Button();
            this.courselectionbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateStudentAccountbutton
            // 
            this.CreateStudentAccountbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateStudentAccountbutton.Location = new System.Drawing.Point(56, 69);
            this.CreateStudentAccountbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateStudentAccountbutton.Name = "CreateStudentAccountbutton";
            this.CreateStudentAccountbutton.Size = new System.Drawing.Size(324, 65);
            this.CreateStudentAccountbutton.TabIndex = 0;
            this.CreateStudentAccountbutton.Text = "Create Student Account";
            this.CreateStudentAccountbutton.UseVisualStyleBackColor = true;
            this.CreateStudentAccountbutton.Click += new System.EventHandler(this.CreateStudentAccountbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(365, 15);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(100, 28);
            this.exitbutton.TabIndex = 6;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(280, 15);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(100, 28);
            this.logoutbutton.TabIndex = 5;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(196, 15);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(100, 28);
            this.backbutton.TabIndex = 4;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // genaratepdfbutton
            // 
            this.genaratepdfbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genaratepdfbutton.Location = new System.Drawing.Point(56, 156);
            this.genaratepdfbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genaratepdfbutton.Name = "genaratepdfbutton";
            this.genaratepdfbutton.Size = new System.Drawing.Size(324, 65);
            this.genaratepdfbutton.TabIndex = 7;
            this.genaratepdfbutton.Text = "Genarate  Pdf";
            this.genaratepdfbutton.UseVisualStyleBackColor = true;
            this.genaratepdfbutton.Click += new System.EventHandler(this.genaratepdfbutton_Click);
            // 
            // courselectionbutton
            // 
            this.courselectionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courselectionbutton.Location = new System.Drawing.Point(56, 250);
            this.courselectionbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courselectionbutton.Name = "courselectionbutton";
            this.courselectionbutton.Size = new System.Drawing.Size(324, 65);
            this.courselectionbutton.TabIndex = 8;
            this.courselectionbutton.Text = "Course Selection";
            this.courselectionbutton.UseVisualStyleBackColor = true;
            this.courselectionbutton.Click += new System.EventHandler(this.courselectionbutton_Click);
            // 
            // AdmissionDeptHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 375);
            this.Controls.Add(this.courselectionbutton);
            this.Controls.Add(this.genaratepdfbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.CreateStudentAccountbutton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdmissionDeptHome";
            this.Text = "AdmissionDeptHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.Load += new System.EventHandler(this.AdmissionDeptHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateStudentAccountbutton;
       
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button genaratepdfbutton;
        private System.Windows.Forms.Button courselectionbutton;
    }
}