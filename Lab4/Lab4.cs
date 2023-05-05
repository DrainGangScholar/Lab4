using System.Windows.Forms;
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
            Vozac vozac1 = new Vozac("Mary", "Johnson", "5553335");
            Vozac vozac2 = new Vozac("James", "Williams", "5553336");
            Vozac vozac3 = new Vozac("Patricia", "Brown", "5553337");
            Vozac vozac4 = new Vozac("Michael", "Jones", "5553338");
            Vozac vozac5 = new Vozac("Linda", "Garcia", "5553339");
            Vozac vozac6 = new Vozac("David", "Miller", "5553340");
            Vozac vozac7 = new Vozac("Karen", "Davis", "5553341");
            Vozac vozac8 = new Vozac("Richard", "Wilson", "5553342");
            Vozac vozac9 = new Vozac("Susan", "Moore", "5553343");
            Vozac vozac10 = new Vozac("Joseph", "Martin", "5553344");

            ListaVozaca.Instance.AddVozac(vozac1);
            ListaVozaca.Instance.AddVozac(vozac2);
            ListaVozaca.Instance.AddVozac(vozac3);
            ListaVozaca.Instance.AddVozac(vozac4);
            ListaVozaca.Instance.AddVozac(vozac5);
            ListaVozaca.Instance.AddVozac(vozac6);
            ListaVozaca.Instance.AddVozac(vozac7);
            ListaVozaca.Instance.AddVozac(vozac8);
            ListaVozaca.Instance.AddVozac(vozac9);
            ListaVozaca.Instance.AddVozac(vozac10);


            dataListaVozaca.DataSource=ListaVozaca.Instance.Vozaci;
            
        }
        private void btnObrisiVozaca(object sender, EventArgs e)
        {
            Vozac vozac= (Vozac)dataListaVozaca.SelectedRows[0].DataBoundItem;
            ListaVozaca.Instance.RemoveVozac(vozac);
            dataListaVozaca.DataSource = null;
            dataListaVozaca.DataSource = ListaVozaca.Instance.Vozaci;
            dataListaVozaca.Refresh();
            MessageBox.Show($"Izbrisani Vozac: {vozac.Ime} {vozac.Prezime}, {vozac.BrVozacke}", "Uspešno izbrisano", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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
    }
}