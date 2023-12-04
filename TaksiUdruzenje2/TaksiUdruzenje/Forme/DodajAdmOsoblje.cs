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
    public partial class DodajAdmOsoblje : Form
    {
        AdministartivnoOsobljePregled adm;
        public DodajAdmOsoblje()
        {
            InitializeComponent();
            adm = new AdministartivnoOsobljePregled();
        }

        private void DodajAdmOsoblje_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string poruka = "Da li zelite da dodate novo administartivno osoblje?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                    this.adm.Ime = txtIme.Text;
                    this.adm.Prezime = txtPrez.Text;
                    this.adm.SrednjeSlovo = char.Parse(txtSS.Text);
                    this.adm.JMBG = long.Parse(txtJMBG.Text);
                    this.adm.BrojTelefona = int.Parse(txtBrojTelefona.Text);
                    this.adm.Adresa = txtAdresa.Text;
                    this.adm.StrucnaSprema = txtStrucnaSprema.Text;

                    DTOManager.dodajAdministratvnoOsoblje(this.adm);
                    MessageBox.Show("Uspesno ste dodali novo administrativno osoblje!");
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
