namespace LibraryManagementSystem.UI
{
    partial class Role
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
            this.bookIDLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bookIDTextbox = new System.Windows.Forms.TextBox();
            this.bookNameTextbox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.roleDataGridView = new System.Windows.Forms.DataGridView();
            this.NumTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCombobox = new System.Windows.Forms.ComboBox();
            this.rowCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookIDLabel
            // 
            this.bookIDLabel.AutoSize = true;
            this.bookIDLabel.Location = new System.Drawing.Point(43, 35);
            this.bookIDLabel.Name = "bookIDLabel";
            this.bookIDLabel.Size = new System.Drawing.Size(53, 12);
            this.bookIDLabel.TabIndex = 0;
            this.bookIDLabel.Text = "Book ID:";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(31, 70);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(65, 12);
            this.bookNameLabel.TabIndex = 1;
            this.bookNameLabel.Text = "Book Name:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(49, 104);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 12);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status:";
            // 
            // bookIDTextbox
            // 
            this.bookIDTextbox.Enabled = false;
            this.bookIDTextbox.Location = new System.Drawing.Point(111, 32);
            this.bookIDTextbox.Name = "bookIDTextbox";
            this.bookIDTextbox.Size = new System.Drawing.Size(214, 21);
            this.bookIDTextbox.TabIndex = 3;
            // 
            // bookNameTextbox
            // 
            this.bookNameTextbox.Location = new System.Drawing.Point(111, 67);
            this.bookNameTextbox.Name = "bookNameTextbox";
            this.bookNameTextbox.Size = new System.Drawing.Size(214, 21);
            this.bookNameTextbox.TabIndex = 4;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(392, 32);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(97, 34);
            this.newButton.TabIndex = 6;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(495, 32);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 34);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(392, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(97, 34);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(495, 73);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 34);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // roleDataGridView
            // 
            this.roleDataGridView.AllowUserToAddRows = false;
            this.roleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumTag,
            this.Role_ID,
            this.Role_Name,
            this.Role_Status});
            this.roleDataGridView.Location = new System.Drawing.Point(33, 143);
            this.roleDataGridView.Name = "roleDataGridView";
            this.roleDataGridView.RowHeadersVisible = false;
            this.roleDataGridView.RowTemplate.Height = 23;
            this.roleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roleDataGridView.Size = new System.Drawing.Size(559, 184);
            this.roleDataGridView.TabIndex = 10;
            this.roleDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.roleDataGridView_MouseDoubleClick);
            // 
            // NumTag
            // 
            this.NumTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumTag.HeaderText = "#";
            this.NumTag.Name = "NumTag";
            this.NumTag.Width = 36;
            // 
            // Role_ID
            // 
            this.Role_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Role_ID.HeaderText = "Role_ID";
            this.Role_ID.Name = "Role_ID";
            this.Role_ID.Width = 72;
            // 
            // Role_Name
            // 
            this.Role_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role_Name.HeaderText = "Role_Name";
            this.Role_Name.Name = "Role_Name";
            // 
            // Role_Status
            // 
            this.Role_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Role_Status.HeaderText = "Role_Status";
            this.Role_Status.Name = "Role_Status";
            this.Role_Status.Width = 96;
            // 
            // statusCombobox
            // 
            this.statusCombobox.FormattingEnabled = true;
            this.statusCombobox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusCombobox.Location = new System.Drawing.Point(111, 104);
            this.statusCombobox.Name = "statusCombobox";
            this.statusCombobox.Size = new System.Drawing.Size(214, 20);
            this.statusCombobox.TabIndex = 11;
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.Location = new System.Drawing.Point(493, 340);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(77, 12);
            this.rowCountLabel.TabIndex = 12;
            this.rowCountLabel.Text = "Row Count: 0";
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 388);
            this.Controls.Add(this.rowCountLabel);
            this.Controls.Add(this.statusCombobox);
            this.Controls.Add(this.roleDataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.bookNameTextbox);
            this.Controls.Add(this.bookIDTextbox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.bookIDLabel);
            this.Name = "Role";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookIDLabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox bookIDTextbox;
        private System.Windows.Forms.TextBox bookNameTextbox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView roleDataGridView;
        private System.Windows.Forms.ComboBox statusCombobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_Status;
        private System.Windows.Forms.Label rowCountLabel;
    }
}