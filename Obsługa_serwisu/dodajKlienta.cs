using MySql.Data.MySqlClient;
using serwis_komputerowy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obsługa_serwisu
{
   
    public partial class dodajKlienta : Form
    {
        public dodajKlienta()
        {
            InitializeComponent();
            comboBoxKlient.Items.Add("Klient indywidualnt");
            comboBoxKlient.Items.Add("Firma");
        }

        
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (comboBoxKlient.Text.Equals("Firma"))
            {
                PoloczenieMySQL polMySQL = new PoloczenieMySQL();
                MySqlConnection polaczenie = polMySQL.polacz();
                string komenda = "INSERT INTO " + "klienci" + "(Imie,Nazwisko,Fram,NIP) "
                + "VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                MySqlCommand pytanie = new MySqlCommand(komenda, polaczenie);
                MySqlDataReader wynik;
                MessageBox.Show("Klient dodany");
            
                wynik = pytanie.ExecuteReader();
                polMySQL.zamknij();

                textBox1.Text.Equals("");
                textBox2.Text.Equals("");
                textBox3.Text.Equals("");
                textBox4.Text.Equals("");
            }
            else
                if (comboBoxKlient.Text.Equals("Klient indywidualny"))
            {
                PoloczenieMySQL polMySQL = new PoloczenieMySQL();
                MySqlConnection polaczenie = polMySQL.polacz();
                string komenda = "INSERT INTO " + "klienci" + "(Imie,Nazwisko,Fram,NIP) "
                + "VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                MySqlCommand pytanie = new MySqlCommand(komenda, polaczenie);
                MySqlDataReader wynik;
                MessageBox.Show("Klient dodany");
         

                wynik = pytanie.ExecuteReader();
                polMySQL.zamknij();
                textBox1.Text.Equals("");
                textBox2.Text.Equals("");
                textBox3.Text.Equals("");
                textBox4.Text.Equals("");
            }

            /* PoloczenieMySQL polMySQL = new PoloczenieMySQL();
             MySqlConnection polaczenie = polMySQL.polacz();
             string komenda = "INSERT INTO " + "klienci" + "(idPracownika,idKlienta,idDzialu,Opis_Zgloszenia,tematZgloszenia) "
             + "VALUES ('" + comboBox2.Text + "', '" + comboBox3.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "');";
             MySqlCommand pytanie = new MySqlCommand(komenda, polaczenie);
             MySqlDataReader wynik;
             wynik = pytanie.ExecuteReader();
             polMySQL.zamknij();
             this.Hide();*/
        }
           
        
    }
}
