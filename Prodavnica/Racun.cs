using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Racun
    {
        private List<Artikal> artikli;
        private DateTime datum;
        private Kasa kasa;
        private Kasir kasir;
        private Prodavnica prodavnica;

        public List<Artikal> Artikli
        {
            get => artikli;
        }

        public DateTime Datum
        {
            get => datum;
        }

        public Kasa Kasa
        {
            get => kasa;
        }

        public Kasir Kasir
        {
            get => kasir;
        }

        public Prodavnica Prodavnica
        {
            get => prodavnica;
        }

        /*
         Račun – predstavlja skup artikala koje je kupac kupio. Pored artikala, 
        svaki račun čuva i datum, broj kase i kasira koji je otkucao račun.
         */
        public Racun(Kasa kasa)
        {
            artikli = new List<Artikal>();
            this.kasa = kasa;
            kasir = kasa.TrenutniKasir;
            prodavnica = kasa.Prodavnica;
            
        }
        public void DodajArtikal(Artikal artikal)
        {
            artikli.Add(artikal);
        }
        public void Zavrsi()
        {
            foreach (var artikal in artikli)
            {
                prodavnica.LagerUProdavnici.UmanjiStanje(artikal);
            }
            datum = DateTime.Now;
        }
    }
}