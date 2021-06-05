using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class Kasa
    {
        private static int kasaBrojac = 0;
        private int idKase;
        private Dictionary<Tuple<DateTime,DateTime>, List<Racun>> racuniPoSmenama;
        private List<Racun> racuniUSmeni;
        private DateTime pocetakSmene;
        private Racun trenutniRacun;

        private Kasir kasir;
        private Prodavnica prodavnica;
        public Kasir TrenutniKasir
        {
            get => kasir;
        }
        public Prodavnica Prodavnica
        {
            get => prodavnica;
        }
        public Kasa(Prodavnica prodavnica)
        {
            idKase = kasaBrojac;
            kasaBrojac++;
            this.prodavnica = prodavnica;
            racuniPoSmenama = new Dictionary<Tuple<DateTime, DateTime>, List<Racun>>();
            racuniUSmeni = new List<Racun>();
        }
        public void ZavrsiSmenu()
        {
            Tuple<DateTime, DateTime> smena = new Tuple<DateTime, DateTime>(pocetakSmene, DateTime.Now);
            racuniPoSmenama[smena] = racuniUSmeni;
            racuniUSmeni.Clear();
            kasir = null;
        }

        public void ZapocniSmenu(Kasir kasir)
        {
            pocetakSmene = DateTime.Now;
            this.kasir = kasir;
            racuniUSmeni = new List<Racun>();
        }

        public void IzdajRacun(Racun racun)
        {
            racun.Zavrsi();
        }
        public void NoviRacun()
        {
            trenutniRacun = new Racun(this);
        }
        public void DodajNaTrenutniRacun(Artikal artikal)
        {
            trenutniRacun.DodajArtikal(artikal);
        }
    }
}
