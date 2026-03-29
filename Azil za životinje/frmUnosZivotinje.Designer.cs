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
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.pbOdabir = new System.Windows.Forms.PictureBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdaberiSliku = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(88, 20);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(197, 22);
            this.txtIme.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(16, 23);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(29, 16);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Location = new System.Drawing.Point(16, 64);
            this.lblVrsta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(38, 16);
            this.lblVrsta.TabIndex = 2;
            this.lblVrsta.Text = "Vrsta";
            // 
            // lblPasmina
            // 
            this.lblPasmina.AutoSize = true;
            this.lblPasmina.Location = new System.Drawing.Point(16, 106);
            this.lblPasmina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasmina.Name = "lblPasmina";
            this.lblPasmina.Size = new System.Drawing.Size(60, 16);
            this.lblPasmina.TabIndex = 3;
            this.lblPasmina.Text = "Pasmina";
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(88, 55);
            this.txtVrsta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(197, 22);
            this.txtVrsta.TabIndex = 4;
            // 
            // txtPasmina
            // 
            this.txtPasmina.Location = new System.Drawing.Point(88, 97);
            this.txtPasmina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasmina.Name = "txtPasmina";
            this.txtPasmina.Size = new System.Drawing.Size(197, 22);
            this.txtPasmina.TabIndex = 5;
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Location = new System.Drawing.Point(16, 146);
            this.lblSpol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(35, 16);
            this.lblSpol.TabIndex = 6;
            this.lblSpol.Text = "Spol";
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(88, 144);
            this.rbM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(39, 20);
            this.rbM.TabIndex = 7;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            this.rbM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(141, 144);
            this.rbZ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(36, 20);
            this.rbZ.TabIndex = 8;
            this.rbZ.TabStop = true;
            this.rbZ.Text = "Ž";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // nudDob
            // 
            this.nudDob.Location = new System.Drawing.Point(88, 172);
            this.nudDob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDob.Name = "nudDob";
            this.nudDob.Size = new System.Drawing.Size(199, 22);
            this.nudDob.TabIndex = 9;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(16, 175);
            this.lblDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(33, 16);
            this.lblDob.TabIndex = 10;
            this.lblDob.Text = "Dob";
            // 
            // lblDatumDolaska
            // 
            this.lblDatumDolaska.AutoSize = true;
            this.lblDatumDolaska.Location = new System.Drawing.Point(16, 210);
            this.lblDatumDolaska.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumDolaska.Name = "lblDatumDolaska";
            this.lblDatumDolaska.Size = new System.Drawing.Size(98, 16);
            this.lblDatumDolaska.TabIndex = 11;
            this.lblDatumDolaska.Text = "Datum dolaska";
            this.lblDatumDolaska.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtpDatumDolaska
            // 
            this.dtpDatumDolaska.Location = new System.Drawing.Point(20, 230);
            this.dtpDatumDolaska.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatumDolaska.Name = "dtpDatumDolaska";
            this.dtpDatumDolaska.Size = new System.Drawing.Size(265, 22);
            this.dtpDatumDolaska.TabIndex = 12;
            // 
            // cbCijepljen
            // 
            this.cbCijepljen.AutoSize = true;
            this.cbCijepljen.Location = new System.Drawing.Point(20, 267);
            this.cbCijepljen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCijepljen.Name = "cbCijepljen";
            this.cbCijepljen.Size = new System.Drawing.Size(81, 20);
            this.cbCijepljen.TabIndex = 13;
            this.cbCijepljen.Text = "Cijepljen";
            this.cbCijepljen.UseVisualStyleBackColor = true;
            // 
            // cbKastriran
            // 
            this.cbKastriran.AutoSize = true;
            this.cbKastriran.Location = new System.Drawing.Point(132, 267);
            this.cbKastriran.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKastriran.Name = "cbKastriran";
            this.cbKastriran.Size = new System.Drawing.Size(81, 20);
            this.cbKastriran.TabIndex = 14;
            this.cbKastriran.Text = "Kastriran";
            this.cbKastriran.UseVisualStyleBackColor = true;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(16, 303);
            this.lblNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(75, 16);
            this.lblNapomena.TabIndex = 15;
            this.lblNapomena.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(20, 322);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(265, 22);
            this.txtNapomena.TabIndex = 16;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.Location = new System.Drawing.Point(16, 363);
            this.lblOdabir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(175, 16);
            this.lblOdabir.TabIndex = 17;
            this.lblOdabir.Text = "Odabir i prikaz slike životinje";
            // 
            // pbOdabir
            // 
            this.pbOdabir.Location = new System.Drawing.Point(20, 383);
            this.pbOdabir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbOdabir.Name = "pbOdabir";
            this.pbOdabir.Size = new System.Drawing.Size(160, 107);
            this.pbOdabir.TabIndex = 18;
            this.pbOdabir.TabStop = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(20, 497);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 28);
            this.btnSpremi.TabIndex = 19;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdaberiSliku
            // 
            this.btnOdaberiSliku.Location = new System.Drawing.Point(198, 383);
            this.btnOdaberiSliku.Name = "btnOdaberiSliku";
            this.btnOdaberiSliku.Size = new System.Drawing.Size(109, 23);
            this.btnOdaberiSliku.TabIndex = 20;
            this.btnOdaberiSliku.Text = "Odaberi sliku";
            this.btnOdaberiSliku.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "U azilu",
            "Udomljen/a"});
            this.cbStatus.Location = new System.Drawing.Point(329, 170);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 21;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(326, 146);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(326, 210);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(329, 230);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(197, 22);
            this.txtID.TabIndex = 24;
            // 
            // frmUnosZivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnOdaberiSliku);
            this.Controls.Add(this.btnSpremi);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label lblOdabir;
        private System.Windows.Forms.PictureBox pbOdabir;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdaberiSliku;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}