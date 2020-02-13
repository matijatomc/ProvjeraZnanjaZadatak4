namespace tomcMatijaProvjeraZnanjaZadatak4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lsbStudenti = new System.Windows.Forms.ListBox();
            this.btnObrisiSve = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(23, 22);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(150, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodajte novog studenta";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lsbStudenti
            // 
            this.lsbStudenti.FormattingEnabled = true;
            this.lsbStudenti.Location = new System.Drawing.Point(23, 64);
            this.lsbStudenti.Name = "lsbStudenti";
            this.lsbStudenti.Size = new System.Drawing.Size(291, 186);
            this.lsbStudenti.TabIndex = 1;
            // 
            // btnObrisiSve
            // 
            this.btnObrisiSve.Location = new System.Drawing.Point(23, 276);
            this.btnObrisiSve.Name = "btnObrisiSve";
            this.btnObrisiSve.Size = new System.Drawing.Size(130, 23);
            this.btnObrisiSve.TabIndex = 2;
            this.btnObrisiSve.Text = "Obrisi sve studente";
            this.btnObrisiSve.UseVisualStyleBackColor = true;
            this.btnObrisiSve.Click += new System.EventHandler(this.btnObrisiSve_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(341, 142);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(92, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi studenta";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 324);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnObrisiSve);
            this.Controls.Add(this.lsbStudenti);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lsbStudenti;
        private System.Windows.Forms.Button btnObrisiSve;
        private System.Windows.Forms.Button btnObrisi;
    }
}

