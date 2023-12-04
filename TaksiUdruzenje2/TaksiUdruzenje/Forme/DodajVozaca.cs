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
    public partial class DodajVozaca : Form
    {
        VozacPregled vozac;
        public DodajVozaca()
        {
            InitializeComponent();
            vozac = new VozacPregled();
        }

        private void DodajVozaca_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {

                string poruka = "Da li zelite da dodate novog vozaca?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                    this.vozac.Ime = txtIme.Text;
                    this.vozac.Prezime = txtPrez.Text;
                    this.vozac.SrednjeSlovo = char.Parse(txtSS.Text);
                    this.vozac.JMBG = long.Parse(txtJMBG.Text);
                    this.vozac.BrojTelefona = int.Parse(txtBrojTelefona.Text);
                    this.vozac.Adresa = txtAdresa.Text;
                    this.vozac.BrVozackeDozvole = int.Parse(txtBrVozDoz.Text);
                    this.vozac.Kategorija = txtKategorija.Text;

                    DTOManager.dodajVozaca(this.vozac);
                    MessageBox.Show("Uspesno ste dodali novog vozaca!");
                    this.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
    
}
