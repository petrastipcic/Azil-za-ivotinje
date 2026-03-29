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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.lblPasmina = new System.Windows.Forms.Label();
            this.lblSpol = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblDatumDolaska = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtPasmina = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.nudDob = new System.Windows.Forms.NumericUpDown();
            this.dtpDatumDolaska = new System.Windows.Forms.DateTimePicker();
            this.cbCijepljen = new System.Windows.Forms.CheckBox();
            this.cbKastriran = new System.Windows.Forms.CheckBox();
            this.pbOdabir = new System.Windows.Forms.PictureBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdaberiSliku = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 45);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(29, 16);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Location = new System.Drawing.Point(12, 80);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(38, 16);
            this.lblVrsta.TabIndex = 1;
            this.lblVrsta.Text = "Vrsta";
            // 
            // lblPasmina
            // 
            this.lblPasmina.AutoSize = true;
            this.lblPasmina.Location = new System.Drawing.Point(12, 118);
            this.lblPasmina.Name = "lblPasmina";
            this.lblPasmina.Size = new System.Drawing.Size(60, 16);
            this.lblPasmina.TabIndex = 2;
            this.lblPasmina.Text = "Pasmina";
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Location = new System.Drawing.Point(12, 154);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(35, 16);
            this.lblSpol.TabIndex = 3;
            this.lblSpol.Text = "Spol";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(12, 191);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(33, 16);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "Dob";
            // 
            // lblDatumDolaska
            // 
            this.lblDatumDolaska.AutoSize = true;
            this.lblDatumDolaska.Location = new System.Drawing.Point(12, 267);
            this.lblDatumDolaska.Name = "lblDatumDolaska";
            this.lblDatumDolaska.Size = new System.Drawing.Size(98, 16);
            this.lblDatumDolaska.TabIndex = 5;
            this.lblDatumDolaska.Text = "Datum dolaska";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(12, 348);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(75, 16);
            this.lblNapomena.TabIndex = 6;
            this.lblNapomena.Text = "Napomena";
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.Location = new System.Drawing.Point(358, 9);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(124, 16);
            this.lblOdabir.TabIndex = 7;
            this.lblOdabir.Text = "Odabir i prikaz slike";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 228);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(38, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(255, 22);
            this.txtID.TabIndex = 10;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(47, 39);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(246, 22);
            this.txtIme.TabIndex = 11;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(56, 74);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(237, 22);
            this.txtVrsta.TabIndex = 12;
            // 
            // txtPasmina
            // 
            this.txtPasmina.Location = new System.Drawing.Point(78, 112);
            this.txtPasmina.Name = "txtPasmina";
            this.txtPasmina.Size = new System.Drawing.Size(215, 22);
            this.txtPasmina.TabIndex = 13;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(93, 342);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(200, 22);
            this.txtNapomena.TabIndex = 14;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(78, 152);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(39, 20);
            this.rbM.TabIndex = 15;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(123, 152);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(36, 20);
            this.rbZ.TabIndex = 16;
            this.rbZ.TabStop = true;
            this.rbZ.Text = "Ž";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // nudDob
            // 
            this.nudDob.Location = new System.Drawing.Point(51, 185);
            this.nudDob.Name = "nudDob";
            this.nudDob.Size = new System.Drawing.Size(242, 22);
            this.nudDob.TabIndex = 17;
            // 
            // dtpDatumDolaska
            // 
            this.dtpDatumDolaska.Location = new System.Drawing.Point(116, 261);
            this.dtpDatumDolaska.Name = "dtpDatumDolaska";
            this.dtpDatumDolaska.Size = new System.Drawing.Size(177, 22);
            this.dtpDatumDolaska.TabIndex = 18;
            // 
            // cbCijepljen
            // 
            this.cbCijepljen.AutoSize = true;
            this.cbCijepljen.Location = new System.Drawing.Point(12, 302);
            this.cbCijepljen.Name = "cbCijepljen";
            this.cbCijepljen.Size = new System.Drawing.Size(81, 20);
            this.cbCijepljen.TabIndex = 19;
            this.cbCijepljen.Text = "Cijepljen";
            this.cbCijepljen.UseVisualStyleBackColor = true;
            // 
            // cbKastriran
            // 
            this.cbKastriran.AutoSize = true;
            this.cbKastriran.Location = new System.Drawing.Point(198, 302);
            this.cbKastriran.Name = "cbKastriran";
            this.cbKastriran.Size = new System.Drawing.Size(81, 20);
            this.cbKastriran.TabIndex = 20;
            this.cbKastriran.Text = "Kastriran";
            this.cbKastriran.UseVisualStyleBackColor = true;
            // 
            // pbOdabir
            // 
            this.pbOdabir.Location = new System.Drawing.Point(361, 28);
            this.pbOdabir.Name = "pbOdabir";
            this.pbOdabir.Size = new System.Drawing.Size(328, 294);
            this.pbOdabir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOdabir.TabIndex = 21;
            this.pbOdabir.TabStop = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(487, 341);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdaberiSliku
            // 
            this.btnOdaberiSliku.Location = new System.Drawing.Point(538, 3);
            this.btnOdaberiSliku.Name = "btnOdaberiSliku";
            this.btnOdaberiSliku.Size = new System.Drawing.Size(98, 23);
            this.btnOdaberiSliku.TabIndex = 23;
            this.btnOdaberiSliku.Text = "Odaberi sliku";
            this.btnOdaberiSliku.UseVisualStyleBackColor = true;
            this.btnOdaberiSliku.Click += new System.EventHandler(this.btnOdaberiSliku_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "U azilu-bez zdravstvenih poteškoća",
            "U azilu-ima zdravstvene poteškoće"});
            this.cbStatus.Location = new System.Drawing.Point(78, 220);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(215, 24);
            this.cbStatus.TabIndex = 24;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(619, 391);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(96, 23);
            this.btnPovratak.TabIndex = 25;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmUnosZivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 426);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnOdaberiSliku);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.pbOdabir);
            this.Controls.Add(this.cbKastriran);
            this.Controls.Add(this.cbCijepljen);
            this.Controls.Add(this.dtpDatumDolaska);
            this.Controls.Add(this.nudDob);
            this.Controls.Add(this.rbZ);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtPasmina);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblDatumDolaska);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblSpol);
            this.Controls.Add(this.lblPasmina);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.lblIme);
            this.Name = "frmUnosZivotinje";
            this.Text = "frmUnosZivotinje";
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.Label lblPasmina;
        private System.Windows.Forms.Label lblSpol;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblDatumDolaska;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblOdabir;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtPasmina;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbZ;
        private System.Windows.Forms.NumericUpDown nudDob;
        private System.Windows.Forms.DateTimePicker dtpDatumDolaska;
        private System.Windows.Forms.CheckBox cbCijepljen;
        private System.Windows.Forms.CheckBox cbKastriran;
        private System.Windows.Forms.PictureBox pbOdabir;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdaberiSliku;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btnPovratak;
    }
}