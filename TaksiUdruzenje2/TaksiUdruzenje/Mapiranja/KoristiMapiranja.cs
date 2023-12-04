using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Mapiranja
{
    class KoristiMapiranja : ClassMap<Koristi>
    {
        public KoristiMapiranja()
        {

            Table("KORISTI");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.DatumOd).Column("DATUMOD");
            Map(x => x.DatumDo).Column("DATUMDO");

            References(x => x.VoziVozilo).Column("IDVOZILA");
            References(x => x.VozacVozi).Column("JMBGVOZACA");

        }
    }
}
