using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Lager
    {
        private Dictionary<Artikal,int> artikalKolicina;
        public void DodajArtikal(Artikal artikal)
        {
            artikalKolicina[artikal] = 0;
        }
        public void UmanjiStanje(Artikal artikal, int promena = 1)
        {
            artikalKolicina[artikal] -= promena;
        }
    }
}