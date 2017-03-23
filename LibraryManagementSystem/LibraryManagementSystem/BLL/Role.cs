using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.BLL
{
    class Role
    {
        DAL.Role dalRole = new DAL.Role();

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
    }
}
