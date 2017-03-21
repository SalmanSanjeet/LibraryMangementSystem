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

namespace LibraryManagementSystem
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void Role_Load(object sender, EventArgs e)
        {
            CreateNew();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }

        private void initializeNewInput()
        {
            bookIDTextbox.Clear();
            bookNameTextbox.Clear();
            statusCombobox.SelectedIndex = -1;
        }

        private void CreateNew()
        {
            initializeNewInput();
            Connection conn = new Connection();
            MySqlDataAdapter mda = new MySqlDataAdapter("Proc_New_Role", conn.ActiveCon());
            mda.SelectCommand.CommandType = CommandType.StoredProcedure;

            // Handle multiple sql resutls
            DataSet ds = new DataSet();
            mda.Fill(ds);
            DataTableCollection dc = ds.Tables;
            bookIDTextbox.Text = dc[dc.Count - 1].Rows[0][0].ToString();
            
            // Get ready for next typing
            bookNameTextbox.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddRecords();
            MessageBox.Show("Record inserted successfully!");
            CreateNew();
            ViewGrid();
        }

        private void cmdSQLExecutor(string cmdStr)
        {
            Connection conn = new Connection();
            MySqlCommand cmd = new MySqlCommand(cmdStr, conn.ActiveCon());
            cmd.ExecuteNonQuery();
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

        private void ViewGrid()
        {
            Connection conn = new Connection();
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
    }
}








