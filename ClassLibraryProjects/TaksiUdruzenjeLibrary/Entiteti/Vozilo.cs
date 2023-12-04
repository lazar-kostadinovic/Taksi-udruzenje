using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti
{
    public class Vozilo
    {
      
        public virtual string Marka { get; set; }

        public virtual string Tip { get; set; }

    
        public virtual int ID { get; set; }

        public virtual IList<Koristi> VoziVozac { get; set; }

        public Vozilo() 
        {
            VoziVozac = new List<Koristi>();    
        }
    }
}
