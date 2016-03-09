using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uniszofer
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klasa.Glowny.Show();
            this.Hide();
        }

        private void Logowanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            int blad = 0;
            if (blad == 0 && txtLogin.Text== "") { MessageBox.Show("Podaj Login"); blad++;}
            if (blad == 0 && txtHaslo.Text == "") { MessageBox.Show("Podaj Hasło"); blad++; }

            if (blad == 0)
            { //formularz ok mozemy pytac baze


            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
