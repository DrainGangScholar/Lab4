namespace Lab4
{
    partial class VozacForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.Pol = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.dtpVozackaOd = new System.Windows.Forms.DateTimePicker();
            this.dtpVazenjeDo = new System.Windows.Forms.DateTimePicker();
            this.txtBrVozacke = new System.Windows.Forms.TextBox();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.picSlika = new System.Windows.Forms.PictureBox();
            this.lstKategorija = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.btnObrisiKategoriju = new System.Windows.Forms.Button();
            this.Kategorija = new System.Windows.Forms.Label();
            this.lstZabrana = new System.Windows.Forms.ListBox();
            this.btnDodajZabranu = new System.Windows.Forms.Button();
            this.btnObrisiZabranu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezima:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rodjenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vazenje dozvole od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "do:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Br. vozacke dozvole:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mesto izdavanja:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(131, 6);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 23);
            this.txtIme.TabIndex = 7;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(131, 33);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 23);
            this.txtPrezime.TabIndex = 8;
            // 
            // Pol
            // 
            this.Pol.AutoSize = true;
            this.Pol.Location = new System.Drawing.Point(98, 208);
            this.Pol.Name = "Pol";
            this.Pol.Size = new System.Drawing.Size(27, 15);
            this.Pol.TabIndex = 9;
            this.Pol.Text = "Pol:";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(131, 62);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(100, 23);
            this.dtpDatumRodjenja.TabIndex = 10;
            // 
            // dtpVozackaOd
            // 
            this.dtpVozackaOd.CustomFormat = "dd.MM.yyyy.";
            this.dtpVozackaOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVozackaOd.Location = new System.Drawing.Point(131, 91);
            this.dtpVozackaOd.Name = "dtpVozackaOd";
            this.dtpVozackaOd.Size = new System.Drawing.Size(100, 23);
            this.dtpVozackaOd.TabIndex = 11;
            // 
            // dtpVazenjeDo
            // 
            this.dtpVazenjeDo.CustomFormat = "dd.MM.yyyy.";
            this.dtpVazenjeDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVazenjeDo.Location = new System.Drawing.Point(131, 120);
            this.dtpVazenjeDo.Name = "dtpVazenjeDo";
            this.dtpVazenjeDo.Size = new System.Drawing.Size(100, 23);
            this.dtpVazenjeDo.TabIndex = 12;
            // 
            // txtBrVozacke
            // 
            this.txtBrVozacke.Location = new System.Drawing.Point(131, 149);
            this.txtBrVozacke.Name = "txtBrVozacke";
            this.txtBrVozacke.Size = new System.Drawing.Size(100, 23);
            this.txtBrVozacke.TabIndex = 13;
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(131, 179);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(100, 23);
            this.txtMesto.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.listBox1.Location = new System.Drawing.Point(131, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 19);
            this.listBox1.TabIndex = 14;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(328, 204);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 15;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // picSlika
            // 
            this.picSlika.Location = new System.Drawing.Point(277, 12);
            this.picSlika.Name = "picSlika";
            this.picSlika.Size = new System.Drawing.Size(180, 180);
            this.picSlika.TabIndex = 16;
            this.picSlika.TabStop = false;
            // 
            // lstKategorija
            // 
            this.lstKategorija.FormattingEnabled = true;
            this.lstKategorija.ItemHeight = 15;
            this.lstKategorija.Location = new System.Drawing.Point(131, 299);
            this.lstKategorija.Name = "lstKategorija";
            this.lstKategorija.Size = new System.Drawing.Size(326, 94);
            this.lstKategorija.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kategorija";
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Location = new System.Drawing.Point(131, 399);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(157, 36);
            this.btnDodajKategoriju.TabIndex = 19;
            this.btnDodajKategoriju.Text = "Dodaj novu kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            // 
            // btnObrisiKategoriju
            // 
            this.btnObrisiKategoriju.Location = new System.Drawing.Point(294, 399);
            this.btnObrisiKategoriju.Name = "btnObrisiKategoriju";
            this.btnObrisiKategoriju.Size = new System.Drawing.Size(163, 36);
            this.btnObrisiKategoriju.TabIndex = 20;
            this.btnObrisiKategoriju.Text = "Obrisi kategoriju";
            this.btnObrisiKategoriju.UseVisualStyleBackColor = true;
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSize = true;
            this.Kategorija.Location = new System.Drawing.Point(131, 463);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(112, 15);
            this.Kategorija.TabIndex = 21;
            this.Kategorija.Text = "Zabrana Upravljanja";
            // 
            // lstZabrana
            // 
            this.lstZabrana.FormattingEnabled = true;
            this.lstZabrana.ItemHeight = 15;
            this.lstZabrana.Location = new System.Drawing.Point(131, 497);
            this.lstZabrana.Name = "lstZabrana";
            this.lstZabrana.Size = new System.Drawing.Size(326, 94);
            this.lstZabrana.TabIndex = 22;
            // 
            // btnDodajZabranu
            // 
            this.btnDodajZabranu.Location = new System.Drawing.Point(131, 597);
            this.btnDodajZabranu.Name = "btnDodajZabranu";
            this.btnDodajZabranu.Size = new System.Drawing.Size(157, 36);
            this.btnDodajZabranu.TabIndex = 23;
            this.btnDodajZabranu.Text = "Dodaj novu zabranu";
            this.btnDodajZabranu.UseVisualStyleBackColor = true;
            // 
            // btnObrisiZabranu
            // 
            this.btnObrisiZabranu.Location = new System.Drawing.Point(300, 596);
            this.btnObrisiZabranu.Name = "btnObrisiZabranu";
            this.btnObrisiZabranu.Size = new System.Drawing.Size(157, 37);
            this.btnObrisiZabranu.TabIndex = 24;
            this.btnObrisiZabranu.Text = "Obrisi zabranu";
            this.btnObrisiZabranu.UseVisualStyleBackColor = true;
            // 
            // VozacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 801);
            this.Controls.Add(this.btnObrisiZabranu);
            this.Controls.Add(this.btnDodajZabranu);
            this.Controls.Add(this.lstZabrana);
            this.Controls.Add(this.Kategorija);
            this.Controls.Add(this.btnObrisiKategoriju);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstKategorija);
            this.Controls.Add(this.picSlika);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.txtBrVozacke);
            this.Controls.Add(this.dtpVazenjeDo);
            this.Controls.Add(this.dtpVozackaOd);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.Pol);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VozacForm";
            this.Text = "VozacForm";
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private Label Pol;
        private DateTimePicker dtpDatumRodjenja;
        private DateTimePicker dtpVozackaOd;
        private DateTimePicker dtpVazenjeDo;
        private TextBox txtBrVozacke;
        private TextBox txtMesto;
        private ListBox listBox1;
        private Button btnDodajSliku;
        private PictureBox picSlika;
        private ListBox lstKategorija;
        private Label label8;
        private Button btnDodajKategoriju;
        private Button btnObrisiKategoriju;
        private Label Kategorija;
        private ListBox lstZabrana;
        private Button btnDodajZabranu;
        private Button btnObrisiZabranu;
    }
}