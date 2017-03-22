using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.DAL
{
    class Role
    {
        public MySqlDataAdapter ActiveMDA(string selectCmdText)
        {
            return new MySqlDataAdapter(selectCmdText, new Connection().ActiveCon());
        }
    }
}
