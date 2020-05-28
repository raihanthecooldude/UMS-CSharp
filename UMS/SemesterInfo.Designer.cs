namespace UMS
{
    partial class SemesterInfo
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
            this.labelAddSemester = new System.Windows.Forms.Label();
            this.labelRemoveSemester = new System.Windows.Forms.Label();
            this.labelUpdateSemesterName = new System.Windows.Forms.Label();
            this.labelAllSemesters = new System.Windows.Forms.Label();
            this.labelSemesterName = new System.Windows.Forms.Label();
            this.textBoxSemesterName = new System.Windows.Forms.TextBox();
            this.buttonAddSemester = new System.Windows.Forms.Button();
            this.labelSemesterId = new System.Windows.Forms.Label();
            this.textBoxSemesterId = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxSemesterId2 = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNewSemesterName = new System.Windows.Forms.Label();
            this.textBoxNewSemesterName = new System.Windows.Forms.TextBox();
            this.dataGridViewSemesters = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxSemesterId3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemesters)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddSemester
            // 
            this.labelAddSemester.AutoSize = true;
            this.labelAddSemester.Location = new System.Drawing.Point(12, 108);
            this.labelAddSemester.Name = "labelAddSemester";
            this.labelAddSemester.Size = new System.Drawing.Size(146, 20);
            this.labelAddSemester.TabIndex = 0;
            this.labelAddSemester.Text = "Add New Semester";
            // 
            // labelRemoveSemester
            // 
            this.labelRemoveSemester.AutoSize = true;
            this.labelRemoveSemester.Location = new System.Drawing.Point(12, 205);
            this.labelRemoveSemester.Name = "labelRemoveSemester";
            this.labelRemoveSemester.Size = new System.Drawing.Size(141, 20);
            this.labelRemoveSemester.TabIndex = 1;
            this.labelRemoveSemester.Text = "Remove Semester";
            // 
            // labelUpdateSemesterName
            // 
            this.labelUpdateSemesterName.AutoSize = true;
            this.labelUpdateSemesterName.Location = new System.Drawing.Point(12, 304);
            this.labelUpdateSemesterName.Name = "labelUpdateSemesterName";
            this.labelUpdateSemesterName.Size = new System.Drawing.Size(181, 20);
            this.labelUpdateSemesterName.TabIndex = 2;
            this.labelUpdateSemesterName.Text = "Update Semester Name";
            // 
            // labelAllSemesters
            // 
            this.labelAllSemesters.AutoSize = true;
            this.labelAllSemesters.Location = new System.Drawing.Point(515, 110);
            this.labelAllSemesters.Name = "labelAllSemesters";
            this.labelAllSemesters.Size = new System.Drawing.Size(107, 20);
            this.labelAllSemesters.TabIndex = 3;
            this.labelAllSemesters.Text = "All Semesters";
            // 
            // labelSemesterName
            // 
            this.labelSemesterName.AutoSize = true;
            this.labelSemesterName.Location = new System.Drawing.Point(12, 144);
            this.labelSemesterName.Name = "labelSemesterName";
            this.labelSemesterName.Size = new System.Drawing.Size(124, 20);
            this.labelSemesterName.TabIndex = 4;
            this.labelSemesterName.Text = "Semester Name";
            // 
            // textBoxSemesterName
            // 
            this.textBoxSemesterName.Location = new System.Drawing.Point(189, 144);
            this.textBoxSemesterName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSemesterName.Name = "textBoxSemesterName";
            this.textBoxSemesterName.Size = new System.Drawing.Size(185, 26);
            this.textBoxSemesterName.TabIndex = 5;
            // 
            // buttonAddSemester
            // 
            this.buttonAddSemester.Location = new System.Drawing.Point(388, 134);
            this.buttonAddSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSemester.Name = "buttonAddSemester";
            this.buttonAddSemester.Size = new System.Drawing.Size(100, 48);
            this.buttonAddSemester.TabIndex = 6;
            this.buttonAddSemester.Text = "Add";
            this.buttonAddSemester.UseVisualStyleBackColor = true;
            this.buttonAddSemester.Click += new System.EventHandler(this.AddClicked);
            // 
            // labelSemesterId
            // 
            this.labelSemesterId.AutoSize = true;
            this.labelSemesterId.Location = new System.Drawing.Point(12, 241);
            this.labelSemesterId.Name = "labelSemesterId";
            this.labelSemesterId.Size = new System.Drawing.Size(92, 20);
            this.labelSemesterId.TabIndex = 7;
            this.labelSemesterId.Text = "SemesterId";
            // 
            // textBoxSemesterId
            // 
            this.textBoxSemesterId.Location = new System.Drawing.Point(189, 241);
            this.textBoxSemesterId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSemesterId.Name = "textBoxSemesterId";
            this.textBoxSemesterId.Size = new System.Drawing.Size(185, 26);
            this.textBoxSemesterId.TabIndex = 8;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(388, 228);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 46);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.RemoveClicked);
            // 
            // textBoxSemesterId2
            // 
            this.textBoxSemesterId2.Location = new System.Drawing.Point(189, 346);
            this.textBoxSemesterId2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSemesterId2.Name = "textBoxSemesterId2";
            this.textBoxSemesterId2.Size = new System.Drawing.Size(185, 26);
            this.textBoxSemesterId2.TabIndex = 11;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(388, 338);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 42);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.UpdateClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "SemesterId";
            // 
            // labelNewSemesterName
            // 
            this.labelNewSemesterName.AutoSize = true;
            this.labelNewSemesterName.Location = new System.Drawing.Point(12, 390);
            this.labelNewSemesterName.Name = "labelNewSemesterName";
            this.labelNewSemesterName.Size = new System.Drawing.Size(159, 20);
            this.labelNewSemesterName.TabIndex = 14;
            this.labelNewSemesterName.Text = "New Semester Name";
            // 
            // textBoxNewSemesterName
            // 
            this.textBoxNewSemesterName.Location = new System.Drawing.Point(189, 390);
            this.textBoxNewSemesterName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewSemesterName.Name = "textBoxNewSemesterName";
            this.textBoxNewSemesterName.Size = new System.Drawing.Size(185, 26);
            this.textBoxNewSemesterName.TabIndex = 15;
            // 
            // dataGridViewSemesters
            // 
            this.dataGridViewSemesters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSemesters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSemesters.Location = new System.Drawing.Point(519, 155);
            this.dataGridViewSemesters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSemesters.Name = "dataGridViewSemesters";
            this.dataGridViewSemesters.ReadOnly = true;
            this.dataGridViewSemesters.RowTemplate.Height = 28;
            this.dataGridViewSemesters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSemesters.Size = new System.Drawing.Size(547, 381);
            this.dataGridViewSemesters.TabIndex = 16;
            this.dataGridViewSemesters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSemestersDoubleClicked);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(950, 108);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(116, 42);
            this.buttonRefresh.TabIndex = 17;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.RefreshClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Change Registration Status";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(388, 490);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(100, 46);
            this.buttonChange.TabIndex = 21;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ChangeClicked);
            // 
            // textBoxSemesterId3
            // 
            this.textBoxSemesterId3.Location = new System.Drawing.Point(189, 503);
            this.textBoxSemesterId3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSemesterId3.Name = "textBoxSemesterId3";
            this.textBoxSemesterId3.Size = new System.Drawing.Size(185, 26);
            this.textBoxSemesterId3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "SemesterId";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(944, 11);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(122, 54);
            this.buttonLogOut.TabIndex = 22;
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
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackClicked);
            // 
            // SemesterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxSemesterId3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewSemesters);
            this.Controls.Add(this.textBoxNewSemesterName);
            this.Controls.Add(this.labelNewSemesterName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxSemesterId2);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxSemesterId);
            this.Controls.Add(this.labelSemesterId);
            this.Controls.Add(this.buttonAddSemester);
            this.Controls.Add(this.textBoxSemesterName);
            this.Controls.Add(this.labelSemesterName);
            this.Controls.Add(this.labelAllSemesters);
            this.Controls.Add(this.labelUpdateSemesterName);
            this.Controls.Add(this.labelRemoveSemester);
            this.Controls.Add(this.labelAddSemester);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SemesterInfo";
            this.Text = "Semester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemesters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddSemester;
        private System.Windows.Forms.Label labelRemoveSemester;
        private System.Windows.Forms.Label labelUpdateSemesterName;
        private System.Windows.Forms.Label labelAllSemesters;
        private System.Windows.Forms.Label labelSemesterName;
        private System.Windows.Forms.TextBox textBoxSemesterName;
        private System.Windows.Forms.Button buttonAddSemester;
        private System.Windows.Forms.Label labelSemesterId;
        private System.Windows.Forms.TextBox textBoxSemesterId;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxSemesterId2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNewSemesterName;
        private System.Windows.Forms.TextBox textBoxNewSemesterName;
        private System.Windows.Forms.DataGridView dataGridViewSemesters;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxSemesterId3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
    }
}