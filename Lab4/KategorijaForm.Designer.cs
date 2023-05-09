namespace Lab4
{
    partial class KategorijaForm
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
            this.lblKategorija = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.cmbPonudjeneKategorije = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(109, 41);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(63, 15);
            this.lblKategorija.TabIndex = 0;
            this.lblKategorija.Text = "Kategorije:";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.AccessibleName = "";
            this.dtpDatumOd.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOd.Location = new System.Drawing.Point(178, 62);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(121, 23);
            this.dtpDatumOd.TabIndex = 2;
            // 
            // cmbPonudjeneKategorije
            // 
            this.cmbPonudjeneKategorije.FormattingEnabled = true;
            this.cmbPonudjeneKategorije.Items.AddRange(new object[] {
            "AM",
            "A1",
            "A2",
            "A",
            "B1",
            "BE",
            "C1",
            "C1E",
            "C",
            "D1",
            "D1E",
            "D",
            "DE",
            "F",
            "M"});
            this.cmbPonudjeneKategorije.Location = new System.Drawing.Point(178, 33);
            this.cmbPonudjeneKategorije.Name = "cmbPonudjeneKategorije";
            this.cmbPonudjeneKategorije.Size = new System.Drawing.Size(121, 23);
            this.cmbPonudjeneKategorije.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum od:";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDo.Location = new System.Drawing.Point(178, 91);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(121, 23);
            this.dtpDatumDo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum do:";
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(178, 120);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(58, 23);
            this.btnProsledi.TabIndex = 7;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(242, 120);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(57, 23);
            this.btnZatvori.TabIndex = 8;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // KategorijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 221);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPonudjeneKategorije);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.lblKategorija);
            this.Name = "KategorijaForm";
            this.Text = "KategorijaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKategorija;
        private DateTimePicker dtpDatumOd;
        private ComboBox cmbPonudjeneKategorije;
        private Label label1;
        private DateTimePicker dtpDatumDo;
        private Label label2;
        private Button btnProsledi;
        private Button btnZatvori;
    }
}