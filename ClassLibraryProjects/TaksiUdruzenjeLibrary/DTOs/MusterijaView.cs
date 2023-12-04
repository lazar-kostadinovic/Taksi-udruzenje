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
    public class MusterijaView
    {
        public int ID { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona1 { get; set; }
        public string BrojTelefona2 { get; set; }
        public string BrojTelefona3 { get; set; }
        public IList<VoznjaView> Poziva { get; set; }

        public MusterijaView(Musterija m)
        {
            ID = m.ID;
            Adresa = m.Adresa;
            BrojTelefona1 = m.BrojTelefona1;
            BrojTelefona2 = m.BrojTelefona2;
            BrojTelefona3 = m.BrojTelefona3;
        }
        public MusterijaView()
        {
            Poziva = new List<VoznjaView>();
        }

    }
}