using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace serwis_komputerowy
{
    public partial class loginForm : Form
    {
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
             cmd.CommandText = "Select * from pracownicy where Login=@user and Hasło=@pass";
             cmd.Parameters.AddWithValue("@user", user);
             cmd.Parameters.AddWithValue("@pass", pass);
             cmd.Connection = poloczenieMySQL.polacz();
            MySqlDataReader login = cmd.ExecuteReader();
            
            if (login.Read())
            {
                this.Hide();
                Przyjmij_zgloszenie form = new Przyjmij_zgloszenie();
                    form.Show();
                
                
                
            }
            else
            {
                poloczenieMySQL.zamknij();
                MessageBox.Show("Nie można zalogować, błędne dane");
                return;
            }

        }
    }
}
