using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class SrednjaProdavnica : Prodavnica
    {
        public SrednjaProdavnica(double povrsina, string adresa, PoslovnaJedinica poslovnaJedinica) : base(povrsina, adresa, poslovnaJedinica)
        {
            var radnaMestaSrednjeProdavnice = new List<RadnoMesto>();
            DodajRadnaMesta(new Dictionary<Type, int>(){
                { typeof(MenadzerProdavnice), 2 },
                { typeof(Kasir), 4 },
                { typeof(Aranzer), 4 },
                { typeof(Mesar), 4 },
                { typeof(Pekar), 2 },
                { typeof(PomocnoOsoblje), 2 }
            }, ref radnaMestaSrednjeProdavnice);

            proizvodiVanPonude = new List<Type>() { typeof(Pecivo) };
            radnaMesta = radnaMestaSrednjeProdavnice;
            kase = new List<Kasa>();
            DodajKase(2, ref kase);
        }
    }
}