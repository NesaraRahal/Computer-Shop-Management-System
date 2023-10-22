using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIBM_GUI_Project.Resources
{
    internal class cls_connection
    {
        const string cs = @"server=localhost;userid=root;password=;database=computer_shop_management_system;";
        public static MySqlConnection con = new MySqlConnection(cs);
        internal static MySqlConnection connectDB;

        public static void Open_connection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
        }

        public static void Close_connection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
