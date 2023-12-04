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
    public partial class DodajVoznje : Form
    {
        VoznjaPregled voznja;
     
        public DodajVoznje()
        {
            InitializeComponent();
            voznja=new VoznjaPregled(); 
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string poruka = "Da li zelite da dodate novu voznju?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                    this.voznja.VremePocetkaVoznje = VremePocetka.Value;
                    this.voznja.VremeKrajaVoznje = VremeKraja.Value;
                    this.voznja.PocetnaStanica = PocStanica.Text;
                    this.voznja.KrajnjaStanica = KrajnjaStanica.Text;
                    this.voznja.Vozac= DTOManager.vratiVozaca(long.Parse(JmbgVozaca.Text));
                    this.voznja.VremePrimanjaPoziva = VremePrimanja.Value;
                    this.voznja.Musterija = DTOManager.vratiMusteriju(int.Parse(IdMusterije.Text));
                    this.voznja.AdministrativnoOsoblje = DTOManager.vratiAdministartivnoOsoblje(long.Parse(JmbgAdm.Text));


                    DTOManager.dodajVoznju(this.voznja);
                    MessageBox.Show("Uspesno ste dodali novu voznju!");
                    this.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void JmbgVozaca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
