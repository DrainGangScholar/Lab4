﻿namespace Lab4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            "Broj Vozacke Dozvole",
            "Ime",
            "Prezime"});
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj Vozaca";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Izmeni Vozaca";
            this.button2.UseVisualStyleBackColor = true;
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
            this.button4.Text = "Sortiraj";
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTacnoVreme);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer tmrTacnoVreme;
        private Label lblTacnoVreme;
    }
}