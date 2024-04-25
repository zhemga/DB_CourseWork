using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAM.Common
{
    public static class UserData
    {
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static List<string> Roles { get; set; }

        public static class APAM_ROLES
        {
            public static readonly string ADMIN = "db_admin";
            public static readonly string BOOKKEEPER = "db_bookkeeper";
        }

        //public static void CheckRole(APAM_DBEntities context)
        //{
        //    try
        //    {
        //        var Roles = context.Database
        //       .SqlQuery<string>($"SELECT p.NAME FROM sys.database_role_members rm JOIN sys.database_principals p ON rm.role_principal_id = p.principal_id JOIN sys.database_principals m ON rm.member_principal_id = m.principal_id WHERE m.name = '{Login}'").ToList();
        //    }
        //    catch (Exception)
        //    {
        //        Roles = null;
        //    }
        //}

        public static bool IsUserInRole(string roleName)
        {
            return Roles.Contains(roleName);
        }
        
        public static bool IsBookeeper()
        {
            return IsUserInRole(APAM_ROLES.BOOKKEEPER);
        }


    }
}
