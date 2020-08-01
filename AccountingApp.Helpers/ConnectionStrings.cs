using System;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace AccountingApp.Helpers
{
    public class ConnectionStrings
    {
        public static void PrepareConnectionString(string connectionStringName)
        {
            var connectionSettings = ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionSettings.ConnectionString.Contains("%"))
            {
                var ServerName = ConfigurationManager.AppSettings["ServerName"];
                var DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
                var UserName = ConfigurationManager.AppSettings["UserName"];
                var Password = ConfigurationManager.AppSettings["Password"];

                var fi = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);

                fi.SetValue(connectionSettings, false);
                connectionSettings.ConnectionString =
                    connectionSettings.ConnectionString
                    .Replace("%ServerName%", ServerName)
                    .Replace("%DatabaseName%", DatabaseName)
                    .Replace("%UserName%", UserName)
                    .Replace("%Password%", Password);
                fi.SetValue(connectionSettings, true);
            }
        }
    }
}

