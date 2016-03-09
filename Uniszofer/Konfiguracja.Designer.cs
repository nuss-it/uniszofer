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
            this.barPostep = new System.Windows.Forms.ProgressBar();
            this.txtPostep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // barPostep
            // 
            this.barPostep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barPostep.Location = new System.Drawing.Point(0, 166);
            this.barPostep.Maximum = 10;
            this.barPostep.Name = "barPostep";
            this.barPostep.Size = new System.Drawing.Size(369, 23);
            this.barPostep.TabIndex = 0;
            // 
            // txtPostep
            // 
            this.txtPostep.BackColor = System.Drawing.Color.White;
            this.txtPostep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPostep.Location = new System.Drawing.Point(0, 0);
            this.txtPostep.Multiline = true;
            this.txtPostep.Name = "txtPostep";
            this.txtPostep.ReadOnly = true;
            this.txtPostep.Size = new System.Drawing.Size(369, 166);
            this.txtPostep.TabIndex = 1;
            // 
            // Konfiguracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 189);
            this.Controls.Add(this.txtPostep);
            this.Controls.Add(this.barPostep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Konfiguracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uniszofer";
            this.Load += new System.EventHandler(this.Konfiguracja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barPostep;
        private System.Windows.Forms.TextBox txtPostep;
    }
}

