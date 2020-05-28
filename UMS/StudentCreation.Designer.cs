namespace UMS
{
    partial class StudentCreation
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
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.passsettextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.createbutton = new System.Windows.Forms.Button();
            this.bloodgrouptextbox = new System.Windows.Forms.TextBox();
            this.dobtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.gendercomboBox = new System.Windows.Forms.ComboBox();
            this.umsDatabaseDataSet1 = new Repository.UMSDatabaseDataSet();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.refreshbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.umsDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(198, 65);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(163, 20);
            this.idtextBox.TabIndex = 0;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(198, 108);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(163, 20);
            this.nametextBox.TabIndex = 1;
            // 
            // passsettextBox
            // 
            this.passsettextBox.Location = new System.Drawing.Point(198, 156);
            this.passsettextBox.Name = "passsettextBox";
            this.passsettextBox.Size = new System.Drawing.Size(163, 20);
            this.passsettextBox.TabIndex = 2;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(198, 254);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(163, 20);
            this.addresstextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(85, 106);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 22);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(85, 154);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(94, 22);
            this.passlabel.TabIndex = 6;
            this.passlabel.Text = "Password:";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.Location = new System.Drawing.Point(85, 207);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(75, 22);
            this.genderlabel.TabIndex = 7;
            this.genderlabel.Text = "Gender:";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.Location = new System.Drawing.Point(85, 252);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(81, 22);
            this.addresslabel.TabIndex = 8;
            this.addresslabel.Text = "Address:";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.Location = new System.Drawing.Point(85, 63);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(32, 22);
            this.idlabel.TabIndex = 9;
            this.idlabel.Text = "ID:";
            // 
            // createbutton
            // 
            this.createbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbutton.Location = new System.Drawing.Point(89, 392);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(295, 49);
            this.createbutton.TabIndex = 10;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            this.createbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.createbutton_MouseClick);
            // 
            // bloodgrouptextbox
            // 
            this.bloodgrouptextbox.Location = new System.Drawing.Point(200, 295);
            this.bloodgrouptextbox.Name = "bloodgrouptextbox";
            this.bloodgrouptextbox.Size = new System.Drawing.Size(163, 20);
            this.bloodgrouptextbox.TabIndex = 13;
            // 
            // dobtextbox
            // 
            this.dobtextbox.Location = new System.Drawing.Point(200, 337);
            this.dobtextbox.Name = "dobtextbox";
            this.dobtextbox.Size = new System.Drawing.Size(163, 20);
            this.dobtextbox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "BloodGroup:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "DateOfBIrth:";
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(1094, 12);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 19;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(1030, 12);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(75, 23);
            this.logoutbutton.TabIndex = 18;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(966, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 17;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // gendercomboBox
            // 
            this.gendercomboBox.FormattingEnabled = true;
            this.gendercomboBox.Location = new System.Drawing.Point(200, 208);
            this.gendercomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gendercomboBox.Name = "gendercomboBox";
            this.gendercomboBox.Size = new System.Drawing.Size(82, 21);
            this.gendercomboBox.TabIndex = 20;
            // 
            // umsDatabaseDataSet1
            // 
            this.umsDatabaseDataSet1.DataSetName = "UMSDatabaseDataSet";
            this.umsDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(454, 106);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(699, 335);
            this.dataGridView.TabIndex = 21;
            // 
            // refreshbutton
            // 
            this.refreshbutton.Location = new System.Drawing.Point(1078, 65);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(75, 23);
            this.refreshbutton.TabIndex = 22;
            this.refreshbutton.Text = "Refresh";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // StudentCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 525);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gendercomboBox);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dobtextbox);
            this.Controls.Add(this.bloodgrouptextbox);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.passsettextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.idtextBox);
            this.Name = "StudentCreation";
            this.Text = "StudentCreation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            ((System.ComponentModel.ISupportInitialize)(this.umsDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Repository.UMSDatabaseDataSet umsDatabaseDataSet1;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox passsettextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.TextBox bloodgrouptextbox;
        private System.Windows.Forms.TextBox dobtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.ComboBox gendercomboBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button refreshbutton;
    }
}