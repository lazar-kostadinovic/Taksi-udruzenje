using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Mapiranja
{
    class MusterijaMapiranja : ClassMap<Musterija>
    {
        public MusterijaMapiranja()
        {
            Table("MUSTERIJA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.BrojTelefona1).Column("BROJTELEFONA1");
            Map(x => x.BrojTelefona2).Column("BROJTELEFONA2");
            Map(x => x.BrojTelefona3).Column("BROJTELEFONA3");

            HasMany(x => x.Poziva).KeyColumn("IDMUSTERIJE").LazyLoad().Cascade.All().Inverse();
            ;

        }
    }

}
