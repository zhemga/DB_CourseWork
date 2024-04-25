using System;
using System.Configuration;
using System.Data.Common;
using System.Reflection;

namespace APAM.Common
{
    public static class APAM_Connection
    {
        public static void SetConnectionSettings(string login, string password)
        {
            ConnectionStringSettings connectionSettings = ConfigurationManager.ConnectionStrings["APAM_DBEntities"];
            var fi = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
            fi.SetValue(connectionSettings, false);
            var testConnectionString = $"data source=HOME-PC\\SQLEXPRESS;initial catalog=APAM_DB;persist security info=True;user id={login};password={password};MultipleActiveResultSets=True;App=EntityFramework";
            var userConnectionString = $"metadata=res://*/ModelAPAM.csdl|res://*/ModelAPAM.ssdl|res://*/ModelAPAM.msl;provider=System.Data.SqlClient;provider connection string=\"data source=HOME-PC\\SQLEXPRESS;initial catalog=APAM_DB;persist security info=True;user id={login};password={password};MultipleActiveResultSets=True;App=EntityFramework\"";

            string provider = "System.Data.SqlClient";
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection conn = factory.CreateConnection())
            {
                conn.ConnectionString = testConnectionString;
                conn.Open();
            }

            UserData.Login = login;
            UserData.Password = password;

            connectionSettings.ConnectionString = userConnectionString;
        }
    }
}
