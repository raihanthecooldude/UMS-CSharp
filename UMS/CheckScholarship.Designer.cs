namespace UMS
{
    partial class CheckScholarship
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAccountId = new System.Windows.Forms.ComboBox();
            this.buttonEligible = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student IDs";
            // 
            // comboBoxAccountId
            // 
            this.comboBoxAccountId.FormattingEnabled = true;
            this.comboBoxAccountId.Location = new System.Drawing.Point(11, 110);
            this.comboBoxAccountId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAccountId.Name = "comboBoxAccountId";
            this.comboBoxAccountId.Size = new System.Drawing.Size(156, 24);
            this.comboBoxAccountId.TabIndex = 1;
            // 
            // buttonEligible
            // 
            this.buttonEligible.Location = new System.Drawing.Point(306, 95);
            this.buttonEligible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEligible.Name = "buttonEligible";
            this.buttonEligible.Size = new System.Drawing.Size(91, 38);
            this.buttonEligible.TabIndex = 2;
            this.buttonEligible.Text = "Eligible";
            this.buttonEligible.UseVisualStyleBackColor = true;
            this.buttonEligible.Click += new System.EventHandler(this.EligibleClicked);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(360, 10);
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
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackClicked);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(10, 184);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(91, 38);
            this.buttonResult.TabIndex = 15;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.ResultClicked);
            // 
            // CheckScholarship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 414);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonEligible);
            this.Controls.Add(this.comboBoxAccountId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckScholarship";
            this.Text = "CheckScholarship";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAccountId;
        private System.Windows.Forms.Button buttonEligible;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonResult;
    }
}