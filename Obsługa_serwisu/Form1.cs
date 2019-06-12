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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Przyjmij_zgloszenie form = new Przyjmij_zgloszenie();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Przyjmij_zgloszenie form = new Przyjmij_zgloszenie();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dodajKlienta form = new dodajKlienta();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Przyjmij_zgloszenie form = new Przyjmij_zgloszenie();
            this.Hide();
            form.Show();
        }
    }
}
