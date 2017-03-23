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
        //private DAL.Role dalRole = new DAL.Role();

        public Role()
        {
            InitializeComponent();
        }

        private void resetInputUI()
        {
            bookIDTextbox.Clear();
            bookNameTextbox.Clear();
            statusCombobox.SelectedIndex = -1;

            bookIDTextbox.Text = bllRole.getNewRoleID();
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
                bllRole.AddRecords(bookIDTextbox.Text, bookNameTextbox.Text, statusCombobox.Text);
            }
            else
            {
                MessageBox.Show("Please check all the fields!");
            }

            MessageBox.Show("Record inserted successfully!");

            resetInputUI();
            ViewGrid();
        }

        //private void executeSQL(string cmd)
        //{
        //    if(validate())
        //    {
        //        dalRole.executeSQLCommand(cmd);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please check all the fields!");
        //    }
        //}

        private void ViewGrid()
        {
            DataTable roleTable = bllRole.getRoleTable();

            roleDataGridView.Rows.Clear();

            foreach(DataRow item in roleTable.Rows)
            {
                int n = roleDataGridView.Rows.Add();
                roleDataGridView.Rows[n].Cells[0].Value = (n + 1).ToString();
                roleDataGridView.Rows[n].Cells[1].Value = item["Role_ID"].ToString();
                roleDataGridView.Rows[n].Cells[2].Value = item["Role"].ToString();
                roleDataGridView.Rows[n].Cells[3].Value = item["Role_Status"].ToString();
            }

            rowCountLabel.Text = "Row Count: " + roleTable.Rows.Count.ToString();
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
            string updateCMD = "update lmsdb.role_master " +
                    "set role = '" + bookNameTextbox.Text + "', " +
                    "role_status = '" + statusCombobox.Text + "' " +
                    "where role_id = '" + bookIDTextbox.Text + "'";

            if (validate())
            {
                bllRole.executeSQL(updateCMD);
            }
            else
            {
                MessageBox.Show("Please check all the fields!");
            }
            
            ViewGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string deleteCMD = "delete from lmsdb.role_master " +
                        "where role_id = '" + bookIDTextbox.Text + "'";

            if (validate())
            {
                bllRole.executeSQL(deleteCMD);
            }
            else
            {
                MessageBox.Show("Please check all the fields!");
            }
            
            ViewGrid();
        }

        private bool validate()
        {
            bool res = true;

            if(0 == bookNameTextbox.Text.Length)
            {
                res = false;
            } else if(-1 == statusCombobox.SelectedIndex)
            {
                res = false;
            }

            return res;
        }
    }
}








