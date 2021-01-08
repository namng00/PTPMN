using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppSoundN.DatabaseApp
{
    class ConnectStatus
    {
        public static void OpenConnect()
        {
            try {
                if(Database.connect.State==System.Data.ConnectionState.Closed)
                {
                    Database.connect.ConnectionString = Database.GetConnection();
                    Database.connect.Open();
                    
                }

            }
            catch(Exception e)
            {
                MessageBox.Show("Con");
            }
        }
        public static void CloseConnect()
        {
            try
            {
                if (Database.connect.State == System.Data.ConnectionState.Open)
                {
                    Database.connect.ConnectionString = Database.GetConnection();
                    Database.connect.Close();
                    
                }

            }
            catch (Exception e)
            {
                
            }
        }
    }
}
