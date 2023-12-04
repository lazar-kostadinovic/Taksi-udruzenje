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
    public partial class VoznjeMusterije : Form
    {
        MusterijaBasic musterija;
        public VoznjeMusterije(MusterijaBasic musterija)
        {
            InitializeComponent();
            this.musterija = musterija; 
        }

        private void VoznjeMusterije_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<VoznjaBasic> listaVoznji = DTOManager.vratiSveVoznjeMusterije(musterija.ID);

            foreach (VoznjaBasic r in listaVoznji)
            {

                ListViewItem item = new ListViewItem(new string[] { r.ID.ToString(), r.VremePocetkaVoznje.ToString(), r.VremeKrajaVoznje.ToString(), r.PocetnaStanica, r.KrajnjaStanica, r.VremePrimanjaPoziva.ToString(), r.Vozac.JMBG.ToString(), r.Musterija.ID.ToString(), r.AdministrativnoOsoblje.JMBG.ToString() });
                this.Voznje.Items.Add(item);


            }

            this.Voznje.Refresh();

        }
    }
}
