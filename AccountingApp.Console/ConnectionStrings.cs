using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Core.Helpers
{
    public class ConnectionStrings
    {
        public static void PrepareConnectionString(string connectionStringName)
        {
            var connection = ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connection.ConnectionString.Contains("%"))
            {
                var ozyrysDbServer = ConfigurationManager.AppSettings["OzyrysDbServer"];
                var ozyrysDb = ConfigurationManager.AppSettings["OzyrysDb"];
                var ozyrysDbUserName = ConfigurationManager.AppSettings["OzyrysDbUserName"];
                var ozyrysDbPassword = base64Decode(ConfigurationManager.AppSettings["OzyrysDbPassword"]);

                var fi = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);

                fi.SetValue(connection, false);
                connection.ConnectionString =
                    connection.ConnectionString.Replace("%OzyrysDbServer%", ozyrysDbServer).Replace("%OzyrysDb%", ozyrysDb).Replace("%OzyrysDbUserName%", ozyrysDbUserName).Replace("%OzyrysDbPassword%", ozyrysDbPassword);
                fi.SetValue(connection, true);
            }
        }

        private static string base64Decode(string sData)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(sData);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);

                return result;
            }
            catch
            {
                throw new InvalidCastException("Error decoding DB password");
            }
        }
    }
}
