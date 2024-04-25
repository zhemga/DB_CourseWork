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
        public static bool IsAdmin { get { return IsUserInRole(APAM_ROLES.ADMIN); } }
        public static bool IsBookkeeper { get { return IsUserInRole(APAM_ROLES.BOOKKEEPER); } }
        public static bool IsManager { get { return IsUserInRole(APAM_ROLES.MANAGER); } }

        public static class APAM_ROLES
        {
            public static readonly string ADMIN = "db_admin";
            public static readonly string BOOKKEEPER = "db_bookkeeper";
            public static readonly string MANAGER = "db_manager";
        }

        public static bool IsUserInRole(string roleName)
        {
            return Roles.Contains(roleName);
        }


    }
}
