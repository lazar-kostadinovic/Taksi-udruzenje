using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Forme
{
    public partial class IzmeniSopVozilo : Form
    {
        SopstvenoVoziloPregled vozilo;
        public IzmeniSopVozilo(SopstvenoVoziloPregled vozilo)
        {
            InitializeComponent();
            this.vozilo = vozilo;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            vozilo.Boja= txtBoja.Text;

            DTOManager.izmeniSopVozilo(vozilo);
            MessageBox.Show("Uspesno ste izmenili boju vozila!");
            this.Close();
        }
    }
}
