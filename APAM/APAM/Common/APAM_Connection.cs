using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
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

            using (DbConnection dbConnection = factory.CreateConnection())
            {
                dbConnection.ConnectionString = testConnectionString;
                dbConnection.Open();
            }

            using (SqlConnection sqlConnection = new SqlConnection(testConnectionString))
            {
                sqlConnection.Open();

                UserData.Login = login;
                UserData.Password = password;

                var roles = new List<string>();

                var sql = $"SELECT p.NAME FROM sys.database_role_members rm JOIN sys.database_principals p ON rm.role_principal_id = p.principal_id JOIN sys.database_principals m ON rm.member_principal_id = m.principal_id WHERE m.name = '{UserData.Login}'";
                using (SqlCommand command = new SqlCommand(sql, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(reader.GetString(0));
                        }
                    }
                }

                UserData.Roles = roles;
            }

            connectionSettings.ConnectionString = userConnectionString;
        }
    }
}
