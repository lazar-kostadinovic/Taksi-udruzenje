using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.DTOs
{
    public class VoziloTaksiSluzbeView
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int ID { get; set; }
        public IList<KoristiView> VoziVozac { get; set; }
        public int GodinaProizvodnje { get; set; }
        public DateTime DatumIstekaRegistracije { get; set; }
        public string RegistarskaOznaka { get; set; }
        
        public VoziloTaksiSluzbeView(VoziloTaksiSluzbe p)
        {
            Marka = p.Marka;
            Tip = p.Tip;
            ID = p.ID;
            GodinaProizvodnje = p.GodinaProizvodnje;
            DatumIstekaRegistracije = p.DatumIstekaRegistracije;
            RegistarskaOznaka = p.RegistarskaOznaka;
        }

        public VoziloTaksiSluzbeView()
        {
            VoziVozac = new List<KoristiView>();
        }
    }
}