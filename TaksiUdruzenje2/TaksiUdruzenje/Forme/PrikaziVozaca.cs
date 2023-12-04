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
    public partial class PrikaziVozaca : Form
    {
        public PrikaziVozaca()
        {
            InitializeComponent();
        }

        private void btnVoznje_Click(object sender, EventArgs e)
        {
            if (vozaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozaca cija vozila zelite da prikazete!");
                return;
            }

            long jmbgVozaca = long.Parse(vozaci.SelectedItems[0].SubItems[0].Text);
            VozacPregled r = DTOManager.vratiVozaca(jmbgVozaca);
            VoznjeVozaca forma = new VoznjeVozaca(r);
            forma.ShowDialog();
        }

        private void Vozac_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            List<VozacPregled> listaOsoba = DTOManager.vratiSveVozace();

            foreach (VozacPregled r in listaOsoba)
            {
                ListViewItem item = new ListViewItem(new string[] { r.JMBG.ToString(), r.Ime, r.Prezime, r.BrVozackeDozvole.ToString(), r.Kategorija});
                this.vozaci.Items.Add(item);

            }

            this.vozaci.Refresh();
        }

        private void btnVozilo_Click(object sender, EventArgs e)
        {
            if (vozaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozaca cija vozila zelite da prikazete!");
                return;
            }

            long jmbgVozaca = long.Parse(vozaci.SelectedItems[0].SubItems[0].Text);
            VozacPregled r = DTOManager.vratiVozaca(jmbgVozaca);
            Koristi forma = new Koristi(r);
            forma.ShowDialog();


            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajVozaca forma = new DodajVozaca();
            forma.ShowDialog();
            this.vozaci.Items.Clear();
            popuniPodacima();
        }
    }
}
