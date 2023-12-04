using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Entiteti
{
    public class AdministrativnoOsoblje : Osoba
    {

        public virtual string StrucnaSprema { get; set; }

        public virtual IList<Voznja> PrimoPoziv { get; set; }

        public AdministrativnoOsoblje()
        {
            PrimoPoziv = new List<Voznja>();
        }
    }
}
