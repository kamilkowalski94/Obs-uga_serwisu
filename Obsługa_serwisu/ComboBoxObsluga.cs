using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace serwis_komputerowy
{
    class ComboBoxObsluga
    {
        public List<string> wczytajComboBoxZTabeli(string nazwaTab, string nazwaPola, string nazwaPolaID, ComboBox nazwaComboBoxa)
        {
            nazwaComboBoxa.Items.Clear();
            List<string> zawartoscWczytajListyIDzTabeli = new List<string>();
            PoloczenieMySQL polMySQL = new PoloczenieMySQL();
            MySqlConnection polaczenie = polMySQL.polacz();

            MySqlDataReader kursor;
            string komenda = "SELECT " + nazwaPola + ", " + nazwaPolaID + " FROM " + nazwaTab + ";";
            MySqlCommand pytanie = new MySqlCommand(komenda, polaczenie);
            kursor = pytanie.ExecuteReader();
            while (kursor.Read())
            {
                zawartoscWczytajListyIDzTabeli.Add(kursor.GetString(1));
                nazwaComboBoxa.Items.Add(kursor.GetString(0));
            }
            polMySQL.zamknij();
            return zawartoscWczytajListyIDzTabeli;
        }
    }
}
