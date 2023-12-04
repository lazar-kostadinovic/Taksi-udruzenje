using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Forme
{
    public partial class PrikaziSopstvenaVozila : Form
    {
        public PrikaziSopstvenaVozila()
        {
            InitializeComponent();
        }

        private void PrikaziSopstvenaVozila_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<SopstvenoVoziloPregled> listaVozila = DTOManager.vratiSvaSopstvenaVozila();

            foreach (SopstvenoVoziloPregled r in listaVozila)
            {
                ListViewItem item = new ListViewItem(new string[] { r.ID.ToString(), r.Marka, r.Tip, r.Boja});
                this.vozila.Items.Add(item);

            }

            this.vozila.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajSopVozilo forma = new DodajSopVozilo();
            forma.ShowDialog();
            this.vozila.Items.Clear();
            popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (vozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo kojo zelite da izmenite!");
                return;
            }

            int idVozila = int.Parse(vozila.SelectedItems[0].SubItems[0].Text);
            SopstvenoVoziloPregled r = DTOManager.vratiSopstvenoVozilo(idVozila);
            IzmeniSopVozilo forma = new IzmeniSopVozilo(r);
            this.vozila.Items.Clear();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnVoznje_Click(object sender, EventArgs e)
        {
       
        }
    }
}
