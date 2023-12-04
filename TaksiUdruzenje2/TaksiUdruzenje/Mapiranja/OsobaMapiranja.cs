using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Mapiranja
{
    class OsobaMapiranja:ClassMap<Osoba>
    {
        public OsobaMapiranja()
        {
            Table("OSOBA");

            Id(x => x.JMBG).Column("JMBG").GeneratedBy.Assigned();

            Map(x => x.Ime).Column("IME");
            Map(x => x.SrednjeSlovo).Column("SREDNJESLOVO");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.BrojTelefona).Column("BROJTELEFONA");
            Map(x => x.Adresa).Column("ADRESA");


        }

    }
}
