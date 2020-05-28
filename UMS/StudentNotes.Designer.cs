namespace UMS
{
    partial class StudentNotes
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
            this.NotesGridView = new System.Windows.Forms.DataGridView();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.DropBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NotesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(604, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(251, 32);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.Location = new System.Drawing.Point(63, 9);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(100, 23);
            this.LogOutLabel.TabIndex = 11;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // BackLabel
            // 
            this.BackLabel.Location = new System.Drawing.Point(5, 9);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(67, 23);
            this.BackLabel.TabIndex = 10;
            this.BackLabel.Text = "Back";
            this.BackLabel.Click += new System.EventHandler(this.BackCLicked);
            // 
            // NotesGridView
            // 
            this.NotesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.NotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotesGridView.Location = new System.Drawing.Point(12, 141);
            this.NotesGridView.Name = "NotesGridView";
            this.NotesGridView.RowTemplate.Height = 24;
            this.NotesGridView.Size = new System.Drawing.Size(834, 235);
            this.NotesGridView.TabIndex = 13;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.Location = new System.Drawing.Point(9, 87);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(254, 39);
            this.SubjectLabel.TabIndex = 14;
            // 
            // DropBtn
            // 
            this.DropBtn.Location = new System.Drawing.Point(12, 410);
            this.DropBtn.Name = "DropBtn";
            this.DropBtn.Size = new System.Drawing.Size(166, 44);
            this.DropBtn.TabIndex = 15;
            this.DropBtn.Text = "Drop This Course";
            this.DropBtn.UseVisualStyleBackColor = true;
            this.DropBtn.Click += new System.EventHandler(this.DropClicked);
            // 
            // StudentNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 606);
            this.Controls.Add(this.DropBtn);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.NotesGridView);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.BackLabel);
            this.Name = "StudentNotes";
            this.Text = "StudentNotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.NotesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.DataGridView NotesGridView;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Button DropBtn;
    }
}