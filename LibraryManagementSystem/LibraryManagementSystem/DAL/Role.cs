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

        private Connection conn = new Connection();
        private const string newRoleProcName = "Proc_New_Role";

        public DataTableCollection executeStoredProc(string storedProc)
        {
            MySqlDataAdapter mda = new MySqlDataAdapter(storedProc, conn.ActiveCon());
            mda.SelectCommand.CommandType = CommandType.StoredProcedure;

            // Handle multiple sql resutls
            DataSet ds = new DataSet();
            mda.Fill(ds);
            DataTableCollection dc = ds.Tables;
            return dc;
        }

        public void cmdSQLExecutor(string cmdStr)
        {
            MySqlCommand cmd = new MySqlCommand(cmdStr, conn.ActiveCon());
            cmd.ExecuteNonQuery();
        }

        public DataTable getRoleDatabaseTable()
        {
            string getRoleTableSQL = "select * from role_master";
            MySqlDataAdapter mda = new MySqlDataAdapter(getRoleTableSQL, conn.ActiveCon());

            DataTable dt = new DataTable();
            mda.Fill(dt);
            
            return dt;
        }
    }
}
