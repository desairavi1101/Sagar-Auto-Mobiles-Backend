using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Sagar_Auto_Mobiles_API.Utility
{
    public class DBHelper
    {
        private static MySqlConnection _connection;

        public static MySqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["SagarAutoParts"].ConnectionString);
                }
                return _connection;
            }
        }
        
        public static DataTable ExecuteSelect(string selectQuery)
        {
            MySqlCommand cmd = new MySqlCommand(selectQuery,Connection);
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }

            return ds.Tables[0];

        }


    }
}