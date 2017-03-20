using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    class Connection
    {
        MySqlConnection msc = new MySqlConnection();

        private void initializeDatabase()
        {
            string serverStr = "localhost";
            string uidStr = "root";
            string pwdStr = "toor";
            string databaseStr = "lmsdb";

            msc.ConnectionString = "server=" + serverStr + ";" +
                                   "uid=" + uidStr + ";" +
                                   "pwd=" + pwdStr + ";" +
                                   "database=" + databaseStr + ";";
        }

        public Connection()
        {
            initializeDatabase();
        }

        public MySqlConnection ActiveCon()
        {
            if(msc.State == System.Data.ConnectionState.Closed)
            {
                msc.Open();
            }

            return msc;
        }
    }
}
