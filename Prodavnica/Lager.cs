using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Lager
    {
        private Dictionary<Artikal,int> artikalKolicina;
     
        public Dictionary<Artikal, int> SviArtikli
        {
            get => artikalKolicina;
        }
        public void DodajArtikal(Artikal artikal)
        {
            if (artikalKolicina.ContainsKey(artikal))
                throw new Exception("Artikal vec postoji");
            else
                artikalKolicina[artikal] = 0;
        }

        public void DodajGrupuArtikala(List<Artikal> artikli)
        {
            foreach(Artikal a in artikli)
            {
                artikalKolicina[a] = 0;
            }
        }
        public void UmanjiStanje(Artikal artikal, int promena = 1)
        {
            if (artikalKolicina[artikal] < promena)
            {
                throw new Exception("Kolicina datog artikla je manja nego trazena kolicina");
            }
            artikalKolicina[artikal] -= promena;
        }
        public void UvecajStanje(Artikal artikal, int promena = 1)
        {
            if (!artikalKolicina.ContainsKey(artikal))
                DodajArtikal(artikal);
            artikalKolicina[artikal] += promena;
        }
        public Lager()
        {
            artikalKolicina = new Dictionary<Artikal, int>();
        }
        public List<string> ToStringList()
        {
            List<string> sviArtikli = new List<string>();
            foreach (var artikal in artikalKolicina)
            {
                sviArtikli.Add(artikal.Key + ": " + artikal.Value);
            }
            return sviArtikli;
        }
    }
}