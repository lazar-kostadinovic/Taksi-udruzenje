using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenje.Entiteti
{
    public class Vozac : Osoba
    {
        public virtual int BrVozackeDozvole { get; set; }
       
        public virtual string Kategorija { get; set; }


        public virtual IList<Voznja> ObavioVoznju { get; set; }

        public virtual IList<Koristi> KoristiVozilo { get; set; }


        public Vozac()
        {
            ObavioVoznju = new List<Voznja>();
            KoristiVozilo = new List<Koristi>();
        }

    }
}
