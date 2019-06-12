using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Obsługa_serwisu;

namespace serwis_komputerowy
{
    public partial class loginForm : Form
    {  int tryCount = 0;
        public loginForm()
        {
            InitializeComponent();
          
        }
      

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            
            string pass = textBoxHasło.Text;
            string user = textBoxLogin.Text;
            PoloczenieMySQL poloczenieMySQL = new PoloczenieMySQL();
          
            MySqlConnection polaczenie = poloczenieMySQL.polacz();
             MySqlCommand cmd = new MySqlCommand();
             cmd.CommandText = "Select * from pracownicy where login=@user and haslo=@pass";
             cmd.Parameters.AddWithValue("@user", user);
             cmd.Parameters.AddWithValue("@pass", pass);
             cmd.Connection = poloczenieMySQL.polacz();
            MySqlDataReader login = cmd.ExecuteReader();
            
            if (login.Read())
            {
                tryCount = 0;
                this.Hide();
                //Przyjmij_zgloszenie form = new Przyjmij_zgloszenie();
                Form1 form = new Form1();
                form.Show();
                
                
            }
            else
            {
                poloczenieMySQL.zamknij();
                MessageBox.Show("Nie można zalogować, błędne dane");
                tryCount++;
                if (tryCount >= 3)
                {
                    MessageBox.Show("Twoje konto zostąło zablokowane, skontaktuj się z Administratorem");
                    buttonZaloguj.Hide();
                    
                }
                return;
            }

        }
    }
}
