using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using TaksiUdruzenje.Entiteti;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TaksiUdruzenje
{   
    #region Osoba
        public class OsobaBasic
        {
            public string Ime { get; set; }
            public char SrednjeSlovo { get; set; }
            public string Prezime { get; set; }
            public long JMBG { get; set; }
            public int BrojTelefona { get; set; }
            public string Adresa { get; set; }
            public OsobaBasic(string ime, char ss, string pr, long jmbg, int brtel, string adresa)
            {
                this.Ime = ime;
                this.SrednjeSlovo = ss;
                this.Prezime = pr;
                this.JMBG = jmbg;
                this.BrojTelefona = brtel;
                this.Adresa = adresa;
            }

            public OsobaBasic()
            {

            }
        }
    #endregion

    #region AdministartivnoOsoblje
    public class AdministartivnoOsobljePregled
    {
        public string Ime { get; set; }
        public char SrednjeSlovo { get; set; }
        public string Prezime { get; set; }
        public long JMBG { get; set; }
        public int BrojTelefona { get; set; }
        public string Adresa { get; set; }
      
        public string StrucnaSprema { get; set; }
        public IList<Voznja> PrimioPoziv { get; set; }
       
        public AdministartivnoOsobljePregled(string ime, char ss, string pr, long jmbg, int brtel, string adresa, string kat, IList<Voznja> voznje)
        {
            this.Ime = ime;
            this.SrednjeSlovo = ss;
            this.Prezime = pr;
            this.JMBG = jmbg;
            this.BrojTelefona = brtel;
            this.Adresa = adresa;
            this.StrucnaSprema = kat;
            this.PrimioPoziv = voznje;
    
        }

        public AdministartivnoOsobljePregled(string ime, string pr, long jmbg, string kat, IList<Voznja> voznje)
        {
            this.Ime = ime;
            this.Prezime = pr;
            this.JMBG = jmbg;
            this.StrucnaSprema = kat;
            this.PrimioPoziv = voznje;
           
        }

        public AdministartivnoOsobljePregled()
        {
            PrimioPoziv = new List<Voznja>();
       

        }
    }
    public class AdministartivnoOsobljeBasic
        {
            public string Ime { get; set; }
            public char SrednjeSlovo { get; set; }
            public string Prezime { get; set; }
            public long JMBG { get; set; }
            public int BrojTelefona { get; set; }
            public string Adresa { get; set; }
            public string StrucnaSprema { get; set; }
            public IList<VoznjaBasic> PrimoPoziv { get; set; }

            public AdministartivnoOsobljeBasic(string ime, char ss, string pr, long jmbg, int brtel, string adresa, string ssprema, IList<VoznjaBasic> pozivi)
            {
                this.Ime = ime;
                this.SrednjeSlovo = ss;
                this.Prezime = pr;
                this.JMBG = jmbg;
                this.BrojTelefona = brtel;
                this.Adresa = adresa;
                this.StrucnaSprema = ssprema;
                this.PrimoPoziv = pozivi;
            }

        public AdministartivnoOsobljeBasic(string ime, string pr, long jmbg, string ssprema, IList<VoznjaBasic> pozivi)
        {
            this.Ime = ime;
            this.Prezime = pr;
            this.JMBG = jmbg;
            this.StrucnaSprema = ssprema;
            this.PrimoPoziv = pozivi;
        }
        public AdministartivnoOsobljeBasic()
            {
                PrimoPoziv = new List<VoznjaBasic>();
            }
        }
    #endregion

    #region Vozac
    public class VozacPregled
    {
        public string Ime { get; set; }
        public char SrednjeSlovo { get; set; }
        public string Prezime { get; set; }
        public long JMBG { get; set; }
        public int BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public int BrVozackeDozvole { get; set; }
        public string Kategorija { get; set; }
        public IList<Voznja> ObavioVoznju { get; set; }
        public IList<Koristi> KoristiVozilo { get; set; }
        public VozacPregled(string ime, char ss, string pr, long jmbg, int brtel, string adresa, int brvoz, string kat, IList<Voznja> voznje, IList<Koristi> vozila)
        {
            this.Ime = ime;
            this.SrednjeSlovo = ss;
            this.Prezime = pr;
            this.JMBG = jmbg;
            this.BrojTelefona = brtel;
            this.Adresa = adresa;
            this.BrVozackeDozvole = brvoz;
            this.Kategorija = kat;
            this.ObavioVoznju = voznje;
            this.KoristiVozilo = vozila;
        }

        public VozacPregled(string ime, string pr, long jmbg, int brvoz, string kat, IList<Voznja> voznje, IList<Koristi> vozila)
        {
            this.Ime = ime;
            this.Prezime = pr;
            this.JMBG = jmbg;
            this.BrVozackeDozvole = brvoz;
            this.Kategorija = kat;
            this.ObavioVoznju = voznje;
            this.KoristiVozilo = vozila;
        }

        public VozacPregled()
        {
            ObavioVoznju = new List<Voznja>();
            KoristiVozilo = new List<Koristi>();
        }
    }
    public class VozacBasic
        {
            public string Ime { get; set; }
            public char SrednjeSlovo { get; set; }
            public string Prezime { get; set; }
            public long JMBG { get; set; }
            public int BrojTelefona { get; set; }
            public string Adresa { get; set; }
            public int BrVozackeDozvole { get; set; }
            public string Kategorija { get; set; }
            public IList<VoznjaBasic> ObavioVoznju { get; set; }
            public IList<KoristiBasic> KoristiVozilo { get; set; }
            public VozacBasic(string ime, char ss, string pr, long jmbg, int brtel, string adresa, int brvoz, string kat, IList<VoznjaBasic> voznje, IList<KoristiBasic> vozila)
            {
                this.Ime = ime;
                this.SrednjeSlovo = ss;
                this.Prezime = pr;
                this.JMBG = jmbg;
                this.BrojTelefona = brtel;
                this.Adresa = adresa;
                this.BrVozackeDozvole = brvoz;
                this.Kategorija = kat;
                this.ObavioVoznju = voznje;
                this.KoristiVozilo = vozila;
            }

            public VozacBasic(string ime, string pr, long jmbg, int brvoz, string kat, IList<VoznjaBasic> voznje, IList<KoristiBasic> vozila)
            {
                this.Ime = ime;
                this.Prezime = pr;
                this.JMBG = jmbg;
                this.BrVozackeDozvole = brvoz;
                this.Kategorija = kat;
                this.ObavioVoznju = voznje;
                this.KoristiVozilo = vozila;
            }

        public VozacBasic()
            {
                ObavioVoznju = new List<VoznjaBasic>();
                KoristiVozilo = new List<KoristiBasic>();
            }
        }
        #endregion

    #region Musterija
        public class MusterijaBasic
        {
            public int ID { get; set; }
            public string Adresa { get; set; }
            public string BrojTelefona1 { get; set; }
            public string BrojTelefona2 { get; set; }
            public string BrojTelefona3 { get; set; }
            public IList<VoznjaBasic> Poziva { get; set; }

            public MusterijaBasic(int id, string adr, string br1, string br2, string br3, IList<VoznjaBasic> poz)
            {
                this.ID = id;
                this.Adresa = adr;
                this.BrojTelefona1 = br1;
                this.BrojTelefona2 = br2;
                this.BrojTelefona3 = br3;
                this.Poziva = poz;
            }
            public MusterijaBasic()
            {
                Poziva = new List<VoznjaBasic>();
            }


        }
    #endregion

    #region Koristi
    public class KoristiPregled
    {
        public VozacPregled VozacVozi { get; set; }
        public VoziloPregled VoziVozilo { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int ID { get; set; }

        public KoristiPregled()
        {

        }
        public KoristiPregled(VozacPregled vozac, VoziloPregled vozilo, DateTime datumod, DateTime datumdo, int id)
        {
            this.VozacVozi = vozac;
            this.VoziVozilo = vozilo;
            this.DatumOd = datumod;
            this.DatumDo = datumdo;
            this.ID = id;

        }
        public KoristiPregled(string tip, string marka, DateTime datumod, DateTime datumdo, int id)
        {
            this.DatumOd = datumod;
            this.DatumDo = datumdo;
            this.ID = id;

        }
    }
    public class KoristiBasic
        {
            public VozacBasic VozacVozi { get; set; }
            public VoziloBasic VoziVozilo { get; set; }
            public DateTime DatumOd { get; set; }
            public DateTime DatumDo { get; set; }
            public int ID { get; set; }

            public KoristiBasic()
            {

            }
            public KoristiBasic(VozacBasic vozac, VoziloBasic vozilo, DateTime datumod, DateTime datumdo, int id)
            {
                this.VozacVozi = vozac;
                this.VoziVozilo = vozilo;
                this.DatumOd = datumod;
                this.DatumDo = datumdo;
                this.ID = id;
          
            }
            public KoristiBasic(string tip, string marka, DateTime datumod, DateTime datumdo, int id)
            {
                this.DatumOd = datumod;
                this.DatumDo = datumdo;
                this.ID = id;

            }
        }
    #endregion

    #region Vozilo
    public class VoziloPregled
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int ID { get; set; }
        public IList<Koristi> VoziVozac { get; set; }
        public VoziloPregled(string m, string t, int id, IList<Koristi> v)
        {
            this.Marka = m;
            this.Tip = t;
            this.ID = id;
            this.VoziVozac = v;
        }
        public VoziloPregled()
        {
            VoziVozac = new List<Koristi>();
        }
    }
    public class VoziloBasic
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int ID { get; set; }
        public IList<KoristiBasic> VoziVozac { get; set; }
        public VoziloBasic(string m, string t, int id, IList<KoristiBasic> v)
        {
            this.Marka = m;
            this.Tip = t;
            this.ID = id;
            this.VoziVozac = v;
        }
        public VoziloBasic()
        {
            VoziVozac = new List<KoristiBasic>();
        }
    }
    #endregion

    #region SopstvenoVozilo
    public class SopstvenoVoziloPregled
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int ID { get; set; }
        public IList<Koristi> VoziVozac { get; set; }
        public string Boja { get; set; }
        public SopstvenoVoziloPregled(string m, string t, int id, IList<Koristi> v, string b)
        {
            this.Marka = m;
            this.Tip = t;
            this.ID = id;
            this.VoziVozac = v;
            this.Boja = b;
        }
        public SopstvenoVoziloPregled()
        {
            VoziVozac = new List<Koristi>();
        }

    }
    public class SopstvenoVoziloBasic
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int ID { get; set; }
        public IList<KoristiBasic> VoziVozac { get; set; }
        public string Boja { get; set; }
        public SopstvenoVoziloBasic(string m, string t, int id, IList<KoristiBasic> v, string b)
        {
            this.Marka = m;
            this.Tip = t;
            this.ID = id;
            this.VoziVozac = v;
            this.Boja = b;
        }
        public SopstvenoVoziloBasic()
        {
            VoziVozac = new List<KoristiBasic>();
        }

    }
    #endregion

    #region VoziloTaksiSluzbe
    public class VoziloTaksiSluzbePregled
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int ID { get; set; }
        public IList<Koristi> VoziVozac { get; set; }
        public int GodinaProizvodnje { get; set; }
        public DateTime DatumIstekaRegistracije { get; set; }
        public string RegistarskaOznaka { get; set; }
        public VoziloTaksiSluzbePregled(string m, string t, int id, IList<Koristi> v, int g, DateTime d, string r)
        {
            this.Marka = m;
            this.Tip = t;
            this.ID = id;
            this.VoziVozac = v;
            this.GodinaProizvodnje = g;
            this.DatumIstekaRegistracije = d;
            this.RegistarskaOznaka = r;
        }
        public VoziloTaksiSluzbePregled()
        {
            VoziVozac = new List<Koristi>();
        }
    }
    public class VoziloTaksiSluzbeBasic
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int ID { get; set; }
        public IList<KoristiBasic> VoziVozac { get; set; }
        public int GodinaProizvodnje { get; set; }
        public DateTime DatumIstekaRegistracije { get; set; }
        public string RegistarskaOznaka { get; set; }
        public VoziloTaksiSluzbeBasic(string m, string t, int id, IList<KoristiBasic> v, int g, DateTime d, string r)
        {
            this.Marka = m;
            this.Tip = t;
            this.ID = id;
            this.VoziVozac = v;
            this.GodinaProizvodnje = g;
            this.DatumIstekaRegistracije = d;
            this.RegistarskaOznaka = r;
        }
        public VoziloTaksiSluzbeBasic()
        {
            VoziVozac = new List<KoristiBasic>();
        }
    }
    #endregion

    #region Voznja
    public class VoznjaBasic
    {
        public int ID { get; set; }
        public DateTime VremePocetkaVoznje { get; set; }
        public DateTime VremeKrajaVoznje { get; set; }
        public string PocetnaStanica { get; set; }
        public string KrajnjaStanica { get; set; }
        public Vozac Vozac { get; set; }
        public DateTime VremePrimanjaPoziva { get; set; }
        public AdministrativnoOsoblje AdministrativnoOsoblje { get; set; }
        public Musterija Musterija { get; set; }

        public VoznjaBasic(int id, DateTime v, DateTime vk, string p, string k, Vozac vo, DateTime vp, AdministrativnoOsoblje adm, Musterija m)
        {
            this.ID = id;
            this.VremePocetkaVoznje = v;
            this.VremeKrajaVoznje = vk;
            this.PocetnaStanica = p;
            this.KrajnjaStanica = k;
            this.Vozac = vo;
            this.VremePrimanjaPoziva = vp;
            this.AdministrativnoOsoblje = adm;
            this.Musterija = m;
        }

        public VoznjaBasic() { }

    }
    public class VoznjaPregled
    {
        public int ID { get; set; }
        public DateTime VremePocetkaVoznje { get; set; }
        public DateTime VremeKrajaVoznje { get; set; }
        public string PocetnaStanica { get; set; }
        public string KrajnjaStanica { get; set; }
        public VozacPregled Vozac { get; set; }
        public DateTime VremePrimanjaPoziva { get; set; }
        public AdministartivnoOsobljeBasic AdministrativnoOsoblje { get; set; }
        public MusterijaBasic Musterija { get; set; }

        public VoznjaPregled(int id, DateTime v, DateTime vk, string p, string k, VozacPregled vo, DateTime vp, AdministartivnoOsobljeBasic adm, MusterijaBasic m)
        {
            this.ID = id;
            this.VremePocetkaVoznje = v;
            this.VremeKrajaVoznje = vk;
            this.PocetnaStanica = p;
            this.KrajnjaStanica = k;
            this.Vozac = vo;
            this.VremePrimanjaPoziva = vp;
            this.AdministrativnoOsoblje = adm;
            this.Musterija = m;
        }

        public VoznjaPregled() { }

    }
    #endregion
}
