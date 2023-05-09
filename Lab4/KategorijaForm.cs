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
    public partial class KategorijaForm : Form
    {
        public VozacBuilder vozacBuilder = VozacBuilder.Instance();
        public KategorijaForm()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            vozacBuilder.AddKategorija(new Kategorija
           (cmbPonudjeneKategorije.SelectedItem.ToString(), dtpDatumOd.Value, dtpDatumDo.Value));
        }
    }
}
