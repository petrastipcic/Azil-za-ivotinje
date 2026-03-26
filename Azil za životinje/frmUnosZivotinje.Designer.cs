namespace Azil_za_životinje
{
    partial class frmUnosZivotinje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.lblPasmina = new System.Windows.Forms.Label();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtPasmina = new System.Windows.Forms.TextBox();
            this.lblSpol = new System.Windows.Forms.Label();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.nudDob = new System.Windows.Forms.NumericUpDown();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblDatumDolaska = new System.Windows.Forms.Label();
            this.dtpDatumDolaska = new System.Windows.Forms.DateTimePicker();
            this.cbCijepljen = new System.Windows.Forms.CheckBox();
            this.cbKastriran = new System.Windows.Forms.CheckBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.pbOdabir = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(66, 16);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(149, 20);
            this.txtIme.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 19);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Location = new System.Drawing.Point(12, 52);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(31, 13);
            this.lblVrsta.TabIndex = 2;
            this.lblVrsta.Text = "Vrsta";
            // 
            // lblPasmina
            // 
            this.lblPasmina.AutoSize = true;
            this.lblPasmina.Location = new System.Drawing.Point(12, 86);
            this.lblPasmina.Name = "lblPasmina";
            this.lblPasmina.Size = new System.Drawing.Size(47, 13);
            this.lblPasmina.TabIndex = 3;
            this.lblPasmina.Text = "Pasmina";
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(66, 45);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(149, 20);
            this.txtVrsta.TabIndex = 4;
            // 
            // txtPasmina
            // 
            this.txtPasmina.Location = new System.Drawing.Point(66, 79);
            this.txtPasmina.Name = "txtPasmina";
            this.txtPasmina.Size = new System.Drawing.Size(149, 20);
            this.txtPasmina.TabIndex = 5;
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Location = new System.Drawing.Point(12, 119);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(28, 13);
            this.lblSpol.TabIndex = 6;
            this.lblSpol.Text = "Spol";
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(66, 117);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(34, 17);
            this.rbM.TabIndex = 7;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            this.rbM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(106, 117);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(32, 17);
            this.rbZ.TabIndex = 8;
            this.rbZ.TabStop = true;
            this.rbZ.Text = "Ž";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // nudDob
            // 
            this.nudDob.Location = new System.Drawing.Point(66, 140);
            this.nudDob.Name = "nudDob";
            this.nudDob.Size = new System.Drawing.Size(149, 20);
            this.nudDob.TabIndex = 9;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(12, 142);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(27, 13);
            this.lblDob.TabIndex = 10;
            this.lblDob.Text = "Dob";
            // 
            // lblDatumDolaska
            // 
            this.lblDatumDolaska.AutoSize = true;
            this.lblDatumDolaska.Location = new System.Drawing.Point(12, 171);
            this.lblDatumDolaska.Name = "lblDatumDolaska";
            this.lblDatumDolaska.Size = new System.Drawing.Size(78, 13);
            this.lblDatumDolaska.TabIndex = 11;
            this.lblDatumDolaska.Text = "Datum dolaska";
            this.lblDatumDolaska.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtpDatumDolaska
            // 
            this.dtpDatumDolaska.Location = new System.Drawing.Point(15, 187);
            this.dtpDatumDolaska.Name = "dtpDatumDolaska";
            this.dtpDatumDolaska.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumDolaska.TabIndex = 12;
            // 
            // cbCijepljen
            // 
            this.cbCijepljen.AutoSize = true;
            this.cbCijepljen.Location = new System.Drawing.Point(15, 217);
            this.cbCijepljen.Name = "cbCijepljen";
            this.cbCijepljen.Size = new System.Drawing.Size(65, 17);
            this.cbCijepljen.TabIndex = 13;
            this.cbCijepljen.Text = "Cijepljen";
            this.cbCijepljen.UseVisualStyleBackColor = true;
            // 
            // cbKastriran
            // 
            this.cbKastriran.AutoSize = true;
            this.cbKastriran.Location = new System.Drawing.Point(99, 217);
            this.cbKastriran.Name = "cbKastriran";
            this.cbKastriran.Size = new System.Drawing.Size(67, 17);
            this.cbKastriran.TabIndex = 14;
            this.cbKastriran.Text = "Kastriran";
            this.cbKastriran.UseVisualStyleBackColor = true;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(12, 246);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(59, 13);
            this.lblNapomena.TabIndex = 15;
            this.lblNapomena.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(15, 262);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(200, 20);
            this.txtNapomena.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.Location = new System.Drawing.Point(12, 295);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(139, 13);
            this.lblOdabir.TabIndex = 17;
            this.lblOdabir.Text = "Odabir i prikaz slike životinje";
            // 
            // pbOdabir
            // 
            this.pbOdabir.Location = new System.Drawing.Point(15, 311);
            this.pbOdabir.Name = "pbOdabir";
            this.pbOdabir.Size = new System.Drawing.Size(120, 87);
            this.pbOdabir.TabIndex = 18;
            this.pbOdabir.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUnosZivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbOdabir);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.cbKastriran);
            this.Controls.Add(this.cbCijepljen);
            this.Controls.Add(this.dtpDatumDolaska);
            this.Controls.Add(this.lblDatumDolaska);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.nudDob);
            this.Controls.Add(this.rbZ);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.lblSpol);
            this.Controls.Add(this.txtPasmina);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.lblPasmina);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtIme);
            this.Name = "frmUnosZivotinje";
            this.Text = "frmUnosZivotinje";
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.Label lblPasmina;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtPasmina;
        private System.Windows.Forms.Label lblSpol;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbZ;
        private System.Windows.Forms.NumericUpDown nudDob;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblDatumDolaska;
        private System.Windows.Forms.DateTimePicker dtpDatumDolaska;
        private System.Windows.Forms.CheckBox cbCijepljen;
        private System.Windows.Forms.CheckBox cbKastriran;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblOdabir;
        private System.Windows.Forms.PictureBox pbOdabir;
        private System.Windows.Forms.Button button1;
    }
}