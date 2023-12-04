using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenje.Entiteti;

namespace TaksiUdruzenje.Mapiranja
{
    class VoziloTaksiSluzbeMapiranja : SubclassMap<VoziloTaksiSluzbe>
    {
        public VoziloTaksiSluzbeMapiranja()
        {
            Table("VOZILOTAKSISLUZBE");
            KeyColumn("ID");
            Map(x => x.GodinaProizvodnje).Column("GODINAPROIZVODNJE");
            Map(x => x.DatumIstekaRegistracije).Column("DATUMISTEKAREGISTRACIJE");
            Map(x => x.RegistarskaOznaka).Column("REGISTARSKAOZNAKA");

           

        }
    }

}

