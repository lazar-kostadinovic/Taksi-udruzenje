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
    public partial class PrikaziMusterije : Form
    {
        public PrikaziMusterije()
        {
            InitializeComponent();
        }

        private void PrikaziMusterije_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<MusterijaBasic> listaMusterija = DTOManager.vratiSveMusterijaBasic();

            foreach (MusterijaBasic r in listaMusterija)
            {

                ListViewItem item = new ListViewItem(new string[] { r.ID.ToString(), r.Adresa, r.BrojTelefona1, r.BrojTelefona2, r.BrojTelefona3});
                this.musterije.Items.Add(item);

            }

            this.musterije.Refresh();
        }

        private void btnDodajMusteriju_Click(object sender, EventArgs e)
        {
            DodajMusterije forma = new DodajMusterije();
            forma.ShowDialog();
            this.musterije.Items.Clear();
            popuniPodacima();
        }

        private void btnIzmeniMusteriju_Click(object sender, EventArgs e)
        {
            if (musterije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite musteriju koju zelite da izmenite!");
                return;
            }

            int idMusterije = Int32.Parse(musterije.SelectedItems[0].SubItems[0].Text);
            MusterijaBasic r = DTOManager.vratiMusteriju(idMusterije);
            IzmeniMusteriju forma = new IzmeniMusteriju(r);
            this.musterije.Items.Clear();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisiMusteriju_Click(object sender, EventArgs e)
        {
            if (musterije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite musteriju koju zelite da obrisete!");
                return;
            }

            int idMusterije = Int32.Parse(musterije.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu musteriju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiMusteriju(idMusterije);
                MessageBox.Show("Brisanje musterije je uspesno obavljeno!");
                this.musterije.Items.Clear();
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnVoznje_Click(object sender, EventArgs e)
        {
            if (musterije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite musteriju cije voznje zelite da prikazete!");
                return;
            }

            int idMusterije = int.Parse(musterije.SelectedItems[0].SubItems[0].Text);
            MusterijaBasic r = DTOManager.vratiMusteriju(idMusterije);
            VoznjeMusterije forma = new VoznjeMusterije(r);
            forma.ShowDialog();
        }
    }
}
