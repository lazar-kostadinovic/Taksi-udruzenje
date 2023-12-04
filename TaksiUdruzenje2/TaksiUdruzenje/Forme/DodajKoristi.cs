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
    public partial class DodajKoristi : Form
    {
        //KoristiPregled k;
        VozacPregled v;
        public DodajKoristi()
        {
            InitializeComponent();
            //k = new KoristiPregled();
        }

        public DodajKoristi(VozacPregled v)
        {
            InitializeComponent();
            this.v = v;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string poruka = "Da li zelite da dodelite novo vozilo vozacu?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                    KoristiPregled k = new KoristiPregled();
                    k.DatumDo = datumDo.Value;
                    k.DatumOd = datumOd.Value;
                    k.VozacVozi = v;
                    k.VoziVozilo = DTOManager.vratiVozilo(int.Parse(txtVozilo.Text));
                    DTOManager.dodajKoristi(k);
                    MessageBox.Show("Uspesno ste dodelili novo vozilo vozacu!");
                    this.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodajKoristi_Load(object sender, EventArgs e)
        {
            txtVozac.Text = v.JMBG.ToString();
        }
    }
    
}
