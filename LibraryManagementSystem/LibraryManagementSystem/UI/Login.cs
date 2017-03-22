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
using LibraryManagementSystem.DAL;

namespace LibraryManagementSystem.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dRes = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(DialogResult.Yes == dRes)
            {
                Close();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * From Profile_Master Where Pro_User_Id='" + usernameTextbox.Text + "' and Pro_Password='" + passwordTextbox.Text + "'", con.ActiveCon());
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(1 == dt.Rows.Count)
            {
                LMS objLMS = new LMS();
                objLMS.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
