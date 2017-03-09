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
    public partial class Login : Form
    {
        MySqlConnection msc = new MySqlConnection();
        public Login()
        {
            InitializeComponent();

            string serverStr = "localhost";
            string uidStr = "root";
            string pwdStr = "toor";
            string databaseStr = "lmsdb";

            msc.ConnectionString = "server=" + serverStr + ";" + 
                                   "uid=" + uidStr + ";" + 
                                   "pwd=" + pwdStr + ";" + 
                                   "database=" + databaseStr + ";";
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
            MySqlDataAdapter sda = new MySqlDataAdapter("Select Pro_User_ID, Pro_Password from Profile_Master Where Pro_User_Id=" + usernameTextbox.Text + "", msc);
            LMS objLMS = new LMS();
            objLMS.Show();
            Hide();
        }
    }
}
