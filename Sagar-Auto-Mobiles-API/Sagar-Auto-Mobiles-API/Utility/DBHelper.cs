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

        private static void OpenConnection()
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        private static void CloseConnection()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public static DataTable ExecuteSelect(string selectQuery)
        {
            MySqlCommand cmd = new MySqlCommand(selectQuery,Connection);
            OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            CloseConnection();
            return ds.Tables[0];
        }

        public static object ExecuteScaler(string selectQuery)
        {
            MySqlCommand cmd = new MySqlCommand(selectQuery, Connection);
            OpenConnection();
            object obj = cmd.ExecuteScalar();
            CloseConnection();
            return obj;
        }


    }
}