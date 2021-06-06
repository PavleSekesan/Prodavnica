using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica
{
    public class VelikaProdavnica : Prodavnica
    {
        public VelikaProdavnica(double povrsina, string adresa) : base(povrsina, adresa)
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

            Dictionary<Type, int> svaRadnaMesta = new Dictionary<Type, int>()
            {
                { typeof(MenadzerProdavnice), 1 },
                { typeof(Kasir), 1 },
                { typeof(Aranzer), 1 },
                { typeof(Mesar), 1 },
                { typeof(Pekar), 1 },
                { typeof(PomocnoOsoblje), 1 }
            };

            kase = new List<Kasa>();
            DodajKase(2, ref kase);
            radnaMesta = radnaMestaSrednjeProdavnice;
            for (int i = 250; i <= povrsina; i += 50)
            {
                DodajKase(1, ref kase);
                DodajRadnaMesta(svaRadnaMesta, ref radnaMesta);
            }
        }
    }
}