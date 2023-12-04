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
    public class SopstvenoVoziloView
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int ID { get; set; }
        public IList<KoristiView> VoziVozac { get; set; }
        public string Boja { get; set; }

        public SopstvenoVoziloView(SopstvenoVozilo p)
        {
            Marka = p.Marka;
            Tip = p.Tip;
            ID = p.ID;
            Boja = p.Boja;
        }
        public SopstvenoVoziloView()
        {
            VoziVozac = new List<KoristiView>();
        }

    }
}