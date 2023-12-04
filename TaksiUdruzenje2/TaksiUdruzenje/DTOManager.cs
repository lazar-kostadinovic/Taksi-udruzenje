using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenje.Entiteti;
using NHibernate.Linq;
using System.Windows.Forms;

namespace TaksiUdruzenje
{
    public class DTOManager
    {
        #region Osoba
        public static void obrisiOsobu(long JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Osoba osoba = s.Load<Osoba>(JMBG);

                s.Delete(osoba);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static OsobaBasic vratiOsobe(long JMBG)
        {
            OsobaBasic o = new OsobaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Osoba osoba = s.Load<Osoba>(JMBG);

                o.Ime = osoba.Ime;
                o.SrednjeSlovo = osoba.SrednjeSlovo;
                o.Prezime = osoba.Prezime;
                o.Adresa = osoba.Adresa;
                o.BrojTelefona = osoba.BrojTelefona;
                o.JMBG = osoba.JMBG;

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return o;

        }

        public static void dodajOsobu(OsobaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Osoba o = new TaksiUdruzenje.Entiteti.Osoba();

                o.Ime = p.Ime;
                o.SrednjeSlovo = p.SrednjeSlovo;
                o.Prezime = p.Prezime;
                o.JMBG = p.JMBG;
                o.Adresa = p.Adresa;
                o.BrojTelefona = p.BrojTelefona;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static void izmeniOsobu(OsobaBasic osoba)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Osoba o = s.Load<Osoba>(osoba.JMBG);

                o.BrojTelefona = osoba.BrojTelefona;
                o.Adresa = osoba.Adresa;




                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static List<OsobaBasic> vratiSveOsobeBasic()
        {
            List<OsobaBasic> zaposleni = new List<OsobaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Osoba> osobe = from o in s.Query<TaksiUdruzenje.Entiteti.Osoba>()
                                           select o;

                foreach (Osoba p in osobe)
                {
                    OsobaBasic osoba = DTOManager.vratiOsobe(p.JMBG);
                    zaposleni.Add(osoba);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return zaposleni;


        }
        #endregion

        #region AdministrativnoOsoblje
        public static AdministartivnoOsobljeBasic vratiAdministartivnoOsoblje(long JMBG)
        {
            AdministartivnoOsobljeBasic o = new AdministartivnoOsobljeBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                AdministrativnoOsoblje osoba = s.Load<AdministrativnoOsoblje>(JMBG);

                o.Ime = osoba.Ime;
                //o.SrednjeSlovo = osoba.SrednjeSlovo;
                o.Prezime = osoba.Prezime;
                //o.Adresa = osoba.Adresa;
                //o.BrojTelefona = osoba.BrojTelefona;
                o.StrucnaSprema = osoba.StrucnaSprema;
                o.JMBG = osoba.JMBG;

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return o;

        }

        public static List<AdministartivnoOsobljeBasic> vratiSvoAdmnistrativnoOsoblje()
        {
            List<AdministartivnoOsobljeBasic> zaposleni = new List<AdministartivnoOsobljeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<AdministrativnoOsoblje> osobe = from o in s.Query<TaksiUdruzenje.Entiteti.AdministrativnoOsoblje>()
                                                            select o;

                foreach (AdministrativnoOsoblje p in osobe)
                {
                    AdministartivnoOsobljeBasic osoba = DTOManager.vratiAdministartivnoOsoblje(p.JMBG);
                    zaposleni.Add(osoba);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return zaposleni;


        }
        public static List<VoznjaBasic> vratiSveVoznjeAdm(long jmbg)
        {
            List<VoznjaBasic> koristi = new List<VoznjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> k = from o in s.Query<TaksiUdruzenje.Entiteti.Voznja>()
                                        where o.AdministrativnoOsoblje.JMBG == jmbg
                                        select o;

                foreach (Voznja p in k)
                {
                    VoznjaBasic q = DTOManager.VratiVoznju(p.ID);
                    koristi.Add(q);
                }

                s.Close();


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return koristi;
        }

        public static void dodajAdministratvnoOsoblje(AdministartivnoOsobljePregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.AdministrativnoOsoblje o = new TaksiUdruzenje.Entiteti.AdministrativnoOsoblje();

                o.Ime = p.Ime;
                o.SrednjeSlovo = p.SrednjeSlovo;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrojTelefona = p.BrojTelefona;
                o.StrucnaSprema = p.StrucnaSprema;
                o.JMBG = p.JMBG;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        #endregion
        
        #region Vozac

            public static VozacPregled vratiVozaca(long JMBG)
            {
                VozacPregled o = new VozacPregled();
                try
                {
                    ISession s = DataLayer.GetSession();

                    Vozac osoba = s.Load<Vozac>(JMBG);

                    o.Ime = osoba.Ime;
                    //o.SrednjeSlovo = osoba.SrednjeSlovo;
                    o.Prezime = osoba.Prezime;
                    //o.Adresa = osoba.Adresa;
                    //o.BrojTelefona = osoba.BrojTelefona;
                    o.Kategorija = osoba.Kategorija;
                    o.BrVozackeDozvole = osoba.BrVozackeDozvole;
                    o.JMBG = osoba.JMBG;

                    s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return o;

        }
        public static VozacBasic vratiVozacaBasic(long JMBG)
        {
            VozacBasic o = new VozacBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Vozac osoba = s.Load<Vozac>(JMBG);

                o.Ime = osoba.Ime;
                //o.SrednjeSlovo = osoba.SrednjeSlovo;
                o.Prezime = osoba.Prezime;
                //o.Adresa = osoba.Adresa;
                //o.BrojTelefona = osoba.BrojTelefona;
                o.Kategorija = osoba.Kategorija;
                o.BrVozackeDozvole = osoba.BrVozackeDozvole;
                o.JMBG = osoba.JMBG;

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return o;

        }

        public static List<VozacPregled> vratiSveVozace()
        {
            List<VozacPregled> zaposleni = new List<VozacPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozac> osobe = from o in s.Query<TaksiUdruzenje.Entiteti.Vozac>()
                                           select o;

                foreach (Vozac p in osobe)
                {
                    VozacPregled osoba = DTOManager.vratiVozaca(p.JMBG);
                    zaposleni.Add(osoba);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return zaposleni;


        }
        public static void dodajVozaca(VozacPregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Vozac o = new TaksiUdruzenje.Entiteti.Vozac();

                o.Ime = p.Ime;
                o.SrednjeSlovo = p.SrednjeSlovo;
                o.Prezime = p.Prezime;
                o.JMBG = p.JMBG;
                o.Adresa = p.Adresa;
                o.BrojTelefona = p.BrojTelefona;
                o.BrVozackeDozvole = p.BrVozackeDozvole;
                o.Kategorija = p.Kategorija;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        #endregion

        #region Koristi
        public static void obrisiKoristi(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Koristi koristi = s.Load<Koristi>(id);

                s.Delete(koristi);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }
        public static KoristiPregled vratiKoristi(int id)
        {
            KoristiPregled o = new KoristiPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Koristi koristi = s.Load<Koristi>(id);

                o.VozacVozi = vratiVozaca(koristi.VozacVozi.JMBG);
                o.VoziVozilo = vratiVozilo(koristi.VoziVozilo.ID);
                o.DatumOd = koristi.DatumOd;
                o.DatumDo = koristi.DatumDo;
                o.ID = koristi.ID;

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return o;

        }

        public static void dodajKoristi(KoristiPregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Koristi o = new TaksiUdruzenje.Entiteti.Koristi();

                Vozac r = s.Load<Vozac>(p.VozacVozi.JMBG);
                Entiteti.Vozilo q = s.Load<Entiteti.Vozilo>(p.VoziVozilo.ID);

                o.VoziVozilo = q;
                o.VozacVozi = r;
                o.DatumOd = p.DatumOd;
                o.DatumDo = p.DatumDo;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static void izmeniKoristi(KoristiPregled koristi)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Koristi o = s.Load<Koristi>(koristi.ID);

                o.DatumOd = koristi.DatumOd;
                o.DatumDo = koristi.DatumDo;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static List<KoristiPregled> vratiSveKoristiPregled()
        {
            List<KoristiPregled> koristi = new List<KoristiPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Koristi> k = from o in s.Query<TaksiUdruzenje.Entiteti.Koristi>()
                                         select o;

                foreach (Koristi p in k)
                {
                    KoristiPregled q = DTOManager.vratiKoristi(p.ID);
                    koristi.Add(q);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return koristi;


        }
        public static List<KoristiPregled> vratiSvaVozilaKoristiPregled(long jmbg)
        {
            List<KoristiPregled> koristi = new List<KoristiPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Koristi> k = from o in s.Query<TaksiUdruzenje.Entiteti.Koristi>()
                                         where o.VozacVozi.JMBG == jmbg
                                         select o;

                foreach (Koristi p in k)
                {
                    KoristiPregled q = DTOManager.vratiKoristi(p.ID);
                    koristi.Add(q);
                }

                s.Close();


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return koristi;
        }
        public static List<VoznjaBasic> vratiSveVoznjeVozaca(long jmbg)
        {
            List<VoznjaBasic> koristi = new List<VoznjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> k = from o in s.Query<TaksiUdruzenje.Entiteti.Voznja>()
                                        where o.Vozac.JMBG == jmbg
                                        select o;

                foreach (Voznja p in k)
                {
                    VoznjaBasic q = DTOManager.VratiVoznju(p.ID);
                    koristi.Add(q);
                }

                s.Close();


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return koristi;
        }

        #endregion

        #region Vozilo
        
    public static void dodajVozilo(VoziloBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.Vozilo o = new TaksiUdruzenje.Entiteti.Vozilo();

                o.ID = p.ID;
                o.Marka = p.Marka;
                o.Tip = p.Tip;
               
                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
 
        public static void obrisiVozilo(int ID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(ID);

                s.Delete(vozilo);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static VoziloPregled vratiVozilo(int id)
        {
            VoziloPregled o = new VoziloPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(id);

                o.ID = vozilo.ID;
                o.Marka = vozilo.Marka;
                o.Tip = vozilo.Tip;
                o.VoziVozac = vozilo.VoziVozac;

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return o;

        }
        public static List<VoziloPregled> vratiSvaVozila()
        {
            List<VoziloPregled> vozila = new List<VoziloPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> svaVozila = from o in s.Query<TaksiUdruzenje.Entiteti.Vozilo>()
                                                select o;

                foreach (Vozilo p in svaVozila)
                {
                    VoziloPregled vozilo = DTOManager.vratiVozilo(p.ID);
                    vozila.Add(vozilo);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vozila;
        }


        #endregion Vozilo

        #region SopstvenoVozilo
        public static void dodajSopstvenoVozilo(SopstvenoVoziloPregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.SopstvenoVozilo o = new TaksiUdruzenje.Entiteti.SopstvenoVozilo();

                o.ID = p.ID;
                o.Marka = p.Marka;
                o.Tip = p.Tip;
                o.Boja = p.Boja;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static void izmeniSopVozilo(SopstvenoVoziloPregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TaksiUdruzenje.Entiteti.SopstvenoVozilo voz = s.Load<SopstvenoVozilo>(v.ID);
                voz.Boja = v.Boja;
                s.SaveOrUpdate(voz);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
       
        public static SopstvenoVoziloPregled vratiSopstvenoVozilo(int id)
        {
            SopstvenoVoziloPregled o = new SopstvenoVoziloPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                SopstvenoVozilo vozilo = s.Load<SopstvenoVozilo>(id);

                o.ID = vozilo.ID;
                o.Marka = vozilo.Marka;
                o.Tip = vozilo.Tip;
                o.VoziVozac = vozilo.VoziVozac;
                o.Boja = vozilo.Boja;

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return o;

        }
   
        public static List<SopstvenoVoziloPregled> vratiSvaSopstvenaVozila()
        {
            List<SopstvenoVoziloPregled> vozila = new List<SopstvenoVoziloPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SopstvenoVozilo> svaVozila = from o in s.Query<TaksiUdruzenje.Entiteti.SopstvenoVozilo>()
                                                           select o;

                foreach (SopstvenoVozilo p in svaVozila)
                {
                    SopstvenoVoziloPregled vozilo = DTOManager.vratiSopstvenoVozilo(p.ID);
                    vozila.Add(vozilo);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return vozila;
        }
        public static List<VoznjaBasic> vratiSveVoznjeSopstvenogVozila(long jmbg)
        {
            List<VoznjaBasic> koristi = new List<VoznjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> k = from o in s.Query<TaksiUdruzenje.Entiteti.Voznja>()
                                        where o.Vozac.JMBG== jmbg
                                        select o;
                // mozda treba vratiSvaVozilaKoristiPregled da se iskoristi
                foreach (Voznja p in k)
                {
                    VoznjaBasic q = DTOManager.VratiVoznju(p.ID);
                    koristi.Add(q);
                }

                s.Close();


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return koristi;
        }

        #endregion SopstvenoVozilo

        #region VoziloTaksiSluzbe

        public static void dodajVoziloTaksiSluzbe(VoziloTaksiSluzbePregled p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenje.Entiteti.VoziloTaksiSluzbe o = new TaksiUdruzenje.Entiteti.VoziloTaksiSluzbe();

                o.ID = p.ID;
                o.Marka = p.Marka;
                o.Tip = p.Tip;
                o.GodinaProizvodnje = p.GodinaProizvodnje;
                o.DatumIstekaRegistracije = p.DatumIstekaRegistracije;
                o.RegistarskaOznaka = p.RegistarskaOznaka;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static void izmeniVoziloTaksiSluzbe(VoziloTaksiSluzbePregled v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TaksiUdruzenje.Entiteti.VoziloTaksiSluzbe voz = s.Load<VoziloTaksiSluzbe>(v.ID);
                voz.DatumIstekaRegistracije = v.DatumIstekaRegistracije;
                voz.RegistarskaOznaka=v.RegistarskaOznaka; 
                s.SaveOrUpdate(voz);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static VoziloTaksiSluzbePregled VoziloTaksiSluzbe(int id)
                {
                    VoziloTaksiSluzbePregled o = new VoziloTaksiSluzbePregled();
                    try
                    {
                        ISession s = DataLayer.GetSession();

                        VoziloTaksiSluzbe vozilo = s.Load<VoziloTaksiSluzbe>(id);

                        o.ID = vozilo.ID;
                        o.Marka = vozilo.Marka;
                        o.Tip = vozilo.Tip;
                        o.VoziVozac = vozilo.VoziVozac;
                        o.DatumIstekaRegistracije = vozilo.DatumIstekaRegistracije;
                        o.GodinaProizvodnje = vozilo.GodinaProizvodnje;

                        s.Close();

                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message);
                    }

                    return o;

                }
                    public static VoziloTaksiSluzbePregled vratiVoziloTaksiSluzbe(int ID)
                    {
                         VoziloTaksiSluzbePregled o = new VoziloTaksiSluzbePregled();
                        try
                        {
                            ISession s = DataLayer.GetSession();

                            VoziloTaksiSluzbe vozilo = s.Load<VoziloTaksiSluzbe>(ID);

                            o.ID = vozilo.ID;
                            o.Marka = vozilo.Marka;
                            o.Tip = vozilo.Tip;
                            o.VoziVozac = vozilo.VoziVozac;
                            o.DatumIstekaRegistracije = vozilo.DatumIstekaRegistracije;
                            o.RegistarskaOznaka = vozilo.RegistarskaOznaka;
                            o.GodinaProizvodnje = vozilo.GodinaProizvodnje;

                            s.Close();

                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show(ec.Message);
                        }

                        return o;

                    }
                      public static List<VoziloTaksiSluzbePregled> vratiSvaVozilaTaksiSluzbe()
                    {
                    List<VoziloTaksiSluzbePregled> vozila = new List<VoziloTaksiSluzbePregled>();
                    try
                    {
                        ISession s = DataLayer.GetSession();

                        IEnumerable<VoziloTaksiSluzbe> svaVozila = from o in s.Query<TaksiUdruzenje.Entiteti.VoziloTaksiSluzbe>()
                                                                    select o;

                        foreach (VoziloTaksiSluzbe p in svaVozila)
                        {
                            VoziloTaksiSluzbePregled vozilo = DTOManager.vratiVoziloTaksiSluzbe(p.ID);
                            vozila.Add(vozilo);
                        }

                        s.Close();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message);
                    }

                    return vozila;
                    }
                  
                    public static List<VoznjaBasic> vratiSveVoznjeVozilaTaksiSluzbe(int ID)
                    {
                        List<VoznjaBasic> koristi = new List<VoznjaBasic>();
                        try
                        {
                            ISession s = DataLayer.GetSession();

                            IEnumerable<Voznja> k = from o in s.Query<TaksiUdruzenje.Entiteti.Voznja>()
                                                    where o.Vozac.JMBG== ID
                                                    select o;

                            foreach (Voznja p in k)
                            {
                                VoznjaBasic q = DTOManager.VratiVoznju(p.ID);
                                koristi.Add(q);
                            }

                            s.Close();


                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show(ec.Message);
                        }

                        return koristi;
                    }


        #endregion VoziloTaksiSluzbe

        #region Musterija
        public static void obrisiMusteriju(int id)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    Musterija musterija = s.Load<Musterija>(id);

                    s.Delete(musterija);
                    s.Flush();

                    s.Close();

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
            }


            }
            public static MusterijaBasic vratiMusteriju(int id)
            {
                MusterijaBasic o = new MusterijaBasic();
                try
                {
                    ISession s = DataLayer.GetSession();

                    Musterija musterija = s.Load<Musterija>(id);

                    o.ID = musterija.ID;
                    o.Adresa = musterija.Adresa;
                    o.BrojTelefona1 = musterija.BrojTelefona1;
                    o.BrojTelefona2 = musterija.BrojTelefona2;
                    o.BrojTelefona3 = musterija.BrojTelefona3;

                    s.Close();

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

            return o;

            }
            //public static List<OsobaBasic> GetOdInfos(long JMBG)
            //{
            //    List<OsobaBasic> odInfos = new List<OsobaBasic>();
            //    try
            //    {
            //        ISession s = DataLayer.GetSession();

            //        IQuery q = s.CreateQuery("from Osoba");

            //        IEnumerable<Osoba> osobe = q.Enumerable<Osoba>();

            //        foreach (Osoba o in osobe)
            //        {
            //            odInfos.Add(new OsobaBasic(o.Ime, o.SrednjeSlovo, o.Prezime, o.JMBG, o.BrojTelefona,o.Adresa));
            //        }

            //        s.Close();

            //    }
            //    catch (Exception ec)
            //    {
            //        //handle exceptions
            //    }

            //    return odInfos;
            //}

            public static void dodajMusteriju(MusterijaBasic p)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    TaksiUdruzenje.Entiteti.Musterija o = new TaksiUdruzenje.Entiteti.Musterija();

                    o.ID = p.ID;
                    o.Adresa = p.Adresa;
                    o.BrojTelefona1 = p.BrojTelefona1;
                    o.BrojTelefona2 = p.BrojTelefona2;
                    o.BrojTelefona3 = p.BrojTelefona3;

                    s.SaveOrUpdate(o);

                    s.Flush();

                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            public static void izmeniMusteriju(MusterijaBasic musterija)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    TaksiUdruzenje.Entiteti.Musterija o = s.Load<Musterija>(musterija.ID);

                    o.Adresa = musterija.Adresa;
                    o.BrojTelefona1 = musterija.BrojTelefona1;
                    o.BrojTelefona2 = musterija.BrojTelefona2;
                    o.BrojTelefona3 = musterija.BrojTelefona3;


                    s.SaveOrUpdate(o);

                    s.Flush();

                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
        }
            public static List<MusterijaBasic> vratiSveMusterijaBasic()
            {
                List<MusterijaBasic> listaMusterija = new List<MusterijaBasic>();
                try
                {
                    ISession s = DataLayer.GetSession();

                    IEnumerable<Musterija> musterije = from o in s.Query<TaksiUdruzenje.Entiteti.Musterija>()
                                                       select o;

                    foreach (Musterija p in musterije)
                    {
                        MusterijaBasic musterija = DTOManager.vratiMusteriju(p.ID);
                        listaMusterija.Add(musterija);
                    }

                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

             return listaMusterija;


            }
            public static List<VoznjaBasic> vratiSveVoznjeMusterije(int id)
            {
                List<VoznjaBasic> vozi = new List<VoznjaBasic>();
                try
                {
                    ISession s = DataLayer.GetSession();

                    IEnumerable<Voznja> k = from o in s.Query<TaksiUdruzenje.Entiteti.Voznja>()
                                            where o.Musterija.ID== id
                                            select o;

                    foreach (Voznja p in k)
                    {
                        VoznjaBasic q = DTOManager.VratiVoznju(p.ID);
                    vozi.Add(q);
                    }

                    s.Close();


                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                    return vozi;
                }
      
        #endregion

        #region Voznja
            public static void obrisiVoznju(int ID)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    Voznja voznja = s.Load<Voznja>(ID);

                    s.Delete(voznja);
                    s.Flush();

                    s.Close();

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }


                }
            public static VoznjaBasic VratiVoznju(int ID)
            {
                VoznjaBasic v = new VoznjaBasic();



                try
                {
                    ISession s = DataLayer.GetSession();

                    Voznja voznja = s.Load<Voznja>(ID);
                    v.ID = voznja.ID;
                    v.VremePocetkaVoznje = voznja.VremePocetkaVoznje;
                    v.VremeKrajaVoznje = voznja.VremeKrajaVoznje;
                    v.PocetnaStanica = voznja.PocetnaStanica;
                    v.KrajnjaStanica = voznja.KrajnjaStanica;
                    v.VremePrimanjaPoziva = voznja.VremePrimanjaPoziva;
                    v.Musterija = voznja.Musterija;
                    v.Vozac = voznja.Vozac;
                    v.AdministrativnoOsoblje = voznja.AdministrativnoOsoblje;

                    s.Close();

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                return v;

            }

            public static List<VoznjaBasic> vratiSveVoznjeBasic()
            {
                List<VoznjaBasic> voznje = new List<VoznjaBasic>();
                try
                {
                    ISession s = DataLayer.GetSession();

                    IEnumerable<Voznja> sveVoznje = from o in s.Query<TaksiUdruzenje.Entiteti.Voznja>()
                                                    select o;

                    foreach (Voznja v in sveVoznje)
                    {
                        VoznjaBasic osoba = DTOManager.VratiVoznju(v.ID);
                        voznje.Add(osoba);
                    }

                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                return voznje;



            }
            public static void dodajVoznju(VoznjaPregled v)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    TaksiUdruzenje.Entiteti.Voznja o = new TaksiUdruzenje.Entiteti.Voznja();

                    Vozac voz = s.Load<Vozac>(v.Vozac.JMBG);
                    AdministrativnoOsoblje admn = s.Load<AdministrativnoOsoblje>(v.AdministrativnoOsoblje.JMBG);
                    Musterija must = s.Load<Musterija>(v.Musterija.ID);

                    o.ID = v.ID;
                    o.VremePocetkaVoznje = v.VremePocetkaVoznje;
                    o.VremeKrajaVoznje = v.VremeKrajaVoznje;
                    o.PocetnaStanica = v.PocetnaStanica;
                    o.KrajnjaStanica = v.KrajnjaStanica;
                    o.Vozac = voz;
                    o.VremePrimanjaPoziva = v.VremePrimanjaPoziva;
                    o.Musterija = must;
                    o.AdministrativnoOsoblje = admn;

                    s.SaveOrUpdate(o);

                    s.Flush();

                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            public static void izmeniVoznju(VoznjaBasic voznja)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    TaksiUdruzenje.Entiteti.Voznja o = s.Load<Voznja>(voznja.ID);

                    o.PocetnaStanica = voznja.PocetnaStanica;
                    o.KrajnjaStanica = voznja.KrajnjaStanica;
                    o.VremeKrajaVoznje = voznja.VremeKrajaVoznje;



                    s.SaveOrUpdate(o);

                    s.Flush();

                    s.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }

            #endregion

        
    }
}
