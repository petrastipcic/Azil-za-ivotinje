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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProsjecnaDob = new System.Windows.Forms.Label();
            this.lblUdomljene = new System.Windows.Forms.Label();
            this.lblTrenutnoUAzilu = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lbVrste = new System.Windows.Forms.ListBox();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukupan broj životinja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj trenutno prisutnih životinja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj udomljenih životinja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prosječna dob životinja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj životinja po vrstama";
            // 
            // lblProsjecnaDob
            // 
            this.lblProsjecnaDob.AutoSize = true;
            this.lblProsjecnaDob.Location = new System.Drawing.Point(168, 126);
            this.lblProsjecnaDob.Name = "lblProsjecnaDob";
            this.lblProsjecnaDob.Size = new System.Drawing.Size(13, 16);
            this.lblProsjecnaDob.TabIndex = 5;
            this.lblProsjecnaDob.Text = "  ";
            // 
            // lblUdomljene
            // 
            this.lblUdomljene.AutoSize = true;
            this.lblUdomljene.Location = new System.Drawing.Point(168, 87);
            this.lblUdomljene.Name = "lblUdomljene";
            this.lblUdomljene.Size = new System.Drawing.Size(13, 16);
            this.lblUdomljene.TabIndex = 6;
            this.lblUdomljene.Text = "  ";
            // 
            // lblTrenutnoUAzilu
            // 
            this.lblTrenutnoUAzilu.AutoSize = true;
            this.lblTrenutnoUAzilu.Location = new System.Drawing.Point(202, 49);
            this.lblTrenutnoUAzilu.Name = "lblTrenutnoUAzilu";
            this.lblTrenutnoUAzilu.Size = new System.Drawing.Size(13, 16);
            this.lblTrenutnoUAzilu.TabIndex = 7;
            this.lblTrenutnoUAzilu.Text = "  ";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(149, 9);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(13, 16);
            this.lblUkupno.TabIndex = 8;
            this.lblUkupno.Text = "  ";
            // 
            // lbVrste
            // 
            this.lbVrste.FormattingEnabled = true;
            this.lbVrste.ItemHeight = 16;
            this.lbVrste.Location = new System.Drawing.Point(171, 163);
            this.lbVrste.Name = "lbVrste";
            this.lbVrste.Size = new System.Drawing.Size(190, 276);
            this.lbVrste.TabIndex = 9;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(404, 504);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(90, 23);
            this.btnPovratak.TabIndex = 10;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 539);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.lbVrste);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.lblTrenutnoUAzilu);
            this.Controls.Add(this.lblUdomljene);
            this.Controls.Add(this.lblProsjecnaDob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStatistika";
            this.Text = "frmStatistika";
            this.Load += new System.EventHandler(this.frmStatistika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProsjecnaDob;
        private System.Windows.Forms.Label lblUdomljene;
        private System.Windows.Forms.Label lblTrenutnoUAzilu;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.ListBox lbVrste;
        private System.Windows.Forms.Button btnPovratak;
    }
}