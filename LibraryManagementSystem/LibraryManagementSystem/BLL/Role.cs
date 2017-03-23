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

        public void AddRecords(string roleID, string roleName, string roleStatus)
        {
            dalRole.cmdSQLExecutor("insert into lmsdb.role_master" +
                " (role_id " +
                ", role" +
                ", role_status)" +
                "values" +
                "('" + roleID + "', " +
                "'" + roleName + "', " +
                "'" + roleStatus + "')");
        }

        public string getNewRoleID()
        {
            string newRoleProcSQLName = "Proc_New_Role";

            DataTableCollection dc = dalRole.executeStoredProc(newRoleProcSQLName);
            return dc[dc.Count - 1].Rows[0][0].ToString();
        }
    }
}
