namespace UMS
{
    partial class ValidPayment
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
            this.labelAccountId = new System.Windows.Forms.Label();
            this.comboBoxAccountId = new System.Windows.Forms.ComboBox();
            this.buttonValid = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAccountId
            // 
            this.labelAccountId.AutoSize = true;
            this.labelAccountId.Location = new System.Drawing.Point(11, 89);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(74, 17);
            this.labelAccountId.TabIndex = 3;
            this.labelAccountId.Text = "Account Id";
            // 
            // comboBoxAccountId
            // 
            this.comboBoxAccountId.FormattingEnabled = true;
            this.comboBoxAccountId.Location = new System.Drawing.Point(10, 120);
            this.comboBoxAccountId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAccountId.Name = "comboBoxAccountId";
            this.comboBoxAccountId.Size = new System.Drawing.Size(155, 24);
            this.comboBoxAccountId.TabIndex = 2;
            // 
            // buttonValid
            // 
            this.buttonValid.Location = new System.Drawing.Point(14, 200);
            this.buttonValid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(182, 56);
            this.buttonValid.TabIndex = 5;
            this.buttonValid.Text = "Valid";
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.ValidClicked);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(310, 10);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(108, 43);
            this.buttonLogOut.TabIndex = 6;
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
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.BackClicked);
            // 
            // ValidPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 417);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.labelAccountId);
            this.Controls.Add(this.comboBoxAccountId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ValidPayment";
            this.Text = "ValidPayment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.ComboBox comboBoxAccountId;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
    }
}