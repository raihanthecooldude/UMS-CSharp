namespace UMS
{
    partial class HandleScholarship
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
            this.comboBoxAccountId = new System.Windows.Forms.ComboBox();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScholarshipPercentage = new System.Windows.Forms.TextBox();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAccountId
            // 
            this.comboBoxAccountId.FormattingEnabled = true;
            this.comboBoxAccountId.Location = new System.Drawing.Point(10, 106);
            this.comboBoxAccountId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAccountId.Name = "comboBoxAccountId";
            this.comboBoxAccountId.Size = new System.Drawing.Size(155, 24);
            this.comboBoxAccountId.TabIndex = 0;
            // 
            // labelAccountId
            // 
            this.labelAccountId.AutoSize = true;
            this.labelAccountId.Location = new System.Drawing.Point(11, 75);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(74, 17);
            this.labelAccountId.TabIndex = 1;
            this.labelAccountId.Text = "Account Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scholarship Percentage";
            // 
            // textBoxScholarshipPercentage
            // 
            this.textBoxScholarshipPercentage.Location = new System.Drawing.Point(245, 106);
            this.textBoxScholarshipPercentage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScholarshipPercentage.Name = "textBoxScholarshipPercentage";
            this.textBoxScholarshipPercentage.Size = new System.Drawing.Size(155, 22);
            this.textBoxScholarshipPercentage.TabIndex = 3;
            // 
            // buttonApprove
            // 
            this.buttonApprove.Location = new System.Drawing.Point(113, 187);
            this.buttonApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(182, 56);
            this.buttonApprove.TabIndex = 4;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = true;
            this.buttonApprove.Click += new System.EventHandler(this.ApproveClicked);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(312, 10);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(108, 43);
            this.buttonLogOut.TabIndex = 5;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.LogOutClicked);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(10, 10);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(108, 43);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackClicked);
            // 
            // HandleScholarship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 418);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.textBoxScholarshipPercentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAccountId);
            this.Controls.Add(this.comboBoxAccountId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HandleScholarship";
            this.Text = "HandleScholarship";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAccountId;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxScholarshipPercentage;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
    }
}