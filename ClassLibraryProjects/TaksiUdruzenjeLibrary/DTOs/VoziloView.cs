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
    public class VoziloView
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int ID { get; set; }
        public IList<KoristiView> VoziVozac { get; set; }
    
        public VoziloView(Vozilo p)
        {
            Marka = p.Marka;
            Tip = p.Tip;
            ID = p.ID;
        }
        public VoziloView()
        {
            VoziVozac = new List<KoristiView>();
        }

    }
}