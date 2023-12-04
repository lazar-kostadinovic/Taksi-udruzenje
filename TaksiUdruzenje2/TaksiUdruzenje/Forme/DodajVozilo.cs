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
    public partial class DodajVozilo : Form
    {
        VoziloBasic vozilo;
        public DodajVozilo()
        {
            InitializeComponent();
            vozilo= new VoziloBasic();  
        }

        private void txtPrez_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string poruka = "Da li zelite da dodate novo vozilo?";
                string title = "Pitanje";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);


                if (result == DialogResult.OK)
                {
                    this.vozilo.Marka= txtMarka.Text;
                    this.vozilo.Tip= txtTip.Text;
                 

                    DTOManager.dodajVozilo(this.vozilo);
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
