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
    public class OsobaView
    {
        public string Ime { get; set; }
        public char SrednjeSlovo { get; set; }
        public string Prezime { get; set; }
        public long JMBG { get; set; }
        public int BrojTelefona { get; set; }
        public string Adresa { get; set; }
        
        public OsobaView()
        {

        }
        
        public OsobaView(Osoba o)
        {
            Ime = o.Ime;
            SrednjeSlovo = o.SrednjeSlovo;
            Prezime = o.Prezime;
            JMBG = o.JMBG;
            BrojTelefona = o.BrojTelefona;
            Adresa = o.Adresa;
        }

    }
}