namespace tomcMatijaProvjeraZnanjaZadatak4
{
    partial class Forma_UnosNovogStudenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSmjerovi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpRodenje = new System.Windows.Forms.DateTimePicker();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(46, 43);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(203, 20);
            this.txtIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime: ";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(46, 97);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(203, 20);
            this.txtPrezime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Smjer:";
            // 
            // cmbSmjerovi
            // 
            this.cmbSmjerovi.FormattingEnabled = true;
            this.cmbSmjerovi.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrežni administrator"});
            this.cmbSmjerovi.Location = new System.Drawing.Point(46, 152);
            this.cmbSmjerovi.Name = "cmbSmjerovi";
            this.cmbSmjerovi.Size = new System.Drawing.Size(203, 21);
            this.cmbSmjerovi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum rođenja: ";
            // 
            // dtpRodenje
            // 
            this.dtpRodenje.Location = new System.Drawing.Point(283, 97);
            this.dtpRodenje.Name = "dtpRodenje";
            this.dtpRodenje.Size = new System.Drawing.Size(200, 20);
            this.dtpRodenje.TabIndex = 9;
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(283, 43);
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.Size = new System.Drawing.Size(200, 20);
            this.txtIndeks.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Broj indeksa:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(49, 228);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(408, 228);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 13;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // Forma_UnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 296);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpRodenje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSmjerovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "Forma_UnosNovogStudenta";
            this.Text = "Forma_UnosNovogStudenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSmjerovi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpRodenje;
        private System.Windows.Forms.TextBox txtIndeks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOtkazi;
    }
}