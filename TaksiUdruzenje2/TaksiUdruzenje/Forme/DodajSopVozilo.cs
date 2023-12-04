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
    public partial class DodajSopVozilo : Form
    {
        SopstvenoVoziloPregled vozilo;
        public DodajSopVozilo()
        {
            InitializeComponent();
            vozilo=new SopstvenoVoziloPregled();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {

                string poruka = "Da li zelite da dodate novo vozilo?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                    this.vozilo.Marka = txtMarka.Text;
                    this.vozilo.Tip = txtTip.Text;
                    this.vozilo.Boja=txtBoja.Text;  


                    DTOManager.dodajSopstvenoVozilo(this.vozilo);
                    MessageBox.Show("Uspesno ste dodali novo vozilo!");
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
