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
    public partial class IzmeniKoristi : Form
    {
        KoristiPregled koristi;
        public IzmeniKoristi(KoristiPregled k)
        {
            InitializeComponent();
            koristi = k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koristi.DatumDo = datumDo.Value;
            koristi.DatumOd = datumOd.Value;

            DTOManager.izmeniKoristi(koristi);
            MessageBox.Show("Uspesno ste izmenili vreme koriscenja vozila!");
            this.Close();
        }    

        private void IzmeniKoristi_Load(object sender, EventArgs e)
        {
                popuniPodacima();
            }
            public void popuniPodacima()
            {

                datumDo.Value = koristi.DatumDo;
                datumOd.Value = koristi.DatumOd;

            }

        }
}
