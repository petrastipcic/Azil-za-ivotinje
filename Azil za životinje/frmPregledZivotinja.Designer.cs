namespace Azil_za_životinje
{
    partial class frmPregledZivotinja
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
            this.lbZivotinje = new System.Windows.Forms.ListBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.lblDetalji = new System.Windows.Forms.Label();
            this.lblSlika = new System.Windows.Forms.Label();
            this.lblListaZivotinja = new System.Windows.Forms.Label();
            this.txtDetalji = new System.Windows.Forms.TextBox();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lbZivotinje
            // 
            this.lbZivotinje.FormattingEnabled = true;
            this.lbZivotinje.ItemHeight = 16;
            this.lbZivotinje.Location = new System.Drawing.Point(12, 28);
            this.lbZivotinje.Name = "lbZivotinje";
            this.lbZivotinje.Size = new System.Drawing.Size(401, 500);
            this.lbZivotinje.TabIndex = 0;
            this.lbZivotinje.SelectedIndexChanged += new System.EventHandler(this.lbZivotinje_SelectedIndexChanged);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(419, 28);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(353, 495);
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // lblDetalji
            // 
            this.lblDetalji.AutoSize = true;
            this.lblDetalji.Location = new System.Drawing.Point(775, 9);
            this.lblDetalji.Name = "lblDetalji";
            this.lblDetalji.Size = new System.Drawing.Size(45, 16);
            this.lblDetalji.TabIndex = 2;
            this.lblDetalji.Text = "Detalji";
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(416, 9);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(37, 16);
            this.lblSlika.TabIndex = 3;
            this.lblSlika.Text = "Slika";
            // 
            // lblListaZivotinja
            // 
            this.lblListaZivotinja.AutoSize = true;
            this.lblListaZivotinja.Location = new System.Drawing.Point(12, 9);
            this.lblListaZivotinja.Name = "lblListaZivotinja";
            this.lblListaZivotinja.Size = new System.Drawing.Size(85, 16);
            this.lblListaZivotinja.TabIndex = 4;
            this.lblListaZivotinja.Text = "ListaZivotinja";
            // 
            // txtDetalji
            // 
            this.txtDetalji.Location = new System.Drawing.Point(778, 28);
            this.txtDetalji.Multiline = true;
            this.txtDetalji.Name = "txtDetalji";
            this.txtDetalji.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalji.Size = new System.Drawing.Size(384, 495);
            this.txtDetalji.TabIndex = 5;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(1168, 500);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(75, 23);
            this.btnPovratak.TabIndex = 6;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmPregledZivotinja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 535);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.txtDetalji);
            this.Controls.Add(this.lblListaZivotinja);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.lblDetalji);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.lbZivotinje);
            this.Name = "frmPregledZivotinja";
            this.Text = "frmPregledZivotinja";
            this.Load += new System.EventHandler(this.frmPregledZivotinja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbZivotinje;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label lblDetalji;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.Label lblListaZivotinja;
        private System.Windows.Forms.TextBox txtDetalji;
        private System.Windows.Forms.Button btnPovratak;
    }
}