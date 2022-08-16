
namespace P04AplikacjaZawodnicy
{
    partial class FrmSzczegoly
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
            this.txtImieZawodnika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwiskoZawodnika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKrajZawodnika = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImieTrenera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazwiskoTrenera = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImieZawodnika
            // 
            this.txtImieZawodnika.Location = new System.Drawing.Point(137, 29);
            this.txtImieZawodnika.Name = "txtImieZawodnika";
            this.txtImieZawodnika.Size = new System.Drawing.Size(100, 20);
            this.txtImieZawodnika.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie zawodnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko zawodnika";
            // 
            // txtNazwiskoZawodnika
            // 
            this.txtNazwiskoZawodnika.Location = new System.Drawing.Point(137, 55);
            this.txtNazwiskoZawodnika.Name = "txtNazwiskoZawodnika";
            this.txtNazwiskoZawodnika.Size = new System.Drawing.Size(100, 20);
            this.txtNazwiskoZawodnika.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kraj zawodnika";
            // 
            // txtKrajZawodnika
            // 
            this.txtKrajZawodnika.Location = new System.Drawing.Point(137, 81);
            this.txtKrajZawodnika.Name = "txtKrajZawodnika";
            this.txtKrajZawodnika.Size = new System.Drawing.Size(100, 20);
            this.txtKrajZawodnika.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Imie trenera";
            // 
            // txtImieTrenera
            // 
            this.txtImieTrenera.Location = new System.Drawing.Point(137, 107);
            this.txtImieTrenera.Name = "txtImieTrenera";
            this.txtImieTrenera.Size = new System.Drawing.Size(100, 20);
            this.txtImieTrenera.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nazwisko trenera";
            // 
            // txtNazwiskoTrenera
            // 
            this.txtNazwiskoTrenera.Location = new System.Drawing.Point(137, 133);
            this.txtNazwiskoTrenera.Name = "txtNazwiskoTrenera";
            this.txtNazwiskoTrenera.Size = new System.Drawing.Size(100, 20);
            this.txtNazwiskoTrenera.TabIndex = 8;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(162, 169);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 10;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 211);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNazwiskoTrenera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImieTrenera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKrajZawodnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwiskoZawodnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImieZawodnika);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImieZawodnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwiskoZawodnika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKrajZawodnika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImieTrenera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazwiskoTrenera;
        private System.Windows.Forms.Button btnZapisz;
    }
}