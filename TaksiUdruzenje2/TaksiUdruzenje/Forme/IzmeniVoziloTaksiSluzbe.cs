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
    public partial class IzmeniVoziloTaksiSluzbe : Form
    {
        VoziloTaksiSluzbePregled vozilo;
        public IzmeniVoziloTaksiSluzbe(VoziloTaksiSluzbePregled vozilo)
        {
            InitializeComponent();
            this.vozilo = vozilo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vozilo.DatumIstekaRegistracije = DatumIstekaReg.Value;
            vozilo.RegistarskaOznaka = txtRegOznaka.Text;

            DTOManager.izmeniVoziloTaksiSluzbe(vozilo);
            MessageBox.Show("Uspesno ste izmenili vozilo!");
            this.Close();
        }
    }
}
