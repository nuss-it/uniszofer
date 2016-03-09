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
                       String data_instalacji = lines[0];
                       String hash = lines[1];
                       String host = lines[2];
                       String port = lines[3];
                       String login = lines[4];
                       String haslo = lines[5];
                       String baza = lines[6];

                    txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Konfiguracja odczytana \r\n";
                    barPostep.Value = barPostep.Value + 1;

                    txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Dekompresja konfiguracji \r\n";
                    barPostep.Value = barPostep.Value + 1;
                    
                    


                }
                else
                {
                    txtPostep.Text = txtPostep.Text + "[" + DateTime.Now + "] - Brak pliku konfiguracyjnego !";
                    barPostep.Value = barPostep.Value + 1;
                    
                }

            }
            catch (Exception komunikat)
            {
                MessageBox.Show(komunikat.Message);
            }

        }
    }
}
