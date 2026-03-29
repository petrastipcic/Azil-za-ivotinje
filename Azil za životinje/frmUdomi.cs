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
    public partial class frmUdomi : Form
    {
        public frmUdomi()
        {
            InitializeComponent();
        }

        private void frmUdomi_Load(object sender, EventArgs e)
        {
            lbZivotinje.Items.Clear();
            List<Zivotinja> lista = Datoteka.UcitajSve();
            foreach (var z in lista)
            {
                if (z.Status == "U azilu")
                    lbZivotinje.Items.Add(z);
            }
        }

        private void lbZivotinje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbZivotinje.SelectedItem == null) return;
            Zivotinja z = (Zivotinja)lbZivotinje.SelectedItem;
            dtpDatumUdomljavanja.Value = DateTime.Now;
                txtUdomitelj.Text = "";
                txtKontakt.Text = "";

            if (!string.IsNullOrEmpty(z.PutanjaSlike))
            {
                pbOdabrana.ImageLocation = z.PutanjaSlike;
                pbOdabrana.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnUdomi_Click(object sender, EventArgs e)
        {
            if (lbZivotinje.SelectedItem == null)
            {
                MessageBox.Show("Odaberite životinju!");
                return;
            }

            Zivotinja z = (Zivotinja)lbZivotinje.SelectedItem;
            if (string.IsNullOrWhiteSpace(txtUdomitelj.Text) || string.IsNullOrWhiteSpace(txtKontakt.Text)) 
            {
                MessageBox.Show("Unesite ime udomitelja i kontakt!");
                return;
            }

            z.Status = "Udomljen/a";
            z.Udomitelj = txtUdomitelj.Text;
            z.Kontakt = txtKontakt.Text;
            z.DatumUdomljavanja = dtpDatumUdomljavanja.Value;

            List<Zivotinja> lista = Datoteka.UcitajSve();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].ID == z.ID)
                {
                    lista[i] = z;
                }
            }
            foreach (var zivotinja in lista)
            {
                Datoteka.Spremi(zivotinja);
            }
            MessageBox.Show("Životinja je uspješno udomljena!");

            lbZivotinje.Items.Clear();
            foreach (var item in lista)
            {
                if (item.Status == "U azilu")
                    lbZivotinje.Items.Add(item);
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
