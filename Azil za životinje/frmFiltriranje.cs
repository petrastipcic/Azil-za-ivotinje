using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azil_za_životinje
{
    public partial class frmFiltriranje : Form
    {
        public frmFiltriranje()
        {
            InitializeComponent();
        }
        List<Zivotinja> lista;

        private void frmFiltriranje_Load(object sender, EventArgs e)
        {
            lista = Datoteka.UcitajSve();
            cbFilter.Items.Add("Pas");
            cbFilter.Items.Add("Mačka");
            cbFilter.Items.Add("U azilu-bez zdravstvenih poteškoća");
            cbFilter.Items.Add("U azilu-ima zdravstvene poteškoće");
            cbFilter.Items.Add("Udomljen/a");

        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            lbRezultati.Items.Clear();
            string filter = cbFilter.Text;
            foreach (var z in lista)
            {
                if (z.Vrsta == filter || z.Status == filter)
                {
                    lbRezultati.Items.Add(z.Ime + " (" + z.Vrsta + ")");

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbRezultati.Items.Clear();
            foreach (var z in lista)
            {
                lbRezultati.Items.Add(z.Ime + " (" + z.Vrsta + ")");

            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
