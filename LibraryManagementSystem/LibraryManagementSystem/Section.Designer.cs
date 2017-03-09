namespace LibraryManagementSystem
{
    partial class Section
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
            this.sectionIDLabel = new System.Windows.Forms.Label();
            this.sectionNameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.sectionIDTextbox = new System.Windows.Forms.TextBox();
            this.sectionNameTextbox = new System.Windows.Forms.TextBox();
            this.statusCombobox = new System.Windows.Forms.ComboBox();
            this.newButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.sectionDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionIDLabel
            // 
            this.sectionIDLabel.AutoSize = true;
            this.sectionIDLabel.Location = new System.Drawing.Point(19, 27);
            this.sectionIDLabel.Name = "sectionIDLabel";
            this.sectionIDLabel.Size = new System.Drawing.Size(71, 12);
            this.sectionIDLabel.TabIndex = 0;
            this.sectionIDLabel.Text = "Section ID:";
            // 
            // sectionNameLabel
            // 
            this.sectionNameLabel.AutoSize = true;
            this.sectionNameLabel.Location = new System.Drawing.Point(7, 63);
            this.sectionNameLabel.Name = "sectionNameLabel";
            this.sectionNameLabel.Size = new System.Drawing.Size(83, 12);
            this.sectionNameLabel.TabIndex = 1;
            this.sectionNameLabel.Text = "Section Name:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(43, 100);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 12);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status:";
            // 
            // sectionIDTextbox
            // 
            this.sectionIDTextbox.Location = new System.Drawing.Point(100, 24);
            this.sectionIDTextbox.Name = "sectionIDTextbox";
            this.sectionIDTextbox.Size = new System.Drawing.Size(207, 21);
            this.sectionIDTextbox.TabIndex = 3;
            // 
            // sectionNameTextbox
            // 
            this.sectionNameTextbox.Location = new System.Drawing.Point(100, 60);
            this.sectionNameTextbox.Name = "sectionNameTextbox";
            this.sectionNameTextbox.Size = new System.Drawing.Size(207, 21);
            this.sectionNameTextbox.TabIndex = 4;
            // 
            // statusCombobox
            // 
            this.statusCombobox.FormattingEnabled = true;
            this.statusCombobox.Location = new System.Drawing.Point(100, 97);
            this.statusCombobox.Name = "statusCombobox";
            this.statusCombobox.Size = new System.Drawing.Size(207, 20);
            this.statusCombobox.TabIndex = 5;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(348, 27);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(105, 34);
            this.newButton.TabIndex = 6;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(348, 82);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(105, 34);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(472, 27);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 34);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(472, 82);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 34);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // sectionDataGridView
            // 
            this.sectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionDataGridView.Location = new System.Drawing.Point(38, 133);
            this.sectionDataGridView.Name = "sectionDataGridView";
            this.sectionDataGridView.RowTemplate.Height = 23;
            this.sectionDataGridView.Size = new System.Drawing.Size(539, 205);
            this.sectionDataGridView.TabIndex = 10;
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 360);
            this.Controls.Add(this.sectionDataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.statusCombobox);
            this.Controls.Add(this.sectionNameTextbox);
            this.Controls.Add(this.sectionIDTextbox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.sectionNameLabel);
            this.Controls.Add(this.sectionIDLabel);
            this.Name = "Section";
            this.Text = "Section";
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sectionIDLabel;
        private System.Windows.Forms.Label sectionNameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox sectionIDTextbox;
        private System.Windows.Forms.TextBox sectionNameTextbox;
        private System.Windows.Forms.ComboBox statusCombobox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView sectionDataGridView;
    }
}