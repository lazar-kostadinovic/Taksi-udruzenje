using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.DTOs
{
    public class VoznjaView
    {
        public int ID { get; set; }
        public DateTime VremePocetkaVoznje { get; set; }
        public DateTime VremeKrajaVoznje { get; set; }
        public string PocetnaStanica { get; set; }
        public string KrajnjaStanica { get; set; }
        public VozacView Vozac { get; set; }
        public DateTime VremePrimanjaPoziva { get; set; }
        public AdministrativnoOsobljeView AdministrativnoOsoblje { get; set; }
        public MusterijaView Musterija { get; set; }

        public VoznjaView(Voznja p)
        {
            ID = p.ID;
            VremePocetkaVoznje = p.VremePocetkaVoznje;
            VremeKrajaVoznje = p.VremeKrajaVoznje;
            PocetnaStanica = p.PocetnaStanica;
            KrajnjaStanica = p.KrajnjaStanica;
            Vozac = new VozacView(p.Vozac);
            VremePrimanjaPoziva = p.VremePrimanjaPoziva;
            AdministrativnoOsoblje = new AdministrativnoOsobljeView(p.AdministrativnoOsoblje);
            Musterija = new MusterijaView(p.Musterija);
        }

        public VoznjaView() { }

    }
}