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
    public partial class frmUnosZivotinje : Form
    {
        public frmUnosZivotinje()
        {
            InitializeComponent();
        }
        string putanjaSlike = "";

        private void btnOdaberiSliku_Click(object sender, EventArgs e)
        {
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                putanjaSlike = OpenFileDialog.FileName;
                pbOdabir.ImageLocation = putanjaSlike;

            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Zivotinja z = new Zivotinja();
            z.ID = txtID.Text;
            z.Ime = txtIme.Text;
            z.Vrsta = txtVrsta.Text;
            z.Pasmina = txtPasmina.Text;
            if (rbM.Checked)
                z.Spol = "M";
            else if (rbZ.Checked)
                z.Spol = "Ž";
            z.Dob = (int)nudDob.Value;
            z.Status = cbStatus.Text;
            z.PutanjaSlike = putanjaSlike;
            z.DatumDolaska = dtpDatumDolaska.Value;
            z.DatumUdomljavanja = DateTime.MinValue;
            z.Cijepljen = cbCijepljen.Checked;
            z.Kastriran = cbKastriran.Checked;
            z.Napomena = txtNapomena.Text;
            z.Udomitelj = "";
            z.Kontakt = "";

            Datoteka.Spremi(z);

            MessageBox.Show("Životinja spremljena!");

            txtIme.Clear();
            txtVrsta.Clear();
            txtPasmina.Clear();
            txtNapomena.Clear();
            pbOdabir.Image = null;

        }
    }
}
