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
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void btnUnosZivotinje_Click(object sender, EventArgs e)
        {
            frmUnosZivotinje unos = new frmUnosZivotinje();
            unos.ShowDialog();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            frmPregledZivotinja pregled = new frmPregledZivotinja();
            pregled.ShowDialog();
        }

        private void btnFiltriranje_Click(object sender, EventArgs e)
        {
            frmFiltriranje filtriranje = new frmFiltriranje();
            filtriranje.ShowDialog();
        }

        private void btnUdomljavanje_Click(object sender, EventArgs e)
        {
            frmUdomi udomi = new frmUdomi();
            udomi.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            frmStatistika statistika = new frmStatistika();
            statistika.ShowDialog();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
