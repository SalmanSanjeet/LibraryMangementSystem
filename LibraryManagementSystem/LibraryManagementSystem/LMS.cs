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
    public partial class LMS : Form
    {
        public LMS()
        {
            InitializeComponent();
        }

        private void LMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role obj = new Role();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile_Master pmObj = new Profile_Master();
            pmObj.MdiParent = this;
            pmObj.StartPosition = FormStartPosition.CenterScreen;
            pmObj.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Master mmObj = new Member_Master();
            mmObj.MdiParent = this;
            mmObj.StartPosition = FormStartPosition.CenterScreen;
            mmObj.Show();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan pObj = new Plan();
            pObj.MdiParent = this;
            pObj.StartPosition = FormStartPosition.CenterScreen;
            pObj.Show();
        }
    }
}
