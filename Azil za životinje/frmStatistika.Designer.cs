namespace Azil_za_životinje
{
    partial class frmStatistika
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
            this.lblUkupan = new System.Windows.Forms.Label();
            this.lblTrenutno = new System.Windows.Forms.Label();
            this.lblUdomljeni = new System.Windows.Forms.Label();
            this.lblProsjecna = new System.Windows.Forms.Label();
            this.lblPsi = new System.Windows.Forms.Label();
            this.lblMačke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUkupan
            // 
            this.lblUkupan.AutoSize = true;
            this.lblUkupan.Location = new System.Drawing.Point(12, 9);
            this.lblUkupan.Name = "lblUkupan";
            this.lblUkupan.Size = new System.Drawing.Size(109, 13);
            this.lblUkupan.TabIndex = 0;
            this.lblUkupan.Text = "Ukupan broj životinja:";
            // 
            // lblTrenutno
            // 
            this.lblTrenutno.AutoSize = true;
            this.lblTrenutno.Location = new System.Drawing.Point(12, 35);
            this.lblTrenutno.Name = "lblTrenutno";
            this.lblTrenutno.Size = new System.Drawing.Size(153, 13);
            this.lblTrenutno.TabIndex = 1;
            this.lblTrenutno.Text = "Broj trenutno prisutnih životinja:";
            // 
            // lblUdomljeni
            // 
            this.lblUdomljeni.AutoSize = true;
            this.lblUdomljeni.Location = new System.Drawing.Point(12, 62);
            this.lblUdomljeni.Name = "lblUdomljeni";
            this.lblUdomljeni.Size = new System.Drawing.Size(122, 13);
            this.lblUdomljeni.TabIndex = 2;
            this.lblUdomljeni.Text = "Broj udomljenih životinja:";
            // 
            // lblProsjecna
            // 
            this.lblProsjecna.AutoSize = true;
            this.lblProsjecna.Location = new System.Drawing.Point(12, 89);
            this.lblProsjecna.Name = "lblProsjecna";
            this.lblProsjecna.Size = new System.Drawing.Size(119, 13);
            this.lblProsjecna.TabIndex = 3;
            this.lblProsjecna.Text = "Prosječna dob životinja:";
            // 
            // lblPsi
            // 
            this.lblPsi.AutoSize = true;
            this.lblPsi.Location = new System.Drawing.Point(12, 116);
            this.lblPsi.Name = "lblPsi";
            this.lblPsi.Size = new System.Drawing.Size(94, 13);
            this.lblPsi.TabIndex = 4;
            this.lblPsi.Text = "Ukupan broj pasa:";
            // 
            // lblMačke
            // 
            this.lblMačke.AutoSize = true;
            this.lblMačke.Location = new System.Drawing.Point(12, 144);
            this.lblMačke.Name = "lblMačke";
            this.lblMačke.Size = new System.Drawing.Size(109, 13);
            this.lblMačke.TabIndex = 5;
            this.lblMačke.Text = "Ukupan broj mačaka:";
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMačke);
            this.Controls.Add(this.lblPsi);
            this.Controls.Add(this.lblProsjecna);
            this.Controls.Add(this.lblUdomljeni);
            this.Controls.Add(this.lblTrenutno);
            this.Controls.Add(this.lblUkupan);
            this.Name = "frmStatistika";
            this.Text = "frmStatistika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUkupan;
        private System.Windows.Forms.Label lblTrenutno;
        private System.Windows.Forms.Label lblUdomljeni;
        private System.Windows.Forms.Label lblProsjecna;
        private System.Windows.Forms.Label lblPsi;
        private System.Windows.Forms.Label lblMačke;
    }
}