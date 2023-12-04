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
    public partial class PrikaziVozila : Form
    {
        VoziloPregled vozilo;
        public PrikaziVozila()
        {
            InitializeComponent();
        }

        private void PrikaziVozila_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<VoziloPregled> listaVozila = DTOManager.vratiSvaVozila();

            foreach (VoziloPregled r in listaVozila)
            {

                ListViewItem item = new ListViewItem(new string[] { r.ID.ToString(),r.Marka,r.Tip });
                this.vozila.Items.Add(item);

            }

            this.vozila.Refresh();
        }

        private void btnVozilaTaksiSluzbe_Click(object sender, EventArgs e)
        {
            PrikaziVozilaTaksiSluzbe forma = new PrikaziVozilaTaksiSluzbe();
            forma.ShowDialog();
        }

        private void btnSopVozila_Click(object sender, EventArgs e)
        {
            PrikaziSopstvenaVozila forma = new PrikaziSopstvenaVozila();
            forma.ShowDialog();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            DodajVozilo forma = new DodajVozilo();
            forma.ShowDialog();
            this.vozila.Items.Clear();
            popuniPodacima();
        }

     

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (vozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje zelite da obrisete!");
                return;
            }

            int idVozila = int.Parse(vozila.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano vozilo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVozilo(idVozila);
                MessageBox.Show("Brisanje vozila je uspesno obavljeno!");
                this.vozila.Items.Clear();
                this.popuniPodacima();
            }
            else
            {

            }

        }
    }
}
