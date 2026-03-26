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
            this.ListaŽivotinja = new System.Windows.Forms.ListBox();
            this.pbZivotinja = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbZivotinja)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaŽivotinja
            // 
            this.ListaŽivotinja.FormattingEnabled = true;
            this.ListaŽivotinja.Location = new System.Drawing.Point(12, 12);
            this.ListaŽivotinja.Name = "ListaŽivotinja";
            this.ListaŽivotinja.Size = new System.Drawing.Size(203, 407);
            this.ListaŽivotinja.TabIndex = 0;
            // 
            // pbZivotinja
            // 
            this.pbZivotinja.Location = new System.Drawing.Point(221, 62);
            this.pbZivotinja.Name = "pbZivotinja";
            this.pbZivotinja.Size = new System.Drawing.Size(326, 301);
            this.pbZivotinja.TabIndex = 1;
            this.pbZivotinja.TabStop = false;
            // 
            // frmPregledZivotinja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbZivotinja);
            this.Controls.Add(this.ListaŽivotinja);
            this.Name = "frmPregledZivotinja";
            this.Text = "frmPregledZivotinja";
            this.Load += new System.EventHandler(this.frmPregledZivotinja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbZivotinja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaŽivotinja;
        private System.Windows.Forms.PictureBox pbZivotinja;
    }
}