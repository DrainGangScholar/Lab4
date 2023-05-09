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
            }
        }
        public VozacForm()
        {
            InitializeComponent();
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
            char pol = (char)cmbPol.SelectedText[0];

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

            var lol = Vozac.Builder()
                .SetIme(ime)
                .SetPrezime(prezime)
                .SetDatumRodjenja(datumRodjenja)
                .SetDatumOd(datumOd)
                .SetDatumDo(datumDo)
                .SetMestoIzdavanja(mestoIzdavanja)
                .SetBrVozacke(brVozacke)
                .SetPol(pol)
                .Build();
            ListaVozaca.Instance.AddVozac(lol);
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
                Zabrana selectedVozac = (Zabrana)selectedRow.DataBoundItem;
                int selectedIndex = datZabrane.SelectedRows[0].Index;
                datZabrane.Rows.RemoveAt(selectedIndex);
            }

        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (datPolozeneKategorije.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datPolozeneKategorije.SelectedRows[0];
                Kategorija selectedVozac = (Kategorija)selectedRow.DataBoundItem;
                int selectedIndex = datPolozeneKategorije.SelectedRows[0].Index;
                datPolozeneKategorije.Rows.RemoveAt(selectedIndex);
            }

        }
    }
}
