namespace Azil_za_životinje
{
    partial class frmUdomi
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
            this.lblZivotinje = new System.Windows.Forms.Label();
            this.lblDatumUdomljavanja = new System.Windows.Forms.Label();
            this.lbZivotinje = new System.Windows.Forms.ListBox();
            this.dtpDatumUdomljavanja = new System.Windows.Forms.DateTimePicker();
            this.lblUdomitelj = new System.Windows.Forms.Label();
            this.txtUdomitelj = new System.Windows.Forms.TextBox();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.btnUdomi = new System.Windows.Forms.Button();
            this.pbOdabrana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabrana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZivotinje
            // 
            this.lblZivotinje.AutoSize = true;
            this.lblZivotinje.Location = new System.Drawing.Point(12, 9);
            this.lblZivotinje.Name = "lblZivotinje";
            this.lblZivotinje.Size = new System.Drawing.Size(86, 16);
            this.lblZivotinje.TabIndex = 0;
            this.lblZivotinje.Text = "Lista životinja";
            // 
            // lblDatumUdomljavanja
            // 
            this.lblDatumUdomljavanja.AutoSize = true;
            this.lblDatumUdomljavanja.Location = new System.Drawing.Point(386, 33);
            this.lblDatumUdomljavanja.Name = "lblDatumUdomljavanja";
            this.lblDatumUdomljavanja.Size = new System.Drawing.Size(130, 16);
            this.lblDatumUdomljavanja.TabIndex = 1;
            this.lblDatumUdomljavanja.Text = "Datum udomljavanja";
            // 
            // lbZivotinje
            // 
            this.lbZivotinje.FormattingEnabled = true;
            this.lbZivotinje.ItemHeight = 16;
            this.lbZivotinje.Location = new System.Drawing.Point(12, 28);
            this.lbZivotinje.Name = "lbZivotinje";
            this.lbZivotinje.Size = new System.Drawing.Size(348, 484);
            this.lbZivotinje.TabIndex = 2;
            this.lbZivotinje.SelectedIndexChanged += new System.EventHandler(this.lbZivotinje_SelectedIndexChanged);
            // 
            // dtpDatumUdomljavanja
            // 
            this.dtpDatumUdomljavanja.Location = new System.Drawing.Point(522, 28);
            this.dtpDatumUdomljavanja.Name = "dtpDatumUdomljavanja";
            this.dtpDatumUdomljavanja.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumUdomljavanja.TabIndex = 3;
            // 
            // lblUdomitelj
            // 
            this.lblUdomitelj.AutoSize = true;
            this.lblUdomitelj.Location = new System.Drawing.Point(386, 73);
            this.lblUdomitelj.Name = "lblUdomitelj";
            this.lblUdomitelj.Size = new System.Drawing.Size(64, 16);
            this.lblUdomitelj.TabIndex = 4;
            this.lblUdomitelj.Text = "Udomitelj";
            // 
            // txtUdomitelj
            // 
            this.txtUdomitelj.Location = new System.Drawing.Point(470, 67);
            this.txtUdomitelj.Name = "txtUdomitelj";
            this.txtUdomitelj.Size = new System.Drawing.Size(252, 22);
            this.txtUdomitelj.TabIndex = 5;
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(386, 114);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(51, 16);
            this.lblKontakt.TabIndex = 6;
            this.lblKontakt.Text = "Kontakt";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(470, 108);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(252, 22);
            this.txtKontakt.TabIndex = 7;
            // 
            // btnUdomi
            // 
            this.btnUdomi.Location = new System.Drawing.Point(522, 152);
            this.btnUdomi.Name = "btnUdomi";
            this.btnUdomi.Size = new System.Drawing.Size(75, 23);
            this.btnUdomi.TabIndex = 8;
            this.btnUdomi.Text = "Udomi";
            this.btnUdomi.UseVisualStyleBackColor = true;
            this.btnUdomi.Click += new System.EventHandler(this.btnUdomi_Click);
            // 
            // pbOdabrana
            // 
            this.pbOdabrana.Location = new System.Drawing.Point(389, 190);
            this.pbOdabrana.Name = "pbOdabrana";
            this.pbOdabrana.Size = new System.Drawing.Size(333, 322);
            this.pbOdabrana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOdabrana.TabIndex = 9;
            this.pbOdabrana.TabStop = false;
            // 
            // frmUdomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 525);
            this.Controls.Add(this.pbOdabrana);
            this.Controls.Add(this.btnUdomi);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.txtUdomitelj);
            this.Controls.Add(this.lblUdomitelj);
            this.Controls.Add(this.dtpDatumUdomljavanja);
            this.Controls.Add(this.lbZivotinje);
            this.Controls.Add(this.lblDatumUdomljavanja);
            this.Controls.Add(this.lblZivotinje);
            this.Name = "frmUdomi";
            this.Text = "frmUdomi";
            this.Load += new System.EventHandler(this.frmUdomi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabrana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZivotinje;
        private System.Windows.Forms.Label lblDatumUdomljavanja;
        private System.Windows.Forms.ListBox lbZivotinje;
        private System.Windows.Forms.DateTimePicker dtpDatumUdomljavanja;
        private System.Windows.Forms.Label lblUdomitelj;
        private System.Windows.Forms.TextBox txtUdomitelj;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Button btnUdomi;
        private System.Windows.Forms.PictureBox pbOdabrana;
    }
}