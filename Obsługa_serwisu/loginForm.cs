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
using System.Net.Mail;

namespace serwis_komputerowy
{
    public partial class loginForm : Form
    {  int tryCount = 0;
        public loginForm()
        {
            InitializeComponent();
            buttonPassReset.Hide();
        }



        private void sendEmail()
        {
          
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("pracownik1repair@gmail.com");//od kogo
            mailMessage.To.Add("tomaszrosa12345@gmail.com");
            mailMessage.Subject = "Reset hasła";
            mailMessage.Body = "Proszę o reset hasła dla użytkownika: " + textBoxLogin.Text;
            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("pracownik1repair@gmail.com", "");//hasło odane bezpośrednio w kodzie
            smtpClient.Send(mailMessage);
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
            if (textBoxLogin.Text == "admin" & textBoxHasło.Text == "admin")
            {
                this.Hide();
                panelAdmin form = new panelAdmin();
                form.Show();
            }
            else
            if (login.Read())
            {
                tryCount = 0;
                this.Hide();
               
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
                    MessageBox.Show("Twoje konto zostąło zablokowane, skontaktuj się z Administratorem.");
                    
                    buttonZaloguj.Hide();
                    buttonPassReset.Show();
                    
                }
                return;
            }

        }

        private void buttonPassReset_Click(object sender, EventArgs e)
        {
            sendEmail();
            MessageBox.Show("Prośba o reset hasła wysłana");
        }
    }
}
