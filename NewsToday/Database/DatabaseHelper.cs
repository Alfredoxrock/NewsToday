using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace NewsToday.Database
{
    public static class DatabaseHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;


        //Thid method establishes a connection between client and server.
        public static void EstablishConnection()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = HiddenDatabaseinfo.serverName;
                builder.UserID = HiddenDatabaseinfo.rootName;
                builder.Password = HiddenDatabaseinfo.password;
                builder.Database = HiddenDatabaseinfo.databaseName;
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());
                //System.Windows.Forms.MessageBox.Show("Connection succesful!", "Connection",MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Connection has failed. Check your internet access.");
            }
        }

    }
}
