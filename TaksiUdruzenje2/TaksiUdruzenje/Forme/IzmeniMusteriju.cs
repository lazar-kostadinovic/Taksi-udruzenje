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
    public partial class IzmeniMusteriju : Form
    {
        MusterijaBasic musterija;
        public IzmeniMusteriju(MusterijaBasic m)
        {
            InitializeComponent();
            musterija = m;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIzmeniMusteriju_Click(object sender, EventArgs e)
        {
            musterija.Adresa = txtAdresa.Text;
            musterija.BrojTelefona1 = txtBrojTelefona1.Text;
            musterija.BrojTelefona2 = txtBrojTelefona2.Text;
            musterija.BrojTelefona3 = txtBrojTelefona3.Text;

            DTOManager.izmeniMusteriju(musterija);
            MessageBox.Show("Uspesno ste izmenili musteriju!");
            this.Close();
        }

        private void IzmeniMusteriju_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txtAdresa.Text = musterija.Adresa;
            txtBrojTelefona1.Text = musterija.BrojTelefona1.ToString();
            if (txtBrojTelefona2.Text != "")
            {
                txtBrojTelefona2.Text = musterija.BrojTelefona2.ToString();
            }
            else
            { 
                txtBrojTelefona2.Text = ""; 
            }
            if (txtBrojTelefona3.Text != "")
            {
                txtBrojTelefona3.Text = musterija.BrojTelefona3.ToString();
            }
            else 
            { 
                txtBrojTelefona2.Text = ""; 
            }
        }
    }
}
