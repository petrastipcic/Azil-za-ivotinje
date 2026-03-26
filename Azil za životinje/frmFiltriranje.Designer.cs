namespace Azil_za_životinje
{
    partial class frmFiltriranje
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
            this.cbFiltriranje = new System.Windows.Forms.ComboBox();
            this.ListaŽivotinja = new System.Windows.Forms.ListBox();
            this.btnResetFiltera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFiltriranje
            // 
            this.cbFiltriranje.FormattingEnabled = true;
            this.cbFiltriranje.Location = new System.Drawing.Point(12, 12);
            this.cbFiltriranje.Name = "cbFiltriranje";
            this.cbFiltriranje.Size = new System.Drawing.Size(232, 21);
            this.cbFiltriranje.TabIndex = 0;
            // 
            // ListaŽivotinja
            // 
            this.ListaŽivotinja.FormattingEnabled = true;
            this.ListaŽivotinja.Location = new System.Drawing.Point(12, 39);
            this.ListaŽivotinja.Name = "ListaŽivotinja";
            this.ListaŽivotinja.Size = new System.Drawing.Size(232, 199);
            this.ListaŽivotinja.TabIndex = 2;
            // 
            // btnResetFiltera
            // 
            this.btnResetFiltera.Location = new System.Drawing.Point(84, 244);
            this.btnResetFiltera.Name = "btnResetFiltera";
            this.btnResetFiltera.Size = new System.Drawing.Size(75, 23);
            this.btnResetFiltera.TabIndex = 3;
            this.btnResetFiltera.Text = "Reset filtera";
            this.btnResetFiltera.UseVisualStyleBackColor = true;
            // 
            // frmFiltriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetFiltera);
            this.Controls.Add(this.ListaŽivotinja);
            this.Controls.Add(this.cbFiltriranje);
            this.Name = "frmFiltriranje";
            this.Text = "frmFiltriranje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFiltriranje;
        private System.Windows.Forms.ListBox ListaŽivotinja;
        private System.Windows.Forms.Button btnResetFiltera;
    }
}