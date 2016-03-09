using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Uniszofer
{
    public partial class Konfiguracja : Form
    {
        public Konfiguracja()
        {
            InitializeComponent();            
        }

        private void Konfiguracja_Load(object sender, EventArgs e)
        {
            Klasa.Glowny = new Glowny();
            Klasa.Logowanie = new Logowanie();

              txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Uruchomienie programu \r\n";
              barPostep.Value = barPostep.Value + 1;

            try
            {
                txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Wyszukiwanie pliku konfiguracyjnego \r\n";
                  barPostep.Value = barPostep.Value + 1;
                if (File.Exists(@"config.txt"))
                {
                     txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Znaleziono plik konfiguracyjny \r\n";
                      barPostep.Value = barPostep.Value + 1;

                     txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Otwieram konfigurację \r\n";
                      barPostep.Value = barPostep.Value + 1;

                    string[] lines = System.IO.File.ReadAllLines(@"config.txt");
                       String host = lines[2];
                       String port = lines[3];
                       String login = lines[4];
                       String haslo = lines[5];
                       String baza = lines[6];
                       String hash2 = lines[0] +"-"+ lines[1] +"-"+ lines[0];

                    txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Konfiguracja odczytana \r\n";
                      barPostep.Value = barPostep.Value + 1;

                    host = Klasa.Decrypt(host, hash2);
                    port = Klasa.Decrypt(port, hash2);
                    login = Klasa.Decrypt(login, hash2);
                    haslo = Klasa.Decrypt(haslo, hash2);
                    baza = Klasa.Decrypt(baza, hash2);

                    txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Test konfiguracji \r\n";
                    barPostep.Value = barPostep.Value + 1;

                    string konfiguracjaSQL = "datasource=" + host + "; port=" + port + "; username=" + login + "; password=" + haslo + "; database = " + baza;

                    //testujemy czy istnieje cokolwiek w bazie ( przy okazji testujemy poprawnosc polaczenia do bazy danych
                    MySqlConnection laczBaze = new MySqlConnection(konfiguracjaSQL);
                    MySqlCommand zapytanie = new MySqlCommand("SELECT id FROM uzytkownicy LIMIT 1", laczBaze);
                    MySqlDataReader odczytanie;
                    try
                    {
                        txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Test połączenia z bazą ! \r\n";

                        laczBaze.Open();
                        odczytanie = zapytanie.ExecuteReader();
                        btnZapisz.Enabled = true;
                        txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Połączenie z bazą OK ! \r\n";
                        barPostep.Value = 15;
                        hiden();
                        Klasa.Logowanie.Show();
                    }
                    catch (Exception komunikat)
                    {
                        MessageBox.Show(komunikat.Message);
                        txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Błąd (" + komunikat.Message + ") \r\n";
                    }
                    laczBaze.Close();
                }
                else
                {
                    txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Brak pliku konfiguracyjnego ! \r\n";
                      barPostep.Value = barPostep.Value + 1;
                    boxKonfiguracja.Visible = true;
                }

            }
            catch (Exception komunikat)
            {
                MessageBox.Show(komunikat.Message);
                 txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Błąd (" + komunikat.Message + ") \r\n";
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            btnZapisz.Enabled = false;
            if (txtBaza.Text!="" && txtHost.Text!="" && txtLogin.Text != "" && txtPort.Text != "")
            {
                string konfiguracjaSQL = "datasource=" + txtHost.Text + "; port=" + txtPort.Text + "; username=" + txtLogin.Text + "; password=" + txtHaslo.Text + "; database = " + txtBaza.Text;

                //testujemy czy istnieje cokolwiek w bazie ( przy okazji testujemy poprawnosc polaczenia do bazy danych
                MySqlConnection laczBaze = new MySqlConnection(konfiguracjaSQL);
                MySqlCommand zapytanie = new MySqlCommand("SELECT id FROM uzytkownicy LIMIT 1", laczBaze);
                MySqlDataReader odczytanie;
                try
                {
                    txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Test połączenia z bazą ! \r\n";

                    laczBaze.Open();
                    odczytanie = zapytanie.ExecuteReader();
                    btnZapisz.Enabled = true;
                     txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Połączenie z bazą OK ! \r\n";
                     barPostep.Value = barPostep.Value + 1;
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                    txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Błąd ("+komunikat.Message+") \r\n";
                    
                }
                laczBaze.Close();

            } else
            {
                MessageBox.Show("Wypełnij pola formularza !");
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try {
                txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Rozpoczęcie konfiguracyjnego ! \r\n";
                barPostep.Value = barPostep.Value + 1;
                String data = Convert.ToString(DateTime.Now);
                String hash = Klasa.RandomString(25);
                String host = txtHost.Text;
                String port = txtPort.Text;
                String login = txtLogin.Text;
                String haslo = txtHaslo.Text;
                String baza = txtBaza.Text;
                String hash2 = data + "-" + hash + "-" + data;
                host = Klasa.Encrypt(host, hash2);
                port = Klasa.Encrypt(port, hash2);
                login = Klasa.Encrypt(login, hash2);
                haslo = Klasa.Encrypt(haslo, hash2);
                baza = Klasa.Encrypt(baza, hash2);

                string[] lines = { data, hash, host, port, login, haslo, baza};
                System.IO.File.WriteAllLines(@"config.txt", lines);


                 txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Plik konfiguracyjny zapisany ! \r\n";
                  barPostep.Value = 15;
                hiden();
                Klasa.Logowanie.Show();

            }
            catch (Exception komunikat)
            {
                MessageBox.Show(komunikat.Message);
                txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Błąd (" + komunikat.Message + ") \r\n";

            }
        }

        private void barPostep_Click(object sender, EventArgs e)
        {
            boxKonfiguracja.Visible = !boxKonfiguracja.Visible;
        }

        public void hiden()
        {
            this.Hide();
            this.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (barPostep.Value==15)
            {
                this.Hide();
                timer.Enabled = false;
            }
        }
    }
}
