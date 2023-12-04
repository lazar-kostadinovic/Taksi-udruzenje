using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti
{
    public class Musterija
    {

        public virtual int ID { get; set; }


        public virtual string Adresa { get; set; }


        public virtual string BrojTelefona1 { get; set; }


        public virtual string BrojTelefona2 { get; set; }


        public virtual string BrojTelefona3 { get; set; }

        public virtual IList<Voznja> Poziva { get; set; }

        public Musterija()
        {
            Poziva = new List<Voznja>();
        }


    }
}
