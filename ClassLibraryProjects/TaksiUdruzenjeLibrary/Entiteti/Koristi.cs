using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti
{
    public class Koristi
    {
            public virtual Vozac VozacVozi { get; set; }
            public virtual Vozilo VoziVozilo { get; set; }
           
            public virtual DateTime DatumOd { get; set; }
            public virtual DateTime DatumDo { get; set; }
            public virtual int ID { get; set; }




    }
    
}
