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
    public partial class PrikaziVozilaTaksiSluzbe : Form
    {
        public PrikaziVozilaTaksiSluzbe()
        {
            InitializeComponent();
        }

        private void PrikaziVozilaTaksiSluzbe_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<VoziloTaksiSluzbePregled> listaVozila = DTOManager.vratiSvaVozilaTaksiSluzbe();

            foreach (VoziloTaksiSluzbePregled r in listaVozila)
            {
                ListViewItem item = new ListViewItem(new string[] { r.ID.ToString(), r.Marka, r.Tip, r.GodinaProizvodnje.ToString(),r.DatumIstekaRegistracije.ToString(),r.RegistarskaOznaka });
                this.vozila.Items.Add(item);

            }

            this.vozila.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajVoziloTaksiSluzbe forma = new DodajVoziloTaksiSluzbe();
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
            VoziloTaksiSluzbePregled r = DTOManager.vratiVoziloTaksiSluzbe(idVozila);
            IzmeniVoziloTaksiSluzbe forma = new IzmeniVoziloTaksiSluzbe(r);
            this.vozila.Items.Clear();
            forma.ShowDialog();
            popuniPodacima();
        }

     
    }
}
