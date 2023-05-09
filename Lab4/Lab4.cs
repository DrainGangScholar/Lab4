using System.Windows.Forms;
using Vozaci;
using static Vozaci.Delegati;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public ListaVozaca ListaVozaca;
        public Form1()
        {
            InitializeComponent();
            tmrTacnoVreme.Start();
            Vozac vozac1 = new Vozac("Mary", "Johnson", "5553335", new DateTime(1980, 1, 1), new DateTime(2020, 1, 1), new DateTime(2030, 1, 1), "New York",'Z', new List<Kategorija>(), new List<Zabrana>());
            vozac1.AddKategorija(new Kategorija("A", new DateTime(2020, 1, 1), new DateTime(2030, 1, 1)));
            vozac1.AddKategorija(new Kategorija("B", new DateTime(2022, 1, 1), new DateTime(2032, 1, 1)));
            vozac1.AddKategorija(new Kategorija("C", new DateTime(2024, 1, 1), new DateTime(2034, 1, 1)));

            Vozac vozac2 = new Vozac("James", "Williams", "5553336", new DateTime(1982, 2, 2), new DateTime(2019, 1, 1), new DateTime(2029, 1, 1), "Los Angeles", 'M', new List<Kategorija>(), new List<Zabrana>());
            vozac2.AddKategorija(new Kategorija("A", new DateTime(2019, 1, 1), new DateTime(2029, 1, 1)));
            vozac2.AddKategorija(new Kategorija("B", new DateTime(2021, 1, 1), new DateTime(2031, 1, 1)));
            vozac2.AddKategorija(new Kategorija("C", new DateTime(2023, 1, 1), new DateTime(2033, 1, 1)));

            Vozac vozac3 = new Vozac("Patricia", "Brown", "5553337", new DateTime(1984, 3, 3), new DateTime(2018, 1, 1), new DateTime(2028, 1, 1), "Chicago", 'Z', new List<Kategorija>(), new List<Zabrana>() );
            vozac3.AddKategorija(new Kategorija("A", new DateTime(2018, 1, 1), new DateTime(2028, 1, 1)));
            vozac3.AddKategorija(new Kategorija("B", new DateTime(2020, 1, 1), new DateTime(2030, 1, 1)));
            vozac3.AddKategorija(new Kategorija("C", new DateTime(2022, 1, 1), new DateTime(2032, 1, 1)));

            Vozac vozac4 = new Vozac("Michael", "Jones", "5553338", new DateTime(1986, 4, 4), new DateTime(2017, 1, 1), new DateTime(2027, 1, 1), "Houston", 'M', new List<Kategorija>(), new List<Zabrana>());
            vozac4.AddKategorija(new Kategorija("A", new DateTime(2017, 1, 1), new DateTime(2027, 1, 1)));
            vozac4.AddKategorija(new Kategorija("B", new DateTime(2019, 1, 1), new DateTime(2029, 1, 1)));

            ListaVozaca.Instance.AddVozac(vozac1);
            ListaVozaca.Instance.AddVozac(vozac2);
            ListaVozaca.Instance.AddVozac(vozac3);
            ListaVozaca.Instance.AddVozac(vozac4);


            dataListaVozaca.DataSource=ListaVozaca.Instance.Vozaci;
            
        }
        private void btnObrisiVozaca(object sender, EventArgs e)
        {
            Vozac vozac= (Vozac)dataListaVozaca.SelectedRows[0].DataBoundItem;
            ListaVozaca.Instance.RemoveVozac(vozac);
            dataListaVozaca.DataSource = null;
            dataListaVozaca.DataSource = ListaVozaca.Instance.Vozaci;
            dataListaVozaca.Refresh();
            MessageBox.Show($"Izbrisani Vozac: {vozac.Ime} {vozac.Prezime}, {vozac.BrVozacke}", "Uspešno izbrisano", MessageBoxButtons.OK);
        }

        private void btnSortirajVozace(object sender, EventArgs e)
        {
            if(ListaVozaca.Instance.Vozaci.Count==0) { return; }
            Kriterijum? kriterijum = null;
            switch (cmbKriterijum.SelectedIndex)
            {
                case 0:
                    kriterijum = vozac => vozac.GetBrVozacke();
                    break;
                case 1:
                    kriterijum = vozac => vozac.GetIme();
                    break;
                case 2:
                    kriterijum = vozac => vozac.GetPrezime();
                    break;
                default:
                    return;
            }
            ListaVozaca.Instance.SortVozaci(kriterijum);
            dataListaVozaca.DataSource = ListaVozaca.Instance.Vozaci;
            dataListaVozaca.Refresh();
            MessageBox.Show($"Lista vozaca je uspešno sortirana po {cmbKriterijum.SelectedItem}.", "Sortiranje liste", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmrTacnoVreme_Tick(object sender, EventArgs e)
        {
            lblTacnoVreme.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy.");
        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            VozacForm vozacForm = new VozacForm();
            vozacForm.FormClosing += (s, args) => this.Visible = true;
            vozacForm.Show();
            this.Hide();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataListaVozaca.SelectedRows[0];
            Vozac selectedVozac = (Vozac)selectedRow.DataBoundItem;
            VozacForm vozacForm = new VozacForm(selectedVozac);
            vozacForm.FormClosing += (s, args) => this.Visible = true;
            vozacForm.Show();
            this.Hide();

        }
    }
}