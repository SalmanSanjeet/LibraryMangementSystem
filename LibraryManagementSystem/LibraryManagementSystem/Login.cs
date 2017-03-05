using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
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
            LMS objLMS = new LMS();
            objLMS.Show();
            Hide();
        }
    }
}
