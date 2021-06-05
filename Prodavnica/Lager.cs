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
        public Lager()
        {
            artikalKolicina = new Dictionary<Artikal, int>();
        }
        public override string ToString()
        {
            StringBuilder sviArtikli = new StringBuilder();
            foreach (var artikal in artikalKolicina)
            {
                sviArtikli.Append(artikal.Key + ": " + artikal.Value + Environment.NewLine);
            }
            return sviArtikli.ToString();
        }
    }
}