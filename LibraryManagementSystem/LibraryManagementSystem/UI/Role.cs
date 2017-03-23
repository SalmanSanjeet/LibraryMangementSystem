using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class Role : Form
    {
        private BLL.Role bllRole = new BLL.Role();

        public Role()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            bool res = true;

            if (0 == bookNameTextbox.Text.Length)
            {
                res = false;
            }
            else if (-1 == statusCombobox.SelectedIndex)
            {
                res = false;
            }

            return res;
        }

        private void ViewGrid()
        {
            DataTable roleTable = bllRole.getRoleTable();

            roleDataGridView.Rows.Clear();

            foreach (DataRow item in roleTable.Rows)
            {
                int n = roleDataGridView.Rows.Add();
                roleDataGridView.Rows[n].Cells[0].Value = (n + 1).ToString();
                roleDataGridView.Rows[n].Cells[1].Value = item["Role_ID"].ToString();
                roleDataGridView.Rows[n].Cells[2].Value = item["Role"].ToString();
                roleDataGridView.Rows[n].Cells[3].Value = item["Role_Status"].ToString();
            }

            rowCountLabel.Text = "Row Count: " + roleTable.Rows.Count.ToString();
        }

        private void resetInputUI()
        {
            bookIDTextbox.Clear();
            bookNameTextbox.Clear();
            statusCombobox.SelectedIndex = -1;

            string newRoleProc = "Proc_New_Role";
            bookIDTextbox.Text = bllRole.executeStoreProc(newRoleProc);
            bookNameTextbox.Focus();  // Get ready for next typing
        }

        private void Role_Load(object sender, EventArgs e)
        {
            resetInputUI();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            resetInputUI();
            ViewGrid();
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                bllRole.saveData(bookIDTextbox.Text, bookNameTextbox.Text, statusCombobox.Text);
            }
            else
            {
                MessageBox.Show("Please check all the fields!");
            }

            MessageBox.Show("Record inserted successfully!");

            resetInputUI();
            ViewGrid();
        }

        private void roleDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = roleDataGridView.SelectedRows[0].Index;

            bookIDTextbox.Text = roleDataGridView.Rows[n].Cells[1].Value.ToString();
            bookNameTextbox.Text = roleDataGridView.Rows[n].Cells[2].Value.ToString();
            statusCombobox.Text = roleDataGridView.Rows[n].Cells[3].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                bllRole.updateData(bookIDTextbox.Text, bookNameTextbox.Text, statusCombobox.Text);
            }
            else
            {
                MessageBox.Show("Please check all the fields!");
            }
            
            ViewGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                bllRole.deleteData(bookIDTextbox.Text);
            }
            else
            {
                MessageBox.Show("Please check all the fields!");
            }
            
            ViewGrid();
        }
    }
}








