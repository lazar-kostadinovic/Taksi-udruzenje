using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenje.Entiteti
{
    public class Voznja
    {
        public virtual int ID { get; set; }


        public virtual DateTime VremePocetkaVoznje { get; set; }


        public virtual DateTime VremeKrajaVoznje { get; set; }

        public virtual string PocetnaStanica { get; set; }


        public virtual string KrajnjaStanica { get; set; }


        
        public virtual Vozac Vozac { get; set; }

        public virtual DateTime VremePrimanjaPoziva { get; set; }


       

        public virtual AdministrativnoOsoblje AdministrativnoOsoblje { get; set; }



        public virtual Musterija Musterija { get; set; }
    }
}
