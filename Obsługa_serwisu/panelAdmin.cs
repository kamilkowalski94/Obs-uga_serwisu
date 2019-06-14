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
using Microsoft.VisualBasic;

namespace Obsługa_serwisu
{
    public partial class panelAdmin : Form
    {
        public panelAdmin()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoloczenieMySQL polMySQL = new PoloczenieMySQL();
            MySqlConnection polaczenie = polMySQL.polacz();
            string komenda = "INSERT INTO " + "pracownicy" + "(haslo) "
            + "VALUES ('" +  textBoxPass.Text + "')  WHERE login = "+textBoxLogin.Text+";";
            MySqlCommand pytanie = new MySqlCommand(komenda, polaczenie);
            MySqlDataReader wynik;
            MessageBox.Show("Klient dodany");

            wynik = pytanie.ExecuteReader();
            polMySQL.zamknij();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dial = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?","Warning",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dial == DialogResult.Yes)
            {
                string input = Interaction.InputBox("Podaj hasło administratora", "Potwierdzenie usunięcia", "Default", -1, -1);
                if (input.ToString() == "admin")
                {
                    PoloczenieMySQL polMySQL = new PoloczenieMySQL();
                    MySqlConnection polaczenie = polMySQL.polacz();
                    string komenda = "DELETE FROM pracownicy WHERE login = '" + textBoxLoginDel.Text + "';";
                    MySqlCommand pytanie = new MySqlCommand(komenda, polaczenie);
                    MySqlDataReader wynik;
                    MessageBox.Show("Pracownik usunięty");

                    wynik = pytanie.ExecuteReader();
                    polMySQL.zamknij();
                    textBoxLoginDel.Text = "";
                }
                else
                    if (input.ToString() != "admin")
                {
                    MessageBox.Show("Błędne hasło");
                    string input1 = Interaction.InputBox("Podaj hasło administratora", "Potwierdzenie usunięcia", "Default", -1, -1);
                }
                }
            else
                if (dial == DialogResult.No)
            {
                return;
            }
            else
                if (dial == DialogResult.Cancel)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoloczenieMySQL polMySQL = new PoloczenieMySQL();
            MySqlConnection polaczenie = polMySQL.polacz();
            string komenda = "INSERT INTO " + "pracownicy" + "(Imie,Nazwisko,Adres,login,haslo) "
            + "VALUES ('" + textBoxNameAdd.Text + "', '" + textBoxSuAdd.Text + "','" 
            + textBoxAdrAdd.Text + "','" + textBox5LoginAdd.Text + "','"+textBoxPassAdd.Text+ "');" +
            " INSERT INTO " + "dzialy" + "(Nazwa_dzialu) " + "VALUES ('" + textBoxDzAdd.Text + "');";
          
            MySqlCommand pytanie = new MySqlCommand(komenda, polaczenie);
          
            MySqlDataReader wynik;
            

            wynik = pytanie.ExecuteReader();
        
            polMySQL.zamknij();
            MessageBox.Show("Klient dodany");
        }
    }
}
