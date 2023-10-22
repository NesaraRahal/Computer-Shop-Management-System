using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIBM_GUI_Project.Properties
{
    internal class cls_connection
    {
        public static MySqlConnection connectDB()
        {
            string connection = @"server = localhost ; userid = root; password= Rahal@2005; database = ComputerShop";
            MySqlConnection conn = new MySqlConnection(connection);
            return conn;
        }
    }
}
