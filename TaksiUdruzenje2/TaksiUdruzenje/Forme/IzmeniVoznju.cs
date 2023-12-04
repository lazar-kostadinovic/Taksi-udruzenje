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
    public partial class IzmeniVoznju : Form
    {
        VoznjaBasic v;
        public IzmeniVoznju(VoznjaBasic v)
        {
            InitializeComponent();
            this.v = v;
        }

        private void IzmeniVoznju_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            txbPocStanica.Text = v.PocetnaStanica;
            txbKrStanica.Text = v.KrajnjaStanica;
            VremeKrajaVoznje.Value = v.VremeKrajaVoznje;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v.PocetnaStanica= txbPocStanica.Text;
            v.KrajnjaStanica = txbKrStanica.Text;
            v.VremeKrajaVoznje = VremeKrajaVoznje.Value;

            DTOManager.izmeniVoznju(v);
            MessageBox.Show("Uspesno ste izmenili voznju!");
            this.Close();
        }
    }
}
