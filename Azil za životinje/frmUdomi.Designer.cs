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
            this.ListaŽivotinja = new System.Windows.Forms.ListBox();
            this.lblDatumUdomljavanja = new System.Windows.Forms.Label();
            this.dtpDatumUdomljavanja = new System.Windows.Forms.DateTimePicker();
            this.lblImeUdomitelja = new System.Windows.Forms.Label();
            this.txtImeUdomitelja = new System.Windows.Forms.TextBox();
            this.txtKontaktUdomitelja = new System.Windows.Forms.TextBox();
            this.lblKontaktUdomitelja = new System.Windows.Forms.Label();
            this.btnUdomi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaŽivotinja
            // 
            this.ListaŽivotinja.FormattingEnabled = true;
            this.ListaŽivotinja.Location = new System.Drawing.Point(12, 12);
            this.ListaŽivotinja.Name = "ListaŽivotinja";
            this.ListaŽivotinja.Size = new System.Drawing.Size(221, 303);
            this.ListaŽivotinja.TabIndex = 0;
            // 
            // lblDatumUdomljavanja
            // 
            this.lblDatumUdomljavanja.AutoSize = true;
            this.lblDatumUdomljavanja.Location = new System.Drawing.Point(239, 28);
            this.lblDatumUdomljavanja.Name = "lblDatumUdomljavanja";
            this.lblDatumUdomljavanja.Size = new System.Drawing.Size(103, 13);
            this.lblDatumUdomljavanja.TabIndex = 1;
            this.lblDatumUdomljavanja.Text = "Datum udomljavanja";
            // 
            // dtpDatumUdomljavanja
            // 
            this.dtpDatumUdomljavanja.Location = new System.Drawing.Point(348, 22);
            this.dtpDatumUdomljavanja.Name = "dtpDatumUdomljavanja";
            this.dtpDatumUdomljavanja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumUdomljavanja.TabIndex = 2;
            // 
            // lblImeUdomitelja
            // 
            this.lblImeUdomitelja.AutoSize = true;
            this.lblImeUdomitelja.Location = new System.Drawing.Point(239, 58);
            this.lblImeUdomitelja.Name = "lblImeUdomitelja";
            this.lblImeUdomitelja.Size = new System.Drawing.Size(74, 13);
            this.lblImeUdomitelja.TabIndex = 3;
            this.lblImeUdomitelja.Text = "Ime udomitelja";
            // 
            // txtImeUdomitelja
            // 
            this.txtImeUdomitelja.Location = new System.Drawing.Point(319, 51);
            this.txtImeUdomitelja.Name = "txtImeUdomitelja";
            this.txtImeUdomitelja.Size = new System.Drawing.Size(229, 20);
            this.txtImeUdomitelja.TabIndex = 4;
            // 
            // txtKontaktUdomitelja
            // 
            this.txtKontaktUdomitelja.Location = new System.Drawing.Point(348, 81);
            this.txtKontaktUdomitelja.Name = "txtKontaktUdomitelja";
            this.txtKontaktUdomitelja.Size = new System.Drawing.Size(200, 20);
            this.txtKontaktUdomitelja.TabIndex = 5;
            // 
            // lblKontaktUdomitelja
            // 
            this.lblKontaktUdomitelja.AutoSize = true;
            this.lblKontaktUdomitelja.Location = new System.Drawing.Point(239, 88);
            this.lblKontaktUdomitelja.Name = "lblKontaktUdomitelja";
            this.lblKontaktUdomitelja.Size = new System.Drawing.Size(94, 13);
            this.lblKontaktUdomitelja.TabIndex = 6;
            this.lblKontaktUdomitelja.Text = "Kontakt udomitelja";
            // 
            // btnUdomi
            // 
            this.btnUdomi.Location = new System.Drawing.Point(348, 119);
            this.btnUdomi.Name = "btnUdomi";
            this.btnUdomi.Size = new System.Drawing.Size(75, 23);
            this.btnUdomi.TabIndex = 7;
            this.btnUdomi.Text = "Udomi";
            this.btnUdomi.UseVisualStyleBackColor = true;
            // 
            // frmUdomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUdomi);
            this.Controls.Add(this.lblKontaktUdomitelja);
            this.Controls.Add(this.txtKontaktUdomitelja);
            this.Controls.Add(this.txtImeUdomitelja);
            this.Controls.Add(this.lblImeUdomitelja);
            this.Controls.Add(this.dtpDatumUdomljavanja);
            this.Controls.Add(this.lblDatumUdomljavanja);
            this.Controls.Add(this.ListaŽivotinja);
            this.Name = "frmUdomi";
            this.Text = "frmUdomi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaŽivotinja;
        private System.Windows.Forms.Label lblDatumUdomljavanja;
        private System.Windows.Forms.DateTimePicker dtpDatumUdomljavanja;
        private System.Windows.Forms.Label lblImeUdomitelja;
        private System.Windows.Forms.TextBox txtImeUdomitelja;
        private System.Windows.Forms.TextBox txtKontaktUdomitelja;
        private System.Windows.Forms.Label lblKontaktUdomitelja;
        private System.Windows.Forms.Button btnUdomi;
    }
}