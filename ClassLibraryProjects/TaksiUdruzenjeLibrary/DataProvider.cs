using NHibernate;
using TaksiUdruzenjeLibrary.DTOs;
using TaksiUdruzenjeLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TaksiUdruzenjeLibrary
{
    public class DataProvider
    {
        public static List<OsobaView> vratiSveOsobe()
        {
            List<OsobaView> zaposleni = new List<OsobaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Osoba> osobe = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Osoba>()
                                           select o;

                foreach (Osoba p in osobe)
                {
                    zaposleni.Add(new OsobaView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return zaposleni;
        }

        public static void dodajOsobu(OsobaView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Osoba o = new TaksiUdruzenjeLibrary.Entiteti.Osoba();

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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void azurirajOsobu(OsobaView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Osoba o = s.Load<Osoba>(p.JMBG);

                o.Ime = p.Ime;
                o.SrednjeSlovo = p.SrednjeSlovo;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrojTelefona = p.BrojTelefona;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static OsobaView vratiOsobu(long JMBG)
        {
            OsobaView o = new OsobaView();
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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return o;

        }

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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        /////////////////////////////////////
        public static List<AdministrativnoOsobljeView> vratiSvoAdministrativnoOsoblje()
        {
            List<AdministrativnoOsobljeView> zaposleni = new List<AdministrativnoOsobljeView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<AdministrativnoOsoblje> osobe = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.AdministrativnoOsoblje>()
                                                            select o;

                foreach (AdministrativnoOsoblje p in osobe)
                {
                    zaposleni.Add(new AdministrativnoOsobljeView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return zaposleni;
        }

        public static void dodajAdministrativnoOsoblje(AdministrativnoOsobljeView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.AdministrativnoOsoblje o = new TaksiUdruzenjeLibrary.Entiteti.AdministrativnoOsoblje();

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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void azurirajAdministrativnoOsoblje(AdministrativnoOsobljeView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.AdministrativnoOsoblje o = s.Load<AdministrativnoOsoblje>(p.JMBG);

                o.Ime = p.Ime;
                o.SrednjeSlovo = p.SrednjeSlovo;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrojTelefona = p.BrojTelefona;
                o.StrucnaSprema = p.StrucnaSprema;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static AdministrativnoOsobljeView vratiAdministrativnoOsoblje(long JMBG)
        {
            AdministrativnoOsobljeView o = new AdministrativnoOsobljeView();
            try
            {
                ISession s = DataLayer.GetSession();

                AdministrativnoOsoblje osoba = s.Load<AdministrativnoOsoblje>(JMBG);

                o.Ime = osoba.Ime;
                o.SrednjeSlovo = osoba.SrednjeSlovo;
                o.Prezime = osoba.Prezime;
                o.Adresa = osoba.Adresa;
                o.BrojTelefona = osoba.BrojTelefona;
                o.JMBG = osoba.JMBG;
                o.StrucnaSprema = osoba.StrucnaSprema;

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return o;

        }

        public static void obrisiAdministrativnoOsoblje(long JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AdministrativnoOsoblje osoba = s.Load<AdministrativnoOsoblje>(JMBG);

                s.Delete(osoba);
                s.Flush();

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        /////////////////////////////////////
        public static List<VozacView> vratiSveVozace()
        {
            List<VozacView> zaposleni = new List<VozacView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozac> osobe = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Vozac>()
                                           select o;

                foreach (Vozac p in osobe)
                {
                    zaposleni.Add(new VozacView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return zaposleni;
        }

        public static void dodajVozaca(VozacView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Vozac o = new TaksiUdruzenjeLibrary.Entiteti.Vozac();

                o.Ime = p.Ime;
                o.SrednjeSlovo = p.SrednjeSlovo;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrojTelefona = p.BrojTelefona;
                o.Kategorija = p.Kategorija;
                o.BrVozackeDozvole = p.BrVozackeDozvole;
                o.JMBG = p.JMBG;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void azurirajVozaca(VozacView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Vozac o = s.Load<Vozac>(p.JMBG);

                o.Ime = p.Ime;
                o.SrednjeSlovo = p.SrednjeSlovo;
                o.Prezime = p.Prezime;
                o.Adresa = p.Adresa;
                o.BrojTelefona = p.BrojTelefona;
                o.Kategorija = p.Kategorija;
                o.BrVozackeDozvole = p.BrVozackeDozvole;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static VozacView vratiVozaca(long JMBG)
        {
            VozacView o = new VozacView();
            try
            {
                ISession s = DataLayer.GetSession();

                Vozac osoba = s.Load<Vozac>(JMBG);

                o.Ime = osoba.Ime;
                o.SrednjeSlovo = osoba.SrednjeSlovo;
                o.Prezime = osoba.Prezime;
                o.Adresa = osoba.Adresa;
                o.BrojTelefona = osoba.BrojTelefona;
                o.JMBG = osoba.JMBG;
                o.Kategorija = osoba.Kategorija;
                o.BrVozackeDozvole = osoba.BrVozackeDozvole;

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return o;

        }

        public static void obrisiVozaca(long JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozac osoba = s.Load<Vozac>(JMBG);

                s.Delete(osoba);
                s.Flush();

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        /////////////////////////////////////
        public static KoristiView vratiKoristi(int id)
        {
            KoristiView o = new KoristiView();
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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return o;
        }

        public static void dodajKoristi(KoristiView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Koristi o = new TaksiUdruzenjeLibrary.Entiteti.Koristi();

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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void azurirajKoristi(KoristiView koristi)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Koristi o = s.Load<Koristi>(koristi.ID);

                o.DatumOd = koristi.DatumOd;
                o.DatumDo = koristi.DatumDo;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static IList<KoristiView> vratiSveKoristi()
        {
            List<KoristiView> koristi = new List<KoristiView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Koristi> k = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Koristi>()
                                         select o;

                foreach (Koristi p in k)
                {
                    koristi.Add(new KoristiView(p));
                }

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return koristi;

        }

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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        public static List<KoristiView> vratiSvaVozilaKojaJeKoristioVozac(long jmbg)
        {
            List<KoristiView> koristi = new List<KoristiView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Koristi> k = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Koristi>()
                                         where o.VozacVozi.JMBG == jmbg
                                         select o;

                foreach (Koristi p in k)
                {
                    koristi.Add(new KoristiView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return koristi;
        }
        public static List<KoristiView> vratiSveVozaceKojiSuKoristiliVozilo(int id)
        {
            List<KoristiView> koristi = new List<KoristiView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Koristi> k = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Koristi>()
                                         where o.VoziVozilo.ID == id
                                         select o;

                foreach (Koristi p in k)
                {
                    koristi.Add(new KoristiView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return koristi;
        }
        /////////////////////////////////////
        public static List<MusterijaView> vratiSveMusterije()
        {
            List<MusterijaView> listaMusterija = new List<MusterijaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Musterija> musterije = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Musterija>()
                                                   select o;

                foreach (Musterija p in musterije)
                {
                    listaMusterija.Add(new MusterijaView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return listaMusterija;

        }

        public static void dodajMusteriju(MusterijaView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Musterija o = new TaksiUdruzenjeLibrary.Entiteti.Musterija();

                o.ID = p.ID;
                o.Adresa = p.Adresa;
                o.BrojTelefona1 = p.BrojTelefona1;
                o.BrojTelefona2 = p.BrojTelefona2;
                o.BrojTelefona3 = p.BrojTelefona3;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static void azurirajMusteriju(MusterijaView musterija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Musterija o = s.Load<Musterija>(musterija.ID);

                o.Adresa = musterija.Adresa;
                o.BrojTelefona1 = musterija.BrojTelefona1;
                o.BrojTelefona2 = musterija.BrojTelefona2;
                o.BrojTelefona3 = musterija.BrojTelefona3;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        public static MusterijaView vratiMusteriju(int id)
        {
            MusterijaView o = new MusterijaView();
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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return o;
        }

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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void dodajSopstvenoVozilo(SopstvenoVoziloView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.SopstvenoVozilo o = new TaksiUdruzenjeLibrary.Entiteti.SopstvenoVozilo();

                o.ID = p.ID;
                o.Marka = p.Marka;
                o.Tip = p.Tip;
                o.Boja = p.Boja;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void izmeniSopstvenoVozilo(SopstvenoVoziloView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.SopstvenoVozilo voz = s.Load<SopstvenoVozilo>(v.ID);

                voz.Boja = v.Boja;
                s.SaveOrUpdate(voz);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }



        public static SopstvenoVoziloView vratiSopstvenoVozilo(int ID)
        {
            SopstvenoVoziloView o = new SopstvenoVoziloView();

            try
            {
                ISession s = DataLayer.GetSession();

                SopstvenoVozilo vozilo = s.Load<SopstvenoVozilo>(ID);

                o.ID = vozilo.ID;
                o.Marka = vozilo.Marka;
                o.Tip = vozilo.Tip;
                // o.VoziVozac = (IList<KoristiView>)vozilo.VoziVozac;
                o.Boja = vozilo.Boja;


                s.Close();

            }
            catch (Exception)
            {
                throw;
            }

            return o;

        }
        public static List<SopstvenoVoziloView> vratiSvaSopstvenaVozila()
        {
            List<SopstvenoVoziloView> vozila = new List<SopstvenoVoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SopstvenoVozilo> svaVozila = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.SopstvenoVozilo>()
                                                         select o;

                foreach (SopstvenoVozilo p in svaVozila)
                {
                    vozila.Add(new SopstvenoVoziloView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return vozila;
        }
        public static void obrisiSopstvenoVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SopstvenoVozilo vozilo = s.Load<SopstvenoVozilo>(id);

                s.Delete(vozilo);
                s.Flush();

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void dodajVoziloTaksiSluzbe(VoziloTaksiSluzbeView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.VoziloTaksiSluzbe o = new TaksiUdruzenjeLibrary.Entiteti.VoziloTaksiSluzbe();

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
            catch (Exception)
            {
                throw;
            }
        }
        public static void izmeniVoziloTaksiSluzbe(VoziloTaksiSluzbeView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.VoziloTaksiSluzbe voz = s.Load<VoziloTaksiSluzbe>(v.ID);

                voz.DatumIstekaRegistracije = v.DatumIstekaRegistracije;
                voz.RegistarskaOznaka = v.RegistarskaOznaka;
                s.SaveOrUpdate(voz);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }



        public static VoziloTaksiSluzbeView vratiVoziloTaksiSluzbe(int ID)
        {
            VoziloTaksiSluzbeView o = new VoziloTaksiSluzbeView();

            try
            {
                ISession s = DataLayer.GetSession();

                VoziloTaksiSluzbe vozilo = s.Load<VoziloTaksiSluzbe>(ID);

                o.ID = vozilo.ID;
                o.Marka = vozilo.Marka;
                o.Tip = vozilo.Tip;
                //o.VoziVozac = (IList<KoristiView>)vozilo.VoziVozac;
                o.DatumIstekaRegistracije = vozilo.DatumIstekaRegistracije;
                o.RegistarskaOznaka = vozilo.RegistarskaOznaka;
                o.GodinaProizvodnje = vozilo.GodinaProizvodnje;

                s.Close();

            }
            catch (Exception)
            {
                throw;
            }

            return o;

        }
        public static List<VoziloTaksiSluzbeView> vratiSvaVozilaTaksiSluzbe()
        {
            List<VoziloTaksiSluzbeView> vozila = new List<VoziloTaksiSluzbeView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VoziloTaksiSluzbe> svaVozila = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.VoziloTaksiSluzbe>()
                                                           select o;

                foreach (VoziloTaksiSluzbe p in svaVozila)
                {
                    vozila.Add(new VoziloTaksiSluzbeView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return vozila;
        }
        public static void obrisiVoziloTaksiSluzbe(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VoziloTaksiSluzbe vozilo = s.Load<VoziloTaksiSluzbe>(id);

                s.Delete(vozilo);
                s.Flush();

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////
        public static VoziloView vratiVozilo(int id)
        {
            VoziloView o = new VoziloView();
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(id);

                o.ID = vozilo.ID;
                o.Marka = vozilo.Marka;
                o.Tip = vozilo.Tip;

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return o;

        }
        public static void dodajVozilo(VoziloView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Vozilo o = new TaksiUdruzenjeLibrary.Entiteti.Vozilo();

                o.ID = p.ID;
                o.Marka = p.Marka;
                o.Tip = p.Tip;
                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void izmeniVozilo(VoziloView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Vozilo voz = s.Load<Vozilo>(v.ID);
                voz.Marka = v.Marka;
                voz.Tip = v.Tip;
                s.SaveOrUpdate(voz);
                s.Flush();
                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<VoziloView> vratiSvaVozila()
        {
            List<VoziloView> vozila = new List<VoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> svaVozila = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Vozilo>()
                                                select o;

                foreach (Vozilo p in svaVozila)
                {
                    vozila.Add(new VoziloView(p));
                }

                s.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return vozila;
        }
        public static void obrisiVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(id);

                s.Delete(vozilo);
                s.Flush();

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        public static VoznjaView VratiVoznju(int ID)
        {
            VoznjaView v = new VoznjaView();
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
                v.Musterija = vratiMusteriju(voznja.Musterija.ID);
                v.Vozac = vratiVozaca(voznja.Vozac.JMBG);
                v.AdministrativnoOsoblje = vratiAdministrativnoOsoblje(voznja.AdministrativnoOsoblje.JMBG);

                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }

            return v;

        }

        public static List<VoznjaView> vratiSveVoznje()
        {
            List<VoznjaView> voznje = new List<VoznjaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> sveVoznje = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Voznja>()
                                                select o;

                foreach (Voznja v in sveVoznje)
                {

                    voznje.Add(new VoznjaView(v));
                }

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return voznje;
        }
        public static void dodajVoznju(VoznjaView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Voznja o = new TaksiUdruzenjeLibrary.Entiteti.Voznja();

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
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        public static void izmeniVoznju(VoznjaView voznja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaksiUdruzenjeLibrary.Entiteti.Voznja o = s.Load<Voznja>(voznja.ID);

                o.PocetnaStanica = voznja.PocetnaStanica;
                o.KrajnjaStanica = voznja.KrajnjaStanica;
                o.VremeKrajaVoznje = voznja.VremeKrajaVoznje;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
        }
        public static List<VoznjaView> vratiSveVoznjeVozaca(long jmbg)
        {
            List<VoznjaView> koristi = new List<VoznjaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> k = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Voznja>()
                                        where o.Vozac.JMBG == jmbg
                                        select o;
                foreach (Voznja p in k)
                {

                    koristi.Add(new VoznjaView(p));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return koristi;
        }
        public static List<VoznjaView> vratiSveVoznjeAdmOsoblja(long jmbg)
        {
            List<VoznjaView> koristi = new List<VoznjaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> k = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Voznja>()
                                        where o.AdministrativnoOsoblje.JMBG == jmbg
                                        select o;
                foreach (Voznja p in k)
                {
                    koristi.Add(new VoznjaView(p));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return koristi;
        }
        public static List<VoznjaView> vratiSveVoznjeMusterije(int id)
        {
            List<VoznjaView> koristi = new List<VoznjaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Voznja> k = from o in s.Query<TaksiUdruzenjeLibrary.Entiteti.Voznja>()
                                        where o.Musterija.ID == id
                                        select o;
                foreach (Voznja p in k)
                {
                    koristi.Add(new VoznjaView(p));
                }
                s.Close();
            }
            catch (Exception)
            {
                //handle exceptions
                throw;
            }
            return koristi;
        }

    }
}