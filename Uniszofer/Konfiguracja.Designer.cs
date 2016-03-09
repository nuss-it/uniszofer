namespace Uniszofer
{
    partial class Konfiguracja
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barPostep = new System.Windows.Forms.ProgressBar();
            this.txtPostep = new System.Windows.Forms.TextBox();
            this.boxKonfiguracja = new System.Windows.Forms.GroupBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.txtBaza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.boxKonfiguracja.SuspendLayout();
            this.SuspendLayout();
            // 
            // barPostep
            // 
            this.barPostep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barPostep.Location = new System.Drawing.Point(0, 173);
            this.barPostep.Maximum = 15;
            this.barPostep.Name = "barPostep";
            this.barPostep.Size = new System.Drawing.Size(321, 23);
            this.barPostep.TabIndex = 0;
            this.barPostep.Click += new System.EventHandler(this.barPostep_Click);
            // 
            // txtPostep
            // 
            this.txtPostep.BackColor = System.Drawing.Color.White;
            this.txtPostep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPostep.Location = new System.Drawing.Point(0, 0);
            this.txtPostep.Multiline = true;
            this.txtPostep.Name = "txtPostep";
            this.txtPostep.ReadOnly = true;
            this.txtPostep.Size = new System.Drawing.Size(321, 173);
            this.txtPostep.TabIndex = 1;
            // 
            // boxKonfiguracja
            // 
            this.boxKonfiguracja.Controls.Add(this.btnZapisz);
            this.boxKonfiguracja.Controls.Add(this.btnTest);
            this.boxKonfiguracja.Controls.Add(this.label4);
            this.boxKonfiguracja.Controls.Add(this.label3);
            this.boxKonfiguracja.Controls.Add(this.label2);
            this.boxKonfiguracja.Controls.Add(this.label1);
            this.boxKonfiguracja.Controls.Add(this.txtBaza);
            this.boxKonfiguracja.Controls.Add(this.txtHaslo);
            this.boxKonfiguracja.Controls.Add(this.txtLogin);
            this.boxKonfiguracja.Controls.Add(this.txtPort);
            this.boxKonfiguracja.Controls.Add(this.txtHost);
            this.boxKonfiguracja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxKonfiguracja.Location = new System.Drawing.Point(0, 0);
            this.boxKonfiguracja.Name = "boxKonfiguracja";
            this.boxKonfiguracja.Size = new System.Drawing.Size(321, 173);
            this.boxKonfiguracja.TabIndex = 2;
            this.boxKonfiguracja.TabStop = false;
            this.boxKonfiguracja.Text = "Konfiguracja danych MySQL";
            this.boxKonfiguracja.Visible = false;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(68, 20);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(180, 20);
            this.txtHost.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(254, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(39, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "3306";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(68, 47);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(180, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtHaslo
            // 
            this.txtHaslo.Location = new System.Drawing.Point(68, 74);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.Size = new System.Drawing.Size(180, 20);
            this.txtHaslo.TabIndex = 3;
            // 
            // txtBaza
            // 
            this.txtBaza.Location = new System.Drawing.Point(68, 101);
            this.txtBaza.Name = "txtBaza";
            this.txtBaza.Size = new System.Drawing.Size(180, 20);
            this.txtBaza.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host i Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Baza";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(34, 135);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Testuj połączenie";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Enabled = false;
            this.btnZapisz.Location = new System.Drawing.Point(211, 135);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(100, 23);
            this.btnZapisz.TabIndex = 10;
            this.btnZapisz.Text = "Zapisz dane";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Konfiguracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 196);
            this.Controls.Add(this.boxKonfiguracja);
            this.Controls.Add(this.txtPostep);
            this.Controls.Add(this.barPostep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Konfiguracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uniszofer";
            this.Load += new System.EventHandler(this.Konfiguracja_Load);
            this.boxKonfiguracja.ResumeLayout(false);
            this.boxKonfiguracja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barPostep;
        private System.Windows.Forms.TextBox txtPostep;
        private System.Windows.Forms.GroupBox boxKonfiguracja;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaza;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Timer timer;
    }
}

