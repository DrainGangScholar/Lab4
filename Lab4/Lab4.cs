using Vozaci;
using static Vozaci.Delegati;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private ListaVozaca ListaVozaca;

        public Form1()
        {
            InitializeComponent();
            tmrTacnoVreme.Start();
            dataListaVozaca.DataSource=ListaVozaca.Instance.Vozaci.DodajVoza;
            
        }
        private void btnObrisiVozaca(object sender, EventArgs e)
        {
            Vozac vozac= (Vozac)dataListaVozaca.SelectedRows[0].DataBoundItem;
            ListaVozaca.Instance.RemoveVozac(vozac);
            dataListaVozaca.Refresh();
        }

        private void btnSortirajVozace(object sender, EventArgs e)
        {
            if(ListaVozaca.Instance.Vozaci.Count==0) { return; }
            Kriterijum? kriterijum = null;
            switch (cmbKriterijum.SelectedIndex)
            {
                case 0:
                    kriterijum = vozac => vozac.GetIme();
                    break;
                case 1:
                    kriterijum = vozac => vozac.GetPrezime();
                    break;
                case 2:
                    kriterijum = vozac => vozac.GetBrVozacke();
                    break;
                default:
                    return;
            }
            ListaVozaca.Instance.SortVozaci(kriterijum);
            dataListaVozaca.DataSource = ListaVozaca.Instance.Vozaci;
            dataListaVozaca.Refresh();
            MessageBox.Show($"Lista vozaca je uspešno sortirana {cmbKriterijum.SelectedItem}.", "Sortiranje liste", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmrTacnoVreme_Tick(object sender, EventArgs e)
        {
            lblTacnoVreme.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy.");
        }
    }
}