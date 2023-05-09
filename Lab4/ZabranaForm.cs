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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class ZabranaForm : Form
    {
        public VozacBuilder vozacBuilder=VozacBuilder.Instance();

        public ZabranaForm()
        {
            InitializeComponent();
            cmbKategorije.Items.Clear();
            var lista = vozacBuilder.GetKategorije();
            foreach (var kategorija in lista)
            {
                cmbKategorije.Items.Add(kategorija.Ime);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            vozacBuilder.AddZabrana(new Zabrana
            (cmbKategorije.SelectedItem.ToString(), dateTimePicker1.Value, dateTimePicker2.Value));
        }
    }
}
