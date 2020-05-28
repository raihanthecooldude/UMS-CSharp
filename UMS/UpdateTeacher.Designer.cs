namespace UMS
{
    partial class UpdateTeacher
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
            this.weeklabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.weekhourtextBox = new System.Windows.Forms.TextBox();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklabel
            // 
            this.weeklabel.AutoSize = true;
            this.weeklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklabel.Location = new System.Drawing.Point(37, 123);
            this.weeklabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weeklabel.Name = "weeklabel";
            this.weeklabel.Size = new System.Drawing.Size(121, 26);
            this.weeklabel.TabIndex = 11;
            this.weeklabel.Text = "WeekHour:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Location = new System.Drawing.Point(77, 183);
            this.statuslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(80, 26);
            this.statuslabel.TabIndex = 14;
            this.statuslabel.Text = "Status:";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(181, 64);
            this.idtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(216, 22);
            this.idtextBox.TabIndex = 20;
            // 
            // weekhourtextBox
            // 
            this.weekhourtextBox.Location = new System.Drawing.Point(181, 126);
            this.weekhourtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.weekhourtextBox.Name = "weekhourtextBox";
            this.weekhourtextBox.Size = new System.Drawing.Size(216, 22);
            this.weekhourtextBox.TabIndex = 21;
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Location = new System.Drawing.Point(181, 183);
            this.statuscomboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(216, 24);
            this.statuscomboBox.TabIndex = 23;
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(42, 360);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(4);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(375, 57);
            this.updatebutton.TabIndex = 24;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(1224, 13);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(98, 28);
            this.exitbutton.TabIndex = 28;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(1138, 13);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(98, 28);
            this.logoutbutton.TabIndex = 27;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(1054, 13);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(98, 28);
            this.backbutton.TabIndex = 26;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(868, 291);
            this.dataGridView1.TabIndex = 29;
            // 
            // refreshbutton
            // 
            this.refreshbutton.Location = new System.Drawing.Point(1217, 91);
            this.refreshbutton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(98, 28);
            this.refreshbutton.TabIndex = 30;
            this.refreshbutton.Text = "Refresh";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // UpdateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 500);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.statuscomboBox);
            this.Controls.Add(this.weekhourtextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weeklabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateTeacher";
            this.Text = "UpdateTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weeklabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox weekhourtextBox;
        private System.Windows.Forms.ComboBox statuscomboBox;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refreshbutton;
    }
}