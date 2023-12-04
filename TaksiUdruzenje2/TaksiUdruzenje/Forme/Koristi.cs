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
    public partial class Koristi : Form
    {
        VozacPregled vozac;
        Koristi koristi;

        public Koristi()
        {
            InitializeComponent();
        }
        public Koristi(VozacPregled v)
        {
            InitializeComponent();
            vozac = v;
        }

        private void Koristi_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        
        public void popuniPodacima()
        {
            List<KoristiPregled> listaKoristi = DTOManager.vratiSvaVozilaKoristiPregled(vozac.JMBG);

            foreach (KoristiPregled r in listaKoristi)
            {
                
                ListViewItem item = new ListViewItem(new string[] { r.ID.ToString(), r.VoziVozilo.ID.ToString(),r.DatumOd.ToString(), r.DatumDo.ToString()});
                this.kor.Items.Add(item);

            }

            this.kor.Refresh();
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajKoristi forma = new DodajKoristi(vozac);
            this.kor.Items.Clear();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (kor.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje zelite da izmenite!");
                return;
            }

            int idKoristi = Int32.Parse(kor.SelectedItems[0].SubItems[0].Text);
            KoristiPregled r = DTOManager.vratiKoristi(idKoristi);
            IzmeniKoristi forma = new IzmeniKoristi(r);
            this.kor.Items.Clear();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (kor.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje zelite da obrisete!");
                return;
            }

            int idKoristi = Int32.Parse(kor.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano vozilo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiKoristi(idKoristi);
                MessageBox.Show("Brisanje vozila je uspesno!");
                this.kor.Items.Clear();
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void kor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
