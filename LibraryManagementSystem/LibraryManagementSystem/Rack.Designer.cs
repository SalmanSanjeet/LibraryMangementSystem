namespace LibraryManagementSystem
{
    partial class Rack
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
            this.rackIDLabel = new System.Windows.Forms.Label();
            this.rackNameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.rackIDTextbox = new System.Windows.Forms.TextBox();
            this.rackNameTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.rackDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rackDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rackIDLabel
            // 
            this.rackIDLabel.AutoSize = true;
            this.rackIDLabel.Location = new System.Drawing.Point(55, 32);
            this.rackIDLabel.Name = "rackIDLabel";
            this.rackIDLabel.Size = new System.Drawing.Size(53, 12);
            this.rackIDLabel.TabIndex = 0;
            this.rackIDLabel.Text = "Rack ID:";
            // 
            // rackNameLabel
            // 
            this.rackNameLabel.AutoSize = true;
            this.rackNameLabel.Location = new System.Drawing.Point(43, 71);
            this.rackNameLabel.Name = "rackNameLabel";
            this.rackNameLabel.Size = new System.Drawing.Size(65, 12);
            this.rackNameLabel.TabIndex = 1;
            this.rackNameLabel.Text = "Rack Name:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(61, 111);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 12);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status:";
            // 
            // rackIDTextbox
            // 
            this.rackIDTextbox.Location = new System.Drawing.Point(118, 29);
            this.rackIDTextbox.Name = "rackIDTextbox";
            this.rackIDTextbox.Size = new System.Drawing.Size(204, 21);
            this.rackIDTextbox.TabIndex = 3;
            // 
            // rackNameTextBox
            // 
            this.rackNameTextBox.Location = new System.Drawing.Point(118, 68);
            this.rackNameTextBox.Name = "rackNameTextBox";
            this.rackNameTextBox.Size = new System.Drawing.Size(204, 21);
            this.rackNameTextBox.TabIndex = 4;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(118, 108);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(204, 20);
            this.statusComboBox.TabIndex = 5;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(353, 29);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(105, 40);
            this.newButton.TabIndex = 6;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(476, 29);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 40);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(353, 88);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(105, 40);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(476, 88);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 40);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // rackDataGridView
            // 
            this.rackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rackDataGridView.Location = new System.Drawing.Point(30, 149);
            this.rackDataGridView.Name = "rackDataGridView";
            this.rackDataGridView.RowTemplate.Height = 23;
            this.rackDataGridView.Size = new System.Drawing.Size(551, 209);
            this.rackDataGridView.TabIndex = 10;
            // 
            // Rack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 383);
            this.Controls.Add(this.rackDataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.rackNameTextBox);
            this.Controls.Add(this.rackIDTextbox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.rackNameLabel);
            this.Controls.Add(this.rackIDLabel);
            this.Name = "Rack";
            this.Text = "Rack";
            ((System.ComponentModel.ISupportInitialize)(this.rackDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rackIDLabel;
        private System.Windows.Forms.Label rackNameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox rackIDTextbox;
        private System.Windows.Forms.TextBox rackNameTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView rackDataGridView;
    }
}