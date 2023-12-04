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
    public class VozacView
    {
        public string Ime { get; set; }
        public char SrednjeSlovo { get; set; }
        public string Prezime { get; set; }
        public long JMBG { get; set; }
        public int BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public int BrVozackeDozvole { get; set; }
        public string Kategorija { get; set; }
        public IList<VoznjaView> ObavioVoznju { get; set; }
        public IList<KoristiView> KoristiVozilo { get; set; }
        
        public VozacView(Vozac p)
        {
            Ime = p.Ime;
            SrednjeSlovo = p.SrednjeSlovo;
            Prezime = p.Prezime;
            JMBG = p.JMBG;
            BrojTelefona = p.BrojTelefona;
            Adresa = p.Adresa;
            BrVozackeDozvole = p.BrVozackeDozvole;
            Kategorija = p.Kategorija;
        }

        public VozacView()
        {
            ObavioVoznju = new List<VoznjaView>();
            KoristiVozilo = new List<KoristiView>();
        }
    }
}