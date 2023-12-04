using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaksiUdruzenje.Forme
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }


        private void btnMusterije_Click(object sender, EventArgs e)
        {
            PrikaziMusterije forma = new PrikaziMusterije();
            forma.ShowDialog();
        }

        private void buttonVozila_Click(object sender, EventArgs e)
        {
            PrikaziVozila forma = new PrikaziVozila();
            forma.ShowDialog();
        }

        private void btnVoznje_Click(object sender, EventArgs e)
        {
            PrikaziVoznje forma = new PrikaziVoznje();
            forma.ShowDialog();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            PrikaziOsobu forma = new PrikaziOsobu();
            forma.ShowDialog();
        }

        private void PocetnaStranica_Load(object sender, EventArgs e)
        {

        }
    }
}
