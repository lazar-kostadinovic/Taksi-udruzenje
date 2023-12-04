using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja
{
    class SopstvenoVoziloMapiranja : SubclassMap<SopstvenoVozilo>
    {
        public SopstvenoVoziloMapiranja()
        {
            Table("SOPSTVENOVOZILO");

            KeyColumn("ID");

            Map(x => x.Boja).Column("BOJA");

        }
    }
}
