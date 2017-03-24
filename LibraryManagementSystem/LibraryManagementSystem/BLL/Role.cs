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

        private const string roleDB = "lmsdb.role_master";
        private const string roleDBID = "role_id";
        private const string roleDBName = "role";
        private const string roleDBStatus = "role_status";
        private const string newRoleProc = "Proc_New_Role";

        // Provide SQL interface from business layer.
        public DataTable getRoleTable()
        {
            return dalRole.getRoleDatabaseTable();
        }

        public bool saveData(string roleID, string roleName, string roleStatus)
        {
            string addCMD = "insert into " + roleDB +
                                    " (" + roleDBID + " " +
                                    ", " + roleDBName + "" +
                                    ", " + roleDBStatus + ")" +
                                    "values" +
                                    "('" + roleID + "', " +
                                    "'" + roleName + "', " +
                                    "'" + roleStatus + "')";
            return dalRole.executeSQLCommand(addCMD);
        }

        public bool updateData(string roleID, string roleName, string roleStatus)
        {
            string updateCMD = "update " + roleDB + " " +
                    "set " + roleDBName + " = '" + roleName + "', " +
                    "" + roleDBStatus + " = '" + roleStatus + "' " +
                    "where " + roleDBID + " = '" + roleID + "'";

            return dalRole.executeSQLCommand(updateCMD);
        }

        public bool deleteData(string roleID)
        {
            string deleteCMD = "delete from " + roleDB + " " +
                        "where " + roleDBID + " = '" + roleID + "'";

            return dalRole.executeSQLCommand(deleteCMD);
        }

        public string generateRoleID()
        {
            DataTableCollection newRoleProcRes = executeStoreProc(newRoleProc);

            // Choose the 2nd result table to generate new ID.
            return newRoleProcRes[newRoleProcRes.Count - 1].Rows[0][0].ToString();
        }
        
        private DataTableCollection executeStoreProc(string cmd)
        {
            return dalRole.executeStoredProc(cmd);
        }
    }
}
