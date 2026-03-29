using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Azil_za_životinje
{
    public partial class frmPregledZivotinja : Form
    {
        public frmPregledZivotinja()
        {
            InitializeComponent();
        }
        List<Zivotinja> lista;

        private void frmPregledZivotinja_Load(object sender, EventArgs e)
        {
            lista = Datoteka.UcitajSve();
            lbZivotinje.Items.Clear();
            foreach (var z in lista)
            {
                lbZivotinje.Items.Add(z.Ime + " (" + z.Vrsta + ")");

            }
        }

        private void lbZivotinje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbZivotinje.SelectedIndex == -1) return;

            Zivotinja z = lista[lbZivotinje.SelectedIndex];

            if (File.Exists(z.PutanjaSlike))
                pbSlika.ImageLocation = z.PutanjaSlike;
            else
                pbSlika.Image = null;



                txtDetalji.Text =
                    "ID: " + z.ID + Environment.NewLine +
                    "Ime: " + z.Ime + Environment.NewLine +
                    "Vrsta: " + z.Vrsta + Environment.NewLine +
                    "Pasmina: " + z.Pasmina + Environment.NewLine +
                    "Spol: " + z.Spol + Environment.NewLine +
                    "Dob: " + z.Dob + Environment.NewLine +
                    "Status: " + z.Status + Environment.NewLine +
                    "Datum dolaska: " + z.DatumDolaska.ToShortDateString() + Environment.NewLine +
                    "Datum udomljavanja: " + (z.DatumUdomljavanja == DateTime.MinValue ? "/" : z.DatumUdomljavanja.ToShortDateString()) + Environment.NewLine +
                    "Cijepljen: " + (z.Cijepljen ? "Da" : "Ne") + Environment.NewLine +
                    "Kastriran: " + (z.Kastriran ? "Da" : "Ne") + Environment.NewLine +
                    "Napomena: " + z.Napomena + Environment.NewLine +
                    "Udomitelj: " + z.Udomitelj + Environment.NewLine +
                    "Kontakt: " + z.Kontakt;

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
