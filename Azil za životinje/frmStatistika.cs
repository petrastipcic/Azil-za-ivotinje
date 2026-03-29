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
    public partial class frmStatistika : Form
    {
        public frmStatistika()
        {
            InitializeComponent();
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            List<Zivotinja> lista = Datoteka.UcitajSve();

            lblUkupno.Text = lista.Count.ToString();

            int brojUAzilu = 0;
            foreach (var z in lista)
            {
                if (z.Status.StartsWith("U azilu"))
                    brojUAzilu++;
            }
            lblTrenutnoUAzilu.Text = brojUAzilu.ToString();

            int brojUdomljenih = 0;
            foreach (var z in lista)
            {
                if (z.Status == "Udomljen/a")
                    brojUdomljenih++;
            }
            lblUdomljene.Text = brojUdomljenih.ToString();

            double prosjek=0;
            if (lista.Count > 0)
            {
                prosjek = lista.Average(z => z.Dob);
            }
            lblProsjecnaDob.Text = prosjek.ToString("0.00");

            lbVrste.Items.Clear();
            Dictionary<string, int> vrste = new Dictionary<string, int>();
            foreach (var z in lista)
            {
                if (vrste.ContainsKey(z.Vrsta))
                {
                    vrste[z.Vrsta]++;
                }
                else
                {
                    vrste[z.Vrsta] = 1;
                }
            }

            foreach (var v in vrste)
            {
                lbVrste.Items.Add($"{v.Key}: {v.Value}");
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
