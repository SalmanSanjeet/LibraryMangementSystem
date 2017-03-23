using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.DAL
{
    class Role
    {
        //public MySqlDataAdapter ActiveMDA(string selectCmdText)
        //{
        //    return new MySqlDataAdapter(selectCmdText, new Connection().ActiveCon());
        //}
        private const string newRoleProcName = "Proc_New_Role";
        public string getNewRoleID()
        {            
            MySqlDataAdapter mda = new Connection().ActiveMDA(newRoleProcName);
            mda.SelectCommand.CommandType = CommandType.StoredProcedure;

            // Handle multiple sql resutls
            DataSet ds = new DataSet();
            mda.Fill(ds);
            DataTableCollection dc = ds.Tables;
            return dc[dc.Count - 1].Rows[0][0].ToString();
        }
    }
}
