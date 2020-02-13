using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomcMatijaProvjeraZnanjaZadatak4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObrisiSve_Click(object sender, EventArgs e)
        {
            lsbStudenti = null;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            lsbStudenti.ClearSelected();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new Forma_UnosNovogStudenta = Forma_UnosNovogStudenta;
            Forma_UnosNovogStudenta;
        }
    }
}
