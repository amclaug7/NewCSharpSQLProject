namespace NewDatabaseProject
{
    partial class NewAccountCreation
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
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordConfirmation = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblPasswordMatching = new System.Windows.Forms.Label();
            this.lblPasswordQuality = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(71, 57);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(71, 96);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(71, 135);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxConfirmPassword.TabIndex = 2;
            this.tbxConfirmPassword.TextChanged += new System.EventHandler(this.tbxConfirmPassword_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(70, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Enter New Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(70, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Enter New Password";
            // 
            // lblPasswordConfirmation
            // 
            this.lblPasswordConfirmation.AutoSize = true;
            this.lblPasswordConfirmation.Location = new System.Drawing.Point(70, 119);
            this.lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            this.lblPasswordConfirmation.Size = new System.Drawing.Size(91, 13);
            this.lblPasswordConfirmation.TabIndex = 5;
            this.lblPasswordConfirmation.Text = "Confirm Password";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(71, 161);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(100, 23);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblPasswordMatching
            // 
            this.lblPasswordMatching.AutoSize = true;
            this.lblPasswordMatching.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordMatching.Location = new System.Drawing.Point(177, 138);
            this.lblPasswordMatching.Name = "lblPasswordMatching";
            this.lblPasswordMatching.Size = new System.Drawing.Size(14, 13);
            this.lblPasswordMatching.TabIndex = 7;
            this.lblPasswordMatching.Text = "X";
            // 
            // lblPasswordQuality
            // 
            this.lblPasswordQuality.AutoSize = true;
            this.lblPasswordQuality.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordQuality.Location = new System.Drawing.Point(177, 99);
            this.lblPasswordQuality.Name = "lblPasswordQuality";
            this.lblPasswordQuality.Size = new System.Drawing.Size(14, 13);
            this.lblPasswordQuality.TabIndex = 8;
            this.lblPasswordQuality.Text = "X";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(71, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NewAccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 257);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPasswordQuality);
            this.Controls.Add(this.lblPasswordMatching);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblPasswordConfirmation);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "NewAccountCreation";
            this.Text = "Account Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordConfirmation;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblPasswordMatching;
        private System.Windows.Forms.Label lblPasswordQuality;
        private System.Windows.Forms.Button btnExit;
    }
}