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
    public partial class frmUnosZivotinje : Form
    {
        public frmUnosZivotinje()
        {
            InitializeComponent();
        }
        private string putanjaSlike = "";

        private void btnOdaberiSliku_Click(object sender, EventArgs e)
        {

            // if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            // {
            // putanjaSlike = OpenFileDialog.FileName;
            // pbOdabir.SizeMode = PictureBoxSizeMode.StretchImage;
            // pbOdabir.ImageLocation = putanjaSlike;

            // }

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                putanjaSlike = OpenFileDialog.FileName;
                try
                {
                    using (var imgTemp = Image.FromFile(putanjaSlike))
                    {
                        pbOdabir.Image = new Bitmap(imgTemp);
                    }
                    pbOdabir.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri učitavanju slike! Molimo Vas da odaberete sliku .jpg formata! ");
                    putanjaSlike = "";
                    pbOdabir.Image = null;
                }
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

            txtID.Clear();
            txtIme.Clear();
            txtVrsta.Clear();
            txtPasmina.Clear();
            rbM.Checked = false;
            rbZ.Checked = false;
            nudDob.Value = 0;
            cbStatus.Text = null;
            dtpDatumDolaska.Value = DateTime.Now;
            cbCijepljen.Checked = false;
            cbKastriran.Checked = false;
            txtNapomena.Clear();
            pbOdabir.Image = null;

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
