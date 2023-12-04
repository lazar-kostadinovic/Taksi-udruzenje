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
    public partial class PrikaziVoznje : Form
    {
        public PrikaziVoznje()
        {
            InitializeComponent();
        }

        public int brojVoznji = 0;

        private void Voznje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrikaziVoznje_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.brojVoznji = 0;
            List<VoznjaBasic> listaVoznji = DTOManager.vratiSveVoznjeBasic();

            foreach (VoznjaBasic r in listaVoznji)
            {

                ListViewItem item = new ListViewItem(new string[] { r.ID.ToString(), r.VremePocetkaVoznje.ToString(), r.VremeKrajaVoznje.ToString(), r.PocetnaStanica, r.KrajnjaStanica, r.VremePrimanjaPoziva.ToString(), r.Vozac.JMBG.ToString(), r.Musterija.ID.ToString(), r.AdministrativnoOsoblje.JMBG.ToString() });
                this.Voznje.Items.Add(item);
                this.brojVoznji++;  

            }
            txbBrojVoznji.Text = this.brojVoznji.ToString();
           
            this.Voznje.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (Voznje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite voznju koju zelite da obrisete!");
                return;
            }

            int idVoznje = Int32.Parse(Voznje.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu voznju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVoznju(idVoznje);
                MessageBox.Show("Brisanje voznje je uspesno obavljeno!");
                this.Voznje.Items.Clear();
                
                popuniPodacima();
               
            }
            else
            {

            }
        }
        

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (Voznje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite voznju koju zelite da izmenite!");
                return;
            }

            int idVoznje = Int32.Parse(Voznje.SelectedItems[0].SubItems[0].Text);
            VoznjaBasic r = DTOManager.VratiVoznju(idVoznje);
            IzmeniVoznju forma = new IzmeniVoznju(r);
            this.Voznje.Items.Clear();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajVoznje forma = new DodajVoznje();
            forma.ShowDialog();
            this.Voznje.Items.Clear();
            popuniPodacima();
            

        }
    }
}
