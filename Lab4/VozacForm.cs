using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vozaci;

namespace Lab4
{
    public partial class VozacForm : Form
    {
        public ListaVozaca ListaVozaca;
        public VozacBuilder vozacBuilder = VozacBuilder.Instance();
        Vozac vozac;
        public string slikaPath;
        public VozacForm(Vozac vozac)
        {
            InitializeComponent();
            if (vozac != null)
            {
                datPolozeneKategorije.DataSource = vozac.PolozeneKategorije;
                datZabrane.DataSource = vozac.Zabrane;
                this.vozac = vozac;
                txtIme.Text = this.vozac.Ime;
                txtPrezime.Text = this.vozac.Prezime;
                dtpDatumRodjenja.Value = this.vozac.DatumRodjenja;
                dtpVozackaOd.Value = this.vozac.DatumOd;
                dtpVazenjeDo.Value = this.vozac.DatumDo;
                txtMesto.Text = this.vozac.MestoIzdavanja;
                txtBrVozacke.Text = this.vozac.BrVozacke;
                cmbPol.Items.Add('M');
                cmbPol.Items.Add('Z');
                if (this.vozac.Pol == 'M')
                {
                    cmbPol.SelectedIndex = 0;
                }
                else if (this.vozac.Pol == 'Z')
                {
                    cmbPol.SelectedIndex = 1;
                }
                else
                {
                    cmbPol.SelectedIndex = -1;
                }
                picSlika.ImageLocation = this.vozac.ImagePath;
            }
        }
        public VozacForm()
        {
            InitializeComponent();
            cmbPol.Items.Add('M');
            cmbPol.Items.Add('Z');
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            KategorijaForm kategorijaForm= new KategorijaForm();
            kategorijaForm.FormClosing += (s, args) => this.Visible = true;
            kategorijaForm.Show();
            this.Hide();
        }

        private void btnDodajZabranu_Click(object sender, EventArgs e)
        {
            if (vozac!=null) {
                ZabranaForm zabranaForm = new ZabranaForm(vozac.PolozeneKategorije);
                zabranaForm.FormClosing += (s, args) => this.Visible = true;
                zabranaForm.Show();
                this.Hide();
            }
        }
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            var datumRodjenja = dtpDatumRodjenja.Value;
            var datumOd = dtpVozackaOd.Value;
            var datumDo = dtpVazenjeDo.Value;
            string mestoIzdavanja = txtMesto.Text;
            string brVozacke = txtBrVozacke.Text;
            string selectedPol = cmbPol.SelectedItem.ToString();
            char pol;
            if (selectedPol == "Z")
                pol = 'Z';
            else
                pol = 'M';

            if (String.IsNullOrWhiteSpace(ime))
            {
                MessageBox.Show("Morate uneti ime.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(prezime))
            {
                MessageBox.Show("Morate uneti prezime.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(mestoIzdavanja))
            {
                MessageBox.Show("Morate uneti mesto izdavanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(brVozacke))
            {
                MessageBox.Show("Morate uneti broj vozačke dozvole.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(slikaPath))
            {
                MessageBox.Show("Niste izabrali sliku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var vozac = ListaVozaca.Instance.Vozaci.Where(p =>p.Ime==ime && p.Prezime==prezime || p.DatumRodjenja==datumRodjenja && p.BrVozacke==brVozacke).FirstOrDefault();
            if (vozac != null)
            {
                vozac.Ime = ime;
                vozac.Prezime = prezime;
                vozac.DatumRodjenja = datumRodjenja;
                vozac.DatumOd = datumOd;
                vozac.DatumDo=datumDo;
                vozac.MestoIzdavanja= mestoIzdavanja;
                vozac.BrVozacke=brVozacke;
                vozac.Pol = pol;
                vozac.ImagePath = slikaPath;
                this.Close();
            }
            else {
                var lol = Vozac.Builder()
                    .SetIme(ime)
                    .SetPrezime(prezime)
                    .SetDatumRodjenja(datumRodjenja)
                    .SetDatumOd(datumOd)
                    .SetDatumDo(datumDo)
                    .SetMestoIzdavanja(mestoIzdavanja)
                    .SetBrVozacke(brVozacke)
                    .SetPol(pol)
                    .SetImagePath(slikaPath)
                .Build();
            ListaVozaca.Instance.AddVozac(lol);
            }
            this.Close();
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Zabranjen je unos karaktera koji nisu slova.");
            }
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Zabranjen je unos karaktera koji nisu slova.");
            }
        }

        private void btnObrisiZabranu_Click(object sender, EventArgs e)
        {
            if (datZabrane.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datZabrane.SelectedRows[0];
                Zabrana selectedZabrana = (Zabrana)selectedRow.DataBoundItem;
                vozac.Zabrane.Remove(selectedZabrana);
                datZabrane.DataSource = null;
                datZabrane.DataSource = vozac.Zabrane;
            }

        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (datPolozeneKategorije.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datPolozeneKategorije.SelectedRows[0];
                Kategorija selectedKategorija = (Kategorija)selectedRow.DataBoundItem;
                vozac.PolozeneKategorije.Remove(selectedKategorija);
                datPolozeneKategorije.DataSource = null;
                datPolozeneKategorije.DataSource = vozac.PolozeneKategorije;
            }

        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imgPath = openFileDialog.FileName;
                // Load the image from file and set it as the Image property of the PictureBox control
                picSlika.Image = Image.FromFile(imgPath);
                // Save the path of the selected image file to the Vozac object
                    slikaPath = imgPath;
            }
        }
    }
}
