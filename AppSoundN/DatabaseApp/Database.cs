using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppSoundN.DatabaseApp
{
    class Database
    {
        private static string Connection = "Data Source=(local);Initial Catalog=SoundShop;Integrated Security=True";
        public static string GetConnection() { return Connection; }

        public static string sqlQuery;
        public static SqlConnection connect = new SqlConnection();

        public static SqlCommand command = new SqlCommand("",connect);
        public static SqlDataReader reader;

       



    }
}
