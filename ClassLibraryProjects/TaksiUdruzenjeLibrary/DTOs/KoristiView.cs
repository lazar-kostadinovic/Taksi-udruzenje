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
    public class KoristiView
    {
        public VozacView VozacVozi { get; set; }
        public VoziloView VoziVozilo { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int ID { get; set; }

        public KoristiView()
        {

        }
        public KoristiView(Koristi k)
        {
            VozacVozi = new VozacView(k.VozacVozi);
            VoziVozilo = new VoziloView(k.VoziVozilo);
            DatumOd = k.DatumOd;
            DatumDo = k.DatumDo;
            ID = k.ID;
        }
    }
}