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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linija = textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text;
            Admin.SpremiPodatke(linija);
        }
    }
}
