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
    public partial class VoznjeAdministratora : Form
    {
        AdministartivnoOsobljeBasic adm;
       
     
        public VoznjeAdministratora(AdministartivnoOsobljeBasic adm)
        {
            InitializeComponent();
            this.adm = adm;
        }
      


        private void VoznjeAdministratora_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {          
            List<VoznjaBasic> listaKoristi = DTOManager.vratiSveVoznjeAdm(adm.JMBG);

            foreach (VoznjaBasic r in listaKoristi)
            {

                ListViewItem item = new ListViewItem(new string[] { r.ID.ToString(), r.VremePocetkaVoznje.ToString(), r.VremeKrajaVoznje.ToString(), r.PocetnaStanica, r.KrajnjaStanica, r.VremePrimanjaPoziva.ToString(), r.Vozac.JMBG.ToString(), r.Musterija.ID.ToString(), r.AdministrativnoOsoblje.JMBG.ToString() });
                this.Voznje.Items.Add(item);
            }

            this.Voznje.Refresh();

        }

        private void Voznje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
