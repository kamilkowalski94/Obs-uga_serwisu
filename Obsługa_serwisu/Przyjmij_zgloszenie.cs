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
    public partial class Przyjmij_zgloszenie : Form
    {
        public Przyjmij_zgloszenie()
        {
            InitializeComponent();
        }
        ComboBoxObsluga comboBoxObsluga = new ComboBoxObsluga();
        List<string> IDzTabeli = new List<string>();
        List<string> IDzTabeli2 = new List<string>();
        List<string> IDzTabeli3 = new List<string>();


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String wybraneID = "";
            wybraneID = IDzTabeli[comboBox1.SelectedIndex];
          
        }

        private void Przyjmij_zgloszenie_Load(object sender, EventArgs e)
        {
            IDzTabeli = comboBoxObsluga.wczytajComboBoxZTabeli("dzialy", "Nazwa_działu", "id", comboBox1);
            IDzTabeli3 = comboBoxObsluga.wczytajComboBoxZTabeli("klienci", "Firma", "id", comboBox3);
            IDzTabeli2 = comboBoxObsluga.wczytajComboBoxZTabeli("pracownicy", "Login", "id", comboBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoloczenieMySQL polMySQL = new PoloczenieMySQL();
            MySqlConnection polaczenie = polMySQL.polacz();
            string komenda = "INSERT INTO " + "przyjmij_zgloszenie" + "(id_praconik,id_klienta,id_działu,treść_zgłoszenia,temat_zgłoszenia) " 
            + "VALUES ('" + comboBox2.Text +"', '" +comboBox3.Text+"','" +comboBox1.Text+"','" +textBox2.Text+"','" +textBox1.Text+"');";
            MySqlCommand pytanie = new MySqlCommand(komenda, polaczenie);
            MySqlDataReader wynik;
            wynik = pytanie.ExecuteReader();
            polMySQL.zamknij();
            this.Hide();
            this.Hide();
            Przyjmij_zgloszenie form = new Przyjmij_zgloszenie();
            form.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String wybraneID = "";
            wybraneID = IDzTabeli3[comboBox3.SelectedIndex];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String wybraneID = "";
            wybraneID = IDzTabeli2[comboBox2.SelectedIndex];
        }
    }
}
