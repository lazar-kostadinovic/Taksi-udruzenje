using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using System.Windows.Forms;
using TaksiUdruzenje.Entiteti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TaksiUdruzenje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                TaksiUdruzenje.Entiteti.Vozac o = s.Load<TaksiUdruzenje.Entiteti.Vozac>(1234567890123);

                MessageBox.Show(o.BrVozackeDozvole.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Vozac p = new Entiteti.Vozac();

                p.Ime = "Ime";
                p.SrednjeSlovo = 'K';
                p.Prezime = "NI123";
                p.Adresa = "Nissan";
                p.BrojTelefona = 0123;
                p.JMBG = 3213;
                p.BrVozackeDozvole = 555;
                p.Kategorija = "A";



                s.Save(p);

                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodato");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Musterija o = s.Load<Musterija>(1);

                //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije
             

                //objekat se modifikuje potpuno nezavisno od sesije
                o.BrojTelefona1 = "06022567123";

        

                //poziva se Update i objekat se povezuje sa novom sesijom
                s.Update(o);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Vozac o = s.Load<Vozac>(1234567890123);

                MessageBox.Show(o.Ime);
                foreach(Koristi vozac in o.KoristiVozilo)
                {
                    MessageBox.Show(vozac.VoziVozilo.Marka);
                }
                
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Vozilo p = new Entiteti.Vozilo()
                {
                    Marka = "Emi Shop",
                    Tip = "Nesto"

                };

                Vozac o = new Vozac()
                {
                    BrVozackeDozvole = 1111,
                    Kategorija = "A",
                    Ime = "marija",
                    SrednjeSlovo = 'M',
                    Prezime = "marikovic",
                    JMBG = 1508999732515,
                    BrojTelefona = 123123123,
                    Adresa = "Cara Dusana"
                };

                Koristi k = new Koristi()
                {
                    DatumDo = new DateTime(2015, 12, 25),
                    DatumOd = new DateTime(2015, 12, 23)


                };
                s.Save(p);
                s.Save(o);
                s.Save(k);


                o.KoristiVozilo.Add(k);
                s.Save(o);
                k.VozacVozi = o;
                s.Save(k);

                p.VoziVozac.Add(k);
                s.Save(p);


                k.VoziVozilo = p;
                s.Save(k);

                MessageBox.Show("Uspesno dodato");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozac r = s.Load<Vozac>(1503998134567);
                Entiteti.Vozilo p = s.Load<Entiteti.Vozilo>(3);

                Koristi ru = new Koristi();
                ru.VoziVozilo = p;
                ru.VozacVozi = r;
                ru.DatumOd = DateTime.Now;
                ru.DatumDo = DateTime.Now;


                s.Save(ru);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Vozac r1 = s.Load<Vozac>(1234567890123);

                foreach (Entiteti.Koristi p1 in r1.KoristiVozilo)
                {
                    MessageBox.Show(p1.VoziVozilo.Marka);
                }


                Vozilo v = s.Load<Vozilo>(6);

                foreach (Entiteti.Koristi p2 in v.VoziVozac)
                {
                    MessageBox.Show(p2.ID.ToString());
                }


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Musterija p = new Entiteti.Musterija()
                {
                    Adresa="Cara Dusana",
                    BrojTelefona1 = "999222100"
                };

                Entiteti.Voznja o = new Entiteti.Voznja()
                {
                    PocetnaStanica = "Niš",
                    KrajnjaStanica = "Beograd",
                    VremePocetkaVoznje = DateTime.Now,
                    VremeKrajaVoznje = DateTime.Now,
                    VremePrimanjaPoziva=DateTime.Now

                };

                Vozac v = new Vozac()
                {
                    BrVozackeDozvole = 1111,
                    Kategorija = "A",
                    Ime = "marija",
                    SrednjeSlovo = 'M',
                    Prezime = "marikovic",
                    JMBG = 1508999732515,
                    BrojTelefona = 123123123,
                    Adresa = "Cara Dusana"
                };

                Entiteti.AdministrativnoOsoblje a = new Entiteti.AdministrativnoOsoblje()
                {
                    StrucnaSprema="SSS",
                    Ime = "marija",
                    SrednjeSlovo = 'M',
                    Prezime = "marikovic",
                    JMBG = 7508999732525,
                    BrojTelefona = 123123723,
                    Adresa = "Cara Dusana"
                };
                s.Save(v);
                s.Save(a);

                o.AdministrativnoOsoblje = a;
                o.Vozac = v;
                o.Musterija = p;
            
            
              


                p.Poziva.Add(o);
                v.ObavioVoznju.Add(o);
                a.PrimoPoziv.Add(o);
          

                s.Save(p);
                s.Flush();
                s.Close();

                MessageBox.Show("USPESNO");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Osoba> osobe = s.QueryOver<Osoba>()
                                                .Where(p => p.JMBG == 321)
                                                .List<Osoba>();

                Vozac v = (Vozac)osobe[0];

                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja o = s.Get<Voznja>(1);

                if (o != null)
                {
                    MessageBox.Show(o.AdministrativnoOsoblje.Ime);
                }
                else
                {
                    MessageBox.Show("Ne postoji voznja sa tim ID");
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Osoba");

                IList<Osoba> osobe = q.List<Osoba>();

                foreach (Osoba o in osobe)
                {
                    MessageBox.Show(o.Ime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Odeljenja koja nemaju info pult
                IQuery q = s.CreateQuery("from Osoba as o where o.Adresa = 'Cara Dusana'");

                IList<Osoba> osobe = q.List<Osoba>();

                foreach (Osoba o in osobe)
                {
                    MessageBox.Show(o.Ime + " " + o.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Odeljenja koja nemaju info pult
                IQuery q = s.CreateQuery("from Osoba as o where o.Adresa = ? ");
                q.SetParameter(0, "Cara Dusana");

                IList<Osoba> osobe = q.List<Osoba>();

                foreach (Osoba o in osobe)
                {
                    MessageBox.Show(o.Ime + " " + o.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from AdministrativnoOsoblje");

                IEnumerable<AdministrativnoOsoblje> osoblje = q.Enumerable<AdministrativnoOsoblje>();

                foreach (AdministrativnoOsoblje o in osoblje)
                {
                    if (o.StrucnaSprema == "SSS")
                        MessageBox.Show(o.Ime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Osoba");
                q.SetFirstResult(10);
                q.SetMaxResults(6);

                IList<Osoba> osobe = q.List<Osoba>();

                foreach (Osoba o in osobe)
                {
                    MessageBox.Show(o.Ime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Musterija o = s.Load<Musterija>(79);

                //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije
                //s.Close();

                //objekat se modifikuje potpuno nezavisno od sesije
                o.BrojTelefona2 = "065323454";

                //otvara se nova sesija
                //ISession s1 = DataLayer.GetSession();

                //poziva se Update i objekat se povezuje sa novom sesijom
                s.Update(o);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Osoba o = s.Load<Osoba>(1508999732515);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(o);
                //s.Delete("from Odeljenje");

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
