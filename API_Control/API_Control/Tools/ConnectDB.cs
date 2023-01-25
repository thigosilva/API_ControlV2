using API_Control.POCO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Control.Tools
{

    public class ConnectDB
    {
        public string StringConnect()
        {
            string mySqlConnStr = string.Empty;
            try
            {
                string oJsonConfig = System.IO.File.ReadAllText(@"appsettings.json");
                StruConfig oStrincConnect = JsonConvert.DeserializeObject<StruConfig>(oJsonConfig);

                mySqlConnStr = $"Data Source={oStrincConnect.ConnectionStrings.MYSQL_DBHOST};" +
                    $" Initial Catalog={oStrincConnect.ConnectionStrings.MYSQL_DATABASE};" +
                    $"User ID={oStrincConnect.ConnectionStrings.MYSQL_USER};" +
                    $"Password={oStrincConnect.ConnectionStrings.MYSQL_PASSWORD}";
            }
            catch (Exception)
            {
                throw;
            }
            return mySqlConnStr;
        }
    }
}
