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
        List<Zivotinja> lista;


        private void frmUdomi_Load(object sender, EventArgs e)
        {
            //dtpDatumUdomljavanja.Value = DateTime.Now;

            //lbZivotinje.Items.Clear();
            //List<Zivotinja> lista = Datoteka.UcitajSve();
            //foreach (var z in lista)
            //{
            //if (z.Status.StartsWith( "U azilu"))
            // lbZivotinje.Items.Add(z);
            //}
            UcitajZivotinje();

        }

        private void UcitajZivotinje()
        {
            lbZivotinje.Items.Clear();
            lista = Datoteka.UcitajSve();
            foreach (var z in lista)
            {
                if (z.Status.StartsWith("U azilu"))
                    lbZivotinje.Items.Add(z);
            }
        }

        private void lbZivotinje_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lbZivotinje.SelectedItem == null) return;
            //Zivotinja z = (Zivotinja)lbZivotinje.SelectedItem;
            //dtpDatumUdomljavanja.Value = DateTime.Now;
               // txtUdomitelj.Text = "";
                //txtKontakt.Text = "";

            //if (!string.IsNullOrEmpty(z.PutanjaSlike))
            //{
               // pbOdabrana.ImageLocation = z.PutanjaSlike;
               // pbOdabrana.SizeMode = PictureBoxSizeMode.StretchImage;
           // }

            if (lbZivotinje.SelectedItem == null) return;
            Zivotinja z = (Zivotinja)lbZivotinje.SelectedItem;

            if (!string.IsNullOrEmpty(z.PutanjaSlike))
            {
                pbOdabrana.ImageLocation = z.PutanjaSlike;
                pbOdabrana.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbOdabrana.Image = null;
            }
             dtpDatumUdomljavanja.Value = DateTime.Today;
             txtUdomitelj.Text = "";
             txtKontakt.Text = "";
        }

        private void btnUdomi_Click(object sender, EventArgs e)
        {
            if (lbZivotinje.SelectedItem == null)
            {
                MessageBox.Show("Odaberite životinju!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUdomitelj.Text) || string.IsNullOrWhiteSpace(txtKontakt.Text))
            {
                MessageBox.Show("Unesite ime udomitelja i kontakt!");
                return;
            }

            //Zivotinja z = (Zivotinja)lbZivotinje.SelectedItem;
            Zivotinja odabrana = (Zivotinja)lbZivotinje.SelectedItem;

            foreach (var z in lista)
            {
                if (z.ID == odabrana.ID)
                {
                    z.Status = "Udomljen/a";
                    z.Udomitelj = txtUdomitelj.Text;
                    z.Kontakt = txtKontakt.Text;
                    z.DatumUdomljavanja = dtpDatumUdomljavanja.Value;
                }
            }

            Datoteka.SpremiSve(lista);
            MessageBox.Show("Životinja je uspješno udomljena!");
            dtpDatumUdomljavanja.Value = DateTime.Today;
            txtUdomitelj.Clear();
            txtKontakt.Clear();
            UcitajZivotinje();
               


            //if (string.IsNullOrWhiteSpace(txtUdomitelj.Text) || string.IsNullOrWhiteSpace(txtKontakt.Text)) 
            //{
            // MessageBox.Show("Unesite ime udomitelja i kontakt!");
            // return;
            // }

            // z.Status = "Udomljen/a";
            //z.Udomitelj = txtUdomitelj.Text;
            //z.Kontakt = txtKontakt.Text;
            //z.DatumUdomljavanja = dtpDatumUdomljavanja.Value;

            //List<Zivotinja> lista = Datoteka.UcitajSve();
            //foreach (var item in lista)
            //{
            //if (item.ID == z.ID)
            //{
            // item.Status = z.Status;
            // item.Udomitelj = z.Udomitelj;
            // item.Kontakt = z.Kontakt;
            //item.DatumUdomljavanja = z.DatumUdomljavanja;
            // }
            //}
            //foreach (var item in lista)
            //{
            // Datoteka.Spremi(item);
            // }
            // MessageBox.Show("Životinja je uspješno udomljena!");

            //lbZivotinje.Items.Clear();
            // foreach (var item in lista)
            //{
            // if (item.Status.StartsWith("U azilu"))
            //  lbZivotinje.Items.Add(item);
            // }

            //dtpDatumUdomljavanja.Value = DateTime.Now;
            //txtUdomitelj.Clear();
            //txtKontakt.Clear();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
