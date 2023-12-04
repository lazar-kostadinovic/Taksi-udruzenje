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
    
    public partial class IzmeniOsobu : Form
    {
        OsobaBasic osoba;
        public IzmeniOsobu(OsobaBasic o)
        {
            InitializeComponent();
            osoba = o;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            osoba.Adresa = txbAdresa.Text;
            osoba.BrojTelefona= int.Parse(texBrojTelefona.Text);
           
            DTOManager.izmeniOsobu(osoba);
            MessageBox.Show("Uspesno ste izmenili osobu!");
            this.Close();
        }

        private void IzmeniOsobu_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txbAdresa.Text = osoba.Adresa;
            texBrojTelefona.Text = osoba.BrojTelefona.ToString();
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
