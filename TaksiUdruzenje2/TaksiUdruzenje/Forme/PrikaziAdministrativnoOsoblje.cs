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
    public partial class PrikaziAdministrativnoOsoblje : Form
    {
        public PrikaziAdministrativnoOsoblje()
        {
            InitializeComponent();
        }

        private void PrikaziAdministrativnoOsoblje_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            List<AdministartivnoOsobljeBasic> listaOsoba = DTOManager.vratiSvoAdmnistrativnoOsoblje();
          
            foreach (AdministartivnoOsobljeBasic r in listaOsoba)
            {
                ListViewItem item = new ListViewItem(new string[] { r.JMBG.ToString(), r.Ime, r.Prezime, r.StrucnaSprema});
                this.osoblje.Items.Add(item);

            }

            this.osoblje.Refresh();
        }

        private void btnVoznje_Click(object sender, EventArgs e)
        {
            if (osoblje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite administrativno osoblje cije voznje zelite da prikazete!");
                return;
            }
            long jmbgAdm = long.Parse(osoblje.SelectedItems[0].SubItems[0].Text);
            AdministartivnoOsobljeBasic r = DTOManager.vratiAdministartivnoOsoblje(jmbgAdm);
            VoznjeAdministratora forma = new VoznjeAdministratora(r);
            forma.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajAdmOsoblje forma = new DodajAdmOsoblje();
            forma.ShowDialog();
            this.osoblje.Items.Clear();
            popuniPodacima();
        }
    }
}
