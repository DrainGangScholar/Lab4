namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataListaVozaca = new System.Windows.Forms.DataGridView();
            this.cmbKriterijum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajVozaca = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tmrTacnoVreme = new System.Windows.Forms.Timer(this.components);
            this.lblTacnoVreme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaVozaca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaVozaca
            // 
            this.dataListaVozaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaVozaca.Location = new System.Drawing.Point(12, 90);
            this.dataListaVozaca.Name = "dataListaVozaca";
            this.dataListaVozaca.RowTemplate.Height = 25;
            this.dataListaVozaca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListaVozaca.Size = new System.Drawing.Size(343, 282);
            this.dataListaVozaca.TabIndex = 0;
            // 
            // cmbKriterijum
            // 
            this.cmbKriterijum.FormattingEnabled = true;
            this.cmbKriterijum.Items.AddRange(new object[] {
            "Broju Vozacke Dozvole",
            "Imenu",
            "Prezimenu"});
            this.cmbKriterijum.Location = new System.Drawing.Point(361, 128);
            this.cmbKriterijum.Name = "cmbKriterijum";
            this.cmbKriterijum.Size = new System.Drawing.Size(159, 23);
            this.cmbKriterijum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista Vozaca";
            // 
            // btnDodajVozaca
            // 
            this.btnDodajVozaca.Location = new System.Drawing.Point(12, 378);
            this.btnDodajVozaca.Name = "btnDodajVozaca";
            this.btnDodajVozaca.Size = new System.Drawing.Size(178, 60);
            this.btnDodajVozaca.TabIndex = 4;
            this.btnDodajVozaca.Text = "Dodaj Vozaca";
            this.btnDodajVozaca.UseVisualStyleBackColor = true;
            this.btnDodajVozaca.Click += new System.EventHandler(this.btnDodajVozaca_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(196, 378);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(159, 60);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni Vozaca";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "Obrisi Vozaca";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnObrisiVozaca);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Sortiraj po";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnSortirajVozace);
            // 
            // tmrTacnoVreme
            // 
            this.tmrTacnoVreme.Interval = 1000;
            this.tmrTacnoVreme.Tick += new System.EventHandler(this.tmrTacnoVreme_Tick);
            // 
            // lblTacnoVreme
            // 
            this.lblTacnoVreme.AutoSize = true;
            this.lblTacnoVreme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTacnoVreme.Location = new System.Drawing.Point(12, 30);
            this.lblTacnoVreme.Name = "lblTacnoVreme";
            this.lblTacnoVreme.Size = new System.Drawing.Size(40, 15);
            this.lblTacnoVreme.TabIndex = 8;
            this.lblTacnoVreme.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.lblTacnoVreme);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodajVozaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKriterijum);
            this.Controls.Add(this.dataListaVozaca);
            this.Name = "Form1";
            this.Text = "Lista vozaca";
            ((System.ComponentModel.ISupportInitialize)(this.dataListaVozaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataListaVozaca;
        private ComboBox cmbKriterijum;
        private Label label1;
        private Button btnDodajVozaca;
        private Button btnIzmeni;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer tmrTacnoVreme;
        private Label lblTacnoVreme;
    }
}