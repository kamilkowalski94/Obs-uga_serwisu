using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace serwis_komputerowy
{
    
    class PoloczenieMySQL
    {
        public MySqlConnection polaczenie;
        public static string strPolacz = "server=localhost;user=root;database=serwis;DefaultTableCacheAge=30;charset=utf8";//;password=kamilek19Z46";
        public MySqlConnection polacz()
        {
            
            polaczenie = new MySqlConnection(strPolacz);
            try
            {
                  polaczenie.Open();
              //  MessageBox.Show("baza otwarta");
            }
            catch (Exception e)
            {
                MessageBox.Show("Problemy z połączeniem do bazy danych. \n" + e.Message);
            }
            return polaczenie;
        }
        public void zamknij()
        {
            polaczenie.Close();
        }
    }
}
        