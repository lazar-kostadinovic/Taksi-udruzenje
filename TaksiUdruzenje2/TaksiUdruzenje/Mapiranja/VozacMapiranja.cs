using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Mapiranja
{
    class VozacMapiranja : SubclassMap<Vozac>
    {
        public VozacMapiranja()
        {
            Table("VOZAC");

            KeyColumn("JMBG");

            Map(x => x.BrVozackeDozvole).Column("BRVOZACKEDOZVOLE");
            Map(x => x.Kategorija).Column("KATEGORIJA");

            HasMany(x => x.KoristiVozilo).KeyColumn("JMBGVOZACA").Cascade.All().Inverse();


        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FluentNHibernate.Mapping;
//using TaksiUdruzenje.Entiteti;

//namespace TaksiUdruzenje.Mapiranja
//{
//    class VozacMapiranja : SubclassMap<Vozac>
//    {
//        public VozacMapiranja()
//        {
//            Table("VOZAC");

//            KeyColumn("JMBG");

//            Map(x => x.BrVozackeDozvole).Column("BRVOZACKEDOZVOLE");
//            Map(x => x.Kategorija).Column("KATEGORIJA");

//            HasManyToMany(x => x.KoristiVozilo)
//                   .Table("KORISTI")
//                   .ParentKeyColumn("JMBGVOZACA")
//                   .ChildKeyColumn("IDVOZILA")
//                   .Inverse()
//                   .Cascade.All();


//            HasMany(x => x.ObavioVoznju).KeyColumn("JMBGVOZACA").LazyLoad().Cascade.All().Inverse();


//        }
//    }
//}
