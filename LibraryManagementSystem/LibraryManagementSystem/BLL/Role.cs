using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibraryManagementSystem.BLL
{
    class Role
    {
        private DAL.Role dalRole = new DAL.Role();
        
        // Provide SQL interface from business layer.
        public DataTable getRoleTable()
        {
            return dalRole.getRoleDatabaseTable();
        }

        // Provide SQL execution interface from business layer.
        public void executeSQL(string cmdStr)
        {
            dalRole.executeSQLCommand(cmdStr);
        }

        public void AddRecords(string roleID, string roleName, string roleStatus)
        {
            executeSQL("insert into lmsdb.role_master" +
                " (role_id " +
                ", role" +
                ", role_status)" +
                "values" +
                "('" + roleID + "', " +
                "'" + roleName + "', " +
                "'" + roleStatus + "')");
        }

        public void UpdateRecords(string roleID, string roleName, string roleStatus)
        {
            executeSQL("update lmsdb.role_master " +
                    "set role = '" + roleName + "', " +
                    "role_status = '" + roleStatus + "' " +
                    "where role_id = '" + roleID + "'");
        }

        public string getNewRoleID()
        {
            string newRoleProcSQLName = "Proc_New_Role";

            DataTableCollection dc = dalRole.executeStoredProc(newRoleProcSQLName);
            return dc[dc.Count - 1].Rows[0][0].ToString();
        }

    }
}
