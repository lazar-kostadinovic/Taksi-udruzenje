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
    public class AdministrativnoOsobljeView
    {
        public string Ime { get; set; }
        public char SrednjeSlovo { get; set; }
        public string Prezime { get; set; }
        public long JMBG { get; set; }
        public int BrojTelefona { get; set; }
        public string Adresa { get; set; }
      
        public string StrucnaSprema { get; set; }
        public IList<VoznjaView> PrimioPoziv { get; set; }
       
        public AdministrativnoOsobljeView(AdministrativnoOsoblje p)
        {
            Ime = p.Ime;
            SrednjeSlovo = p.SrednjeSlovo;
            Prezime = p.Prezime;
            JMBG = p.JMBG;
            BrojTelefona = p.BrojTelefona;
            Adresa = p.Adresa;
            StrucnaSprema = p.StrucnaSprema;    
        }

        public AdministrativnoOsobljeView()
        {
            PrimioPoziv = new List<VoznjaView>();   
        }

    }
}