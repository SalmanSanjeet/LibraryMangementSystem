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

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            bookIDTextbox.Clear();
            bookNameTextbox.Clear();
            statusCombobox.SelectedIndex = -1;
            bookNameTextbox.Focus();
            CreateNew();
        }

        private void CreateNew()
        {
            Connection conn = new Connection();
            MySqlDataAdapter mda = new MySqlDataAdapter("Proc_New_Role", conn.ActiveCon());
            mda.SelectCommand.CommandType = CommandType.StoredProcedure;

            // Handle multiple sql resutls
            DataSet ds = new DataSet();
            mda.Fill(ds);
            DataTableCollection dc = ds.Tables;
            bookIDTextbox.Text = dc[dc.Count - 1].Rows[0][0].ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void AddRecord()
        {
            Connection conn = new Connection();
            MySqlCommand cmd = new MySqlCommand(@"insert into lmsdb.role_master
            (role_id
            ,role
            ,role_status)
            values
            ('" + bookIDTextbox.Text +"', " + 
            "'" + bookNameTextbox.Text + "', " + 
            "'" + statusCombobox.Text + "')", conn.ActiveCon());
            cmd.ExecuteNonQuery();
        }
    }
}
