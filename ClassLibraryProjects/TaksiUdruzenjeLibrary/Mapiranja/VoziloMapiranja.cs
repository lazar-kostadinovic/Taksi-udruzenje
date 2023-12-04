using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja
{
    class VoziloMapiranja : ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {
            Table("VOZILO");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Marka).Column("MARKA");
            Map(x => x.Tip).Column("TIP");

            HasMany(x => x.VoziVozac).KeyColumn("IDVOZILA").LazyLoad().Cascade.All().Inverse();

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
//    class VoziloMapiranja :ClassMap<Vozilo>
//    {
//        public VoziloMapiranja() 
//        {
//            Table("VOZILO");

//            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

//            Map(x => x.Marka).Column("MARKA");
//            Map(x => x.Tip).Column("TIP");

//            HasManyToMany(x => x.VoziVozac)
//             .Table("KORISTI")
//             .ParentKeyColumn("IDVOZILA")
//             .ChildKeyColumn("JMBGVOZACA")
//             .Cascade.All();


//        }
//    }
//}

