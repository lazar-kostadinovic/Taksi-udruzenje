using System;
using NHibernate;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje
{
    public partial class DodajOsobu : Form
    {
        OsobaBasic osoba;
        public DodajOsobu()
        {
            InitializeComponent();
            osoba=new OsobaBasic();  
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            try
            {

                string poruka = "Da li zelite da dodate novu osobu?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                    this.osoba.Ime = txtIme.Text;
                    this.osoba.Prezime = txtPrez.Text;
                    this.osoba.SrednjeSlovo = char.Parse(txtSS.Text);
                    this.osoba.JMBG = long.Parse(txtJMBG.Text);
                    this.osoba.BrojTelefona = int.Parse(txtBrojTelefona.Text);
                    this.osoba.Adresa = txtAdresa.Text;

                    DTOManager.dodajOsobu(this.osoba);
                    MessageBox.Show("Uspesno ste dodali novu osobu!");
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