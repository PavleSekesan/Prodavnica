using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Lager
    {
        private Dictionary<string,int> artikalKolicina;
        private List<Artikal> artikli;
     
        public List<Artikal> SviArtikli
        {
            get => artikli;
        }
        public Dictionary<string, int> ArtkliKolicine
        {
            get => artikalKolicina;
        }
        public List<Artikal> PronadjiArtikle(string naziv, int kolicina)
        {
            List<Artikal> rezultat = new List<Artikal>();
            for (int i = 0; i < artikli.Count && rezultat.Count < kolicina; i++)
            {
                if (artikli[i].Naziv == naziv)
                {
                    rezultat.Add(artikli[i]);
                }
            }
            if (rezultat.Count < kolicina)
                throw new Exception("Nema dovoljno trazenog artikla");
            return rezultat;
        }
        public void DodajArtikal(Artikal artikal)
        {
            if (artikalKolicina.ContainsKey(artikal.Naziv))
                throw new Exception("Artikal vec postoji");
            else
                artikalKolicina[artikal.Naziv] = 0;
        }

        public void DodajNaStanje(List<Artikal> artikli)
        {
            foreach(Artikal a in artikli)
            {
                DodajNaStanje(a);
            }
        }
        public void SkiniSaStanja(List<Artikal> artikli)
        {
            foreach (Artikal a in artikli)
            {
                SkiniSaStanja(a);
            }
        }
        public void SkiniSaStanja(Artikal artikal)
        {
            if (artikalKolicina[artikal.Naziv] < 1)
            {
                throw new Exception("Trazeni artikal ne postoji u lageru");
            }
            artikalKolicina[artikal.Naziv]--;
            artikli.Remove(artikal);
        }
        public void DodajNaStanje(Artikal artikal)
        {
            if (!artikalKolicina.ContainsKey(artikal.Naziv))
                DodajArtikal(artikal);
            artikalKolicina[artikal.Naziv]++;
            artikli.Add(artikal);
        }
        public Lager()
        {
            artikalKolicina = new Dictionary<string, int>();
            artikli = new List<Artikal>();
        }
    }
}