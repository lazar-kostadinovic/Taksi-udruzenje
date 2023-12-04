using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti
{
    public class VoziloTaksiSluzbe : Vozilo
    {
       
        public virtual int GodinaProizvodnje { get; set; }

  
        public virtual DateTime DatumIstekaRegistracije { get; set; }

       
        public virtual string RegistarskaOznaka { get; set; }



       
    }
}
