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
    public partial class VoznjeVozaca : Form
    {
        VozacPregled vozac;
        public VoznjeVozaca(VozacPregled vozac)
        {
            InitializeComponent();
            this.vozac = vozac; 
        }

        private void VoznjeVozaca_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<VoznjaBasic> listaVoznji = DTOManager.vratiSveVoznjeVozaca(vozac.JMBG);

            foreach (VoznjaBasic r in listaVoznji)
            {

                ListViewItem item = new ListViewItem(new string[] { r.ID.ToString(), r.VremePocetkaVoznje.ToString(), r.VremeKrajaVoznje.ToString(), r.PocetnaStanica, r.KrajnjaStanica, r.VremePrimanjaPoziva.ToString(), r.Vozac.JMBG.ToString(), r.Musterija.ID.ToString(), r.AdministrativnoOsoblje.JMBG.ToString() });
                this.Voznje.Items.Add(item);
         

            }

            this.Voznje.Refresh();

        }
    }
}
