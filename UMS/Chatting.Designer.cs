namespace UMS
{
    partial class Chatting
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
            this.SemesterComboBox = new System.Windows.Forms.ComboBox();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.IDComboBox = new System.Windows.Forms.ComboBox();
            this.InboxNameLabel = new System.Windows.Forms.Label();
            this.OutboxTextBox = new System.Windows.Forms.TextBox();
            this.SendMsgBtn = new System.Windows.Forms.Button();
            this.InboxLabel = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.OutboxNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(680, 11);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(282, 40);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.Location = new System.Drawing.Point(71, 11);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(112, 29);
            this.LogOutLabel.TabIndex = 11;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // BackLabel
            // 
            this.BackLabel.Location = new System.Drawing.Point(6, 11);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(75, 29);
            this.BackLabel.TabIndex = 10;
            this.BackLabel.Text = "Back";
            this.BackLabel.Click += new System.EventHandler(this.BackClicked);
            // 
            // SemesterComboBox
            // 
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Location = new System.Drawing.Point(9, 134);
            this.SemesterComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(176, 28);
            this.SemesterComboBox.TabIndex = 13;
            this.SemesterComboBox.Text = "Semester";
            this.SemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.SemesterComboBox_SelectedIndexChanged);
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(256, 134);
            this.CourseComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(176, 28);
            this.CourseComboBox.TabIndex = 14;
            this.CourseComboBox.Text = "Course";
            this.CourseComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseComboBox_SelectedIndexChanged);
            // 
            // SectionComboBox
            // 
            this.SectionComboBox.FormattingEnabled = true;
            this.SectionComboBox.Location = new System.Drawing.Point(508, 134);
            this.SectionComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SectionComboBox.Name = "SectionComboBox";
            this.SectionComboBox.Size = new System.Drawing.Size(176, 28);
            this.SectionComboBox.TabIndex = 15;
            this.SectionComboBox.Text = "Section";
            this.SectionComboBox.SelectedIndexChanged += new System.EventHandler(this.SectionComboBox_SelectedIndexChanged);
            // 
            // IDComboBox
            // 
            this.IDComboBox.FormattingEnabled = true;
            this.IDComboBox.Location = new System.Drawing.Point(765, 134);
            this.IDComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDComboBox.Name = "IDComboBox";
            this.IDComboBox.Size = new System.Drawing.Size(176, 28);
            this.IDComboBox.TabIndex = 16;
            this.IDComboBox.Text = "ID";
            // 
            // InboxNameLabel
            // 
            this.InboxNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.InboxNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InboxNameLabel.Location = new System.Drawing.Point(504, 232);
            this.InboxNameLabel.Name = "InboxNameLabel";
            this.InboxNameLabel.Size = new System.Drawing.Size(123, 44);
            this.InboxNameLabel.TabIndex = 17;
            this.InboxNameLabel.Text = "Inbox";
            // 
            // OutboxTextBox
            // 
            this.OutboxTextBox.BackColor = System.Drawing.Color.White;
            this.OutboxTextBox.Location = new System.Drawing.Point(14, 291);
            this.OutboxTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutboxTextBox.Multiline = true;
            this.OutboxTextBox.Name = "OutboxTextBox";
            this.OutboxTextBox.Size = new System.Drawing.Size(422, 328);
            this.OutboxTextBox.TabIndex = 18;
            // 
            // SendMsgBtn
            // 
            this.SendMsgBtn.Location = new System.Drawing.Point(14, 641);
            this.SendMsgBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SendMsgBtn.Name = "SendMsgBtn";
            this.SendMsgBtn.Size = new System.Drawing.Size(173, 45);
            this.SendMsgBtn.TabIndex = 19;
            this.SendMsgBtn.Text = "Send";
            this.SendMsgBtn.UseVisualStyleBackColor = true;
            this.SendMsgBtn.Click += new System.EventHandler(this.SendMsgClicked);
            // 
            // InboxLabel
            // 
            this.InboxLabel.BackColor = System.Drawing.Color.White;
            this.InboxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InboxLabel.Location = new System.Drawing.Point(508, 291);
            this.InboxLabel.Name = "InboxLabel";
            this.InboxLabel.Size = new System.Drawing.Size(433, 328);
            this.InboxLabel.TabIndex = 20;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(512, 641);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(173, 45);
            this.ClearBtn.TabIndex = 21;
            this.ClearBtn.Text = "Clear Messages";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearMsgClicked);
            // 
            // OutboxNameLabel
            // 
            this.OutboxNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.OutboxNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutboxNameLabel.Location = new System.Drawing.Point(14, 232);
            this.OutboxNameLabel.Name = "OutboxNameLabel";
            this.OutboxNameLabel.Size = new System.Drawing.Size(123, 44);
            this.OutboxNameLabel.TabIndex = 22;
            this.OutboxNameLabel.Text = "Outbox";
            // 
            // Chatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 758);
            this.Controls.Add(this.OutboxNameLabel);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.InboxLabel);
            this.Controls.Add(this.SendMsgBtn);
            this.Controls.Add(this.OutboxTextBox);
            this.Controls.Add(this.InboxNameLabel);
            this.Controls.Add(this.IDComboBox);
            this.Controls.Add(this.SectionComboBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.SemesterComboBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.BackLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Chatting";
            this.Text = "Chatting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.ComboBox SectionComboBox;
        private System.Windows.Forms.ComboBox IDComboBox;
        private System.Windows.Forms.Label InboxNameLabel;
        private System.Windows.Forms.TextBox OutboxTextBox;
        private System.Windows.Forms.Button SendMsgBtn;
        private System.Windows.Forms.Label InboxLabel;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label OutboxNameLabel;
    }
}