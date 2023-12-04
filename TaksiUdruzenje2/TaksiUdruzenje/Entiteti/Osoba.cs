using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenje.Entiteti
{
    public class Osoba
    {       
            public virtual string Ime { get; set; }

          
            public virtual char SrednjeSlovo { get; set; }

            public virtual string Prezime { get; set; }

           
            public virtual long JMBG { get; set; }

          
            public virtual int BrojTelefona { get; set; }

          
            public virtual string Adresa { get; set; }
        
    }
}
