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
    public partial class DodajMusterije : Form
    {
        MusterijaBasic musterija;
        public DodajMusterije()
        {
            InitializeComponent();
            musterija = new MusterijaBasic();
        }

        private void btnDodajMusteriju_Click(object sender, EventArgs e)
        {
            try
            {

                string poruka = "Da li zelite da dodate novu musteriju?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                    this.musterija.Adresa = txtAdresa.Text;
                    this.musterija.BrojTelefona1 = txtBrojTelefona1.Text;
                    this.musterija.BrojTelefona2 = txtBrojTelefona2.Text;
                    this.musterija.BrojTelefona3 = txtBrojTelefona3.Text;

                    DTOManager.dodajMusteriju(this.musterija);
                    MessageBox.Show("Uspesno ste dodali novu musteriju!");
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
