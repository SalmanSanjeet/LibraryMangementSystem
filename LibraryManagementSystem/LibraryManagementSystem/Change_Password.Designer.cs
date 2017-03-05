namespace LibraryManagementSystem
{
    partial class Change_Password
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.oldPwdLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.oldPwdTextbox = new System.Windows.Forms.TextBox();
            this.pwdTextbox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(36, 26);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(59, 12);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // oldPwdLabel
            // 
            this.oldPwdLabel.AutoSize = true;
            this.oldPwdLabel.Location = new System.Drawing.Point(12, 59);
            this.oldPwdLabel.Name = "oldPwdLabel";
            this.oldPwdLabel.Size = new System.Drawing.Size(83, 12);
            this.oldPwdLabel.TabIndex = 1;
            this.oldPwdLabel.Text = "Old Password:";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(36, 92);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(59, 12);
            this.pwdLabel.TabIndex = 2;
            this.pwdLabel.Text = "Password:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(111, 23);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(194, 21);
            this.usernameTextbox.TabIndex = 3;
            // 
            // oldPwdTextbox
            // 
            this.oldPwdTextbox.Location = new System.Drawing.Point(111, 56);
            this.oldPwdTextbox.Name = "oldPwdTextbox";
            this.oldPwdTextbox.Size = new System.Drawing.Size(194, 21);
            this.oldPwdTextbox.TabIndex = 4;
            // 
            // pwdTextbox
            // 
            this.pwdTextbox.Location = new System.Drawing.Point(111, 89);
            this.pwdTextbox.Name = "pwdTextbox";
            this.pwdTextbox.Size = new System.Drawing.Size(194, 21);
            this.pwdTextbox.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(111, 127);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 24);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(215, 127);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(90, 24);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 174);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pwdTextbox);
            this.Controls.Add(this.oldPwdTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.oldPwdLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Change_Password";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label oldPwdLabel;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox oldPwdTextbox;
        private System.Windows.Forms.TextBox pwdTextbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button changeButton;
    }
}