using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace HomeFirtAidKit
{
    class ConnectionDB
    {
        public static MySqlConnection connection;

        public static void Connect()
        {
            string server = "localhost";
            string database = "homefirstaidkit";
            string uid = "root";
            string password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "port=3306;";

            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        public static void Insert(string sql)
        {
            MySqlCommand msc = new MySqlCommand(sql,connection);
            msc.ExecuteNonQuery();
        }
        public static void Update(string sql) // пока просто так ))
        {
            MySqlCommand msc = new MySqlCommand(sql, connection);
            msc.ExecuteNonQuery();
        }
        public static void Close()
        {
            connection.Close();
        }
    }
}
