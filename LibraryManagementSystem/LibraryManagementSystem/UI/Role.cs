using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.UI
{
    public partial class Role : Form
    {
        private BLL.Role bllRole = new BLL.Role();
        private DAL.Role dalRole = new DAL.Role();

        public Role()
        {
            InitializeComponent();
        }

        private void resetInputUI()
        {
            bookIDTextbox.Clear();
            bookNameTextbox.Clear();
            statusCombobox.SelectedIndex = -1;

            bookIDTextbox.Text = dalRole.getNewRoleID();  // Get new Role ID.
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
            AddRecords();
            MessageBox.Show("Record inserted successfully!");

            resetInputUI();
            ViewGrid();
        }

        private void cmdSQLExecutor(string cmdStr)
        {
            if(validate())
            {
                MySqlCommand cmd = new MySqlCommand(cmdStr, new DAL.Connection().ActiveCon());
                cmd.ExecuteNonQuery();
            } else
            {
                MessageBox.Show("Please check all the fields!");
            }
        }

        private void AddRecords()
        {
            cmdSQLExecutor("insert into lmsdb.role_master" +
            " (role_id " +
            ", role" +
            ", role_status)" +
            "values" +
            "('" + bookIDTextbox.Text + "', " +
            "'" + bookNameTextbox.Text + "', " +
            "'" + statusCombobox.Text + "')");
        }

        private void UpdateRecords()
        {
            cmdSQLExecutor("update lmsdb.role_master " + 
                "set role = '" + bookNameTextbox.Text +"', " + 
                "role_status = '" + statusCombobox.Text +"' " + 
                "where role_id = '" + bookIDTextbox.Text +"'");
        }

        private void DeleteRecords()
        {
            cmdSQLExecutor("delete from lmsdb.role_master " + 
                "where role_id = '" + bookIDTextbox.Text + "'");
        }

        private void ViewGrid()
        {
            DAL.Connection conn = new DAL.Connection();
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from role_master", conn.ActiveCon());
            DataTable dt = new DataTable();
            mda.Fill(dt);
            roleDataGridView.Rows.Clear();
            foreach(DataRow item in dt.Rows)
            {
                int n = roleDataGridView.Rows.Add();
                roleDataGridView.Rows[n].Cells[0].Value = (n + 1).ToString();
                roleDataGridView.Rows[n].Cells[1].Value = item["Role_ID"].ToString();
                roleDataGridView.Rows[n].Cells[2].Value = item["Role"].ToString();
                roleDataGridView.Rows[n].Cells[3].Value = item["Role_Status"].ToString();
            }

            rowCountLabel.Text = "Row Count: " + dt.Rows.Count.ToString();
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
            UpdateRecords();
            ViewGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteRecords();
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








