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
    public partial class PrikaziOsobu : Form
    {
        OsobaBasic osoba;
        public PrikaziOsobu( )
        {
            InitializeComponent();
          
        }

        private void osobe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrikaziOsobu_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {        
            List<OsobaBasic> listaOsoba = DTOManager.vratiSveOsobeBasic();
         
            foreach (OsobaBasic r in listaOsoba)
            {
               
                ListViewItem item = new ListViewItem(new string[] { r.JMBG.ToString(), r.Ime, r.SrednjeSlovo.ToString(), r.Prezime, r.Adresa, r.BrojTelefona.ToString() });
                this.osobe.Items.Add(item);

            }

            this.osobe.Refresh();
        }

        private void btnDodajOsobu_Click(object sender, EventArgs e)
        {
            DodajOsobu forma = new DodajOsobu();
            forma.ShowDialog();
            this.osobe.Items.Clear();
            popuniPodacima();
        }

        private void btnIzmeniOsobu_Click(object sender, EventArgs e)
        {
            if (osobe.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite osobu koju zelite da izmenite!");
                return;
            }

            long jmbgOsobe = long.Parse(osobe.SelectedItems[0].SubItems[0].Text);
            OsobaBasic r = DTOManager.vratiOsobe(jmbgOsobe);
            IzmeniOsobu forma = new IzmeniOsobu(r);
            this.osobe.Items.Clear();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            if (osobe.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite osobu koju zelite da obrisete!");
                return;
            }

            long jmbgOsobe = long.Parse(osobe.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu osobu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiOsobu(jmbgOsobe);
                MessageBox.Show("Brisanje osobe je uspesno obavljeno!");
                this.osobe.Items.Clear();
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnAdmOsoblje_Click(object sender, EventArgs e)
        {

            PrikaziAdministrativnoOsoblje forma = new PrikaziAdministrativnoOsoblje();
            forma.ShowDialog();
        }

        private void btnVozaci_Click(object sender, EventArgs e)
        {
            PrikaziVozaca forma = new PrikaziVozaca();
            forma.ShowDialog();
        }
    }
}
