using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Mapiranja
{
    class VoznjaMapiranja : ClassMap<Voznja>
    {
        public VoznjaMapiranja()
        {
            Table("VOZNJA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.VremePocetkaVoznje).Column("VREMEPOCETKAVOZNJE");
            Map(x => x.VremeKrajaVoznje).Column("VREMEKRAJAVOZNJE");
            Map(x => x.VremePrimanjaPoziva).Column("VREMEPRIMANJAPOZIVA");
            Map(x => x.PocetnaStanica).Column("POCETNASTANICA");
            Map(x => x.KrajnjaStanica).Column("KRAJNJASTANICA");

            References(x => x.Vozac).Column("JMBGVOZACA");
            References(x => x.AdministrativnoOsoblje).Column("JMBGADM");
            References(x => x.Musterija).Column("IDMUSTERIJE");
        }
    }
}
