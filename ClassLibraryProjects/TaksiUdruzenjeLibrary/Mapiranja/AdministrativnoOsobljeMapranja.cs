using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja
{
    class AdministrativnoOsobljeMapranja : SubclassMap<AdministrativnoOsoblje>
    {
        public AdministrativnoOsobljeMapranja()
        {
            Table("ADMINISTRATIVNOOSOBLJE");

            KeyColumn("JMBG");

            Map(x => x.StrucnaSprema).Column("STRUCNASPREMA");

            HasMany(x => x.PrimoPoziv).KeyColumn("JMBGADM").LazyLoad().Cascade.All().Inverse(); ;
        }
    }
}
