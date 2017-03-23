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

        public bool saveData(string roleID, string roleName, string roleStatus)
        {
            string addCMD = "insert into lmsdb.role_master" +
                                    " (role_id " +
                                    ", role" +
                                    ", role_status)" +
                                    "values" +
                                    "('" + roleID + "', " +
                                    "'" + roleName + "', " +
                                    "'" + roleStatus + "')";
            return dalRole.executeSQLCommand(addCMD);
        }

        public bool updateData(string roleID, string roleName, string roleStatus)
        {
            string updateCMD = "update lmsdb.role_master " +
                    "set role = '" + roleName + "', " +
                    "role_status = '" + roleStatus + "' " +
                    "where role_id = '" + roleID + "'";

            return dalRole.executeSQLCommand(updateCMD);
        }

        public bool deleteData(string roleID)
        {
            string deleteCMD = "delete from lmsdb.role_master " +
                        "where role_id = '" + roleID + "'";

            return dalRole.executeSQLCommand(deleteCMD);
        }

        // [[[[Need to be modified.]]]]
        public string executeStoreProc(string cmd)
        {
            DataTableCollection dc = dalRole.executeStoredProc(cmd);
            return dc[dc.Count - 1].Rows[0][0].ToString();
        }
    }
}
